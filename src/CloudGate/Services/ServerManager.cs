﻿using CloudGate.Conf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using SystemModule;

namespace CloudGate.Services
{
    public enum MessageThreadState
    {
        Runing,
        Stop
    }

    public class ServerManager
    {
        private static readonly ServerManager instance = new ServerManager();
        public static ServerManager Instance => instance;
        /// <summary>
        /// 配置文件
        /// </summary>
        private static GateConfig Config => ConfigManager.Instance.GateConfig;
        /// <summary>
        /// 服务器列表
        /// </summary>
        private readonly IList<ServerService> _serverServices;
        /// <summary>
        /// 消息消费者
        /// </summary>
        private MessageThreadConsume[] _messageThreads;
        private int _lastMessageThreadCount;
        /// <summary>
        /// 接收封包（客户端-》网关）
        /// </summary>
        private readonly Channel<TMessageData> _reviceMsgQueue = null;
        private Task _processReviceMessageTask;

        public ServerManager()
        {
            _reviceMsgQueue = Channel.CreateUnbounded<TMessageData>();
            _serverServices = new List<ServerService>();
        }

        public void AddServer(ServerService serverService)
        {
            _serverServices.Add(serverService);
        }

        public void RemoveServer(ServerService serverService)
        {
            _serverServices.Remove(serverService);
        }

        public void Start()
        {
            _messageThreads = new MessageThreadConsume[4];
            for (int i = 0; i < Config.MessageThread; i++)
            {
                _messageThreads[i] = new MessageThreadConsume(_reviceMsgQueue.Reader);
            }

            var serverQueueTask = new Task[_serverServices.Count];
            for (var i = 0; i < _serverServices.Count; i++)
            {
                if (_serverServices[i] == null)
                {
                    continue;
                }
                serverQueueTask[i] = _serverServices[i].Start();
            }

            Task.WhenAll(serverQueueTask);
        }

        public void Stop()
        {
            for (var i = 0; i < _serverServices.Count; i++)
            {
                if (_serverServices[i] == null)
                {
                    continue;
                }
                _serverServices[i].Stop();
            }
        }

        /// <summary>
        /// 客户端消息添加到队列给服务端处理
        /// GameGate -> GameSvr
        /// </summary>
        /// <param name="messageData"></param>
        public void SendQueue(TMessageData messageData)
        {
            _reviceMsgQueue.Writer.TryWrite(messageData);
        }

        public int MessageThreadCount => Config.MessageThread;

        /// <summary>
        /// 开启客户端消息消费线程
        /// </summary>
        public void StartProcessMessage(CancellationToken stoppingToken)
        {
            _processReviceMessageTask = Task.Factory.StartNew(() =>
            {
                if (_lastMessageThreadCount == Config.MessageThread)
                {
                    return;
                }
                switch (Config.MessageThread)
                {
                    case 1:
                        if (_messageThreads[0].ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[0]?.Start();
                        }
                        if (_messageThreads[1]?.ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[1]?.Stop();
                        }
                        if (_messageThreads[2]?.ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[2]?.Stop();
                        }
                        if (_messageThreads[3]?.ThreadState == MessageThreadState.Runing)
                        {
                            _messageThreads[3]?.Stop();
                        }
                        break;
                    case 2:
                        if (_messageThreads[0]?.ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[0]?.Start();
                        }
                        if (_messageThreads[1]?.ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[1]?.Start();
                        }
                        if (_messageThreads[2]?.ThreadState == MessageThreadState.Runing)
                        {
                            _messageThreads[2]?.Stop();
                        }
                        if (_messageThreads[3]?.ThreadState == MessageThreadState.Runing)
                        {
                            _messageThreads[3]?.Stop();
                        }
                        break;
                    case 3:
                        if (_messageThreads[0]?.ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[0]?.Start();
                        }
                        if (_messageThreads[1].ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[1]?.Start();
                        }
                        if (_messageThreads[2].ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[2]?.Start();
                        }
                        if (_messageThreads[2]?.ThreadState == MessageThreadState.Runing)
                        {
                            _messageThreads[3]?.Stop();
                        }
                        break;
                    case 4:
                        if (_messageThreads[0]?.ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[0]?.Start();
                        }
                        if (_messageThreads[1].ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[1]?.Start();
                        }
                        if (_messageThreads[2].ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[2]?.Start();
                        }
                        if (_messageThreads[3]?.ThreadState == MessageThreadState.Stop)
                        {
                            _messageThreads[3]?.Start();
                        }
                        break;
                }
                _lastMessageThreadCount = Config.MessageThread;

            }, stoppingToken);
        }

        public IList<ServerService> GetServerList()
        {
            return _serverServices;
        }

        public ClientThread GetClientThread()
        {
            //TODO 根据配置文件有四种模式  默认随机
            //1.轮询分配
            //2.总是分配到最小资源 即网关在线人数最小的那个
            //3.一直分配到一个 直到当前玩家达到配置上线，则开始分配到其他可用网关
            //4.按权重分配
            if (!_serverServices.Any())
                return null;
            if (_serverServices.Count == 1)
            {
                return _serverServices[0].ClientThread;
            }
            var random = RandomNumber.GetInstance().Random(_serverServices.Count);
            return _serverServices[random].ClientThread;
        }

        public class MessageThreadConsume
        {
            private readonly ManualResetEvent _resetEvent;
            private Task _messageThreads;
            private readonly string _threadId;
            private SessionManager Session => SessionManager.Instance;
            private readonly CancellationTokenSource _cts = new CancellationTokenSource();
            private static MirLog LogQueue => MirLog.Instance;
            /// <summary>
            /// 接收封包（客户端-》网关）
            /// </summary>
            private readonly ChannelReader<TMessageData> _reviceMsgList = null;
            public MessageThreadState ThreadState;

            public MessageThreadConsume(ChannelReader<TMessageData> channel)
            {
                _reviceMsgList = channel;
                _resetEvent = new ManualResetEvent(true);
                _threadId = Guid.NewGuid().ToString("N");
                ThreadState = MessageThreadState.Stop;
            }

            public void Start()
            {
                _messageThreads = Task.Factory.StartNew(async () =>
                {
                    ThreadState = MessageThreadState.Runing;
                    LogQueue.EnqueueDebugging($"消息消费线程[{_threadId}]已启动.");
                    while (await _reviceMsgList.WaitToReadAsync(_cts.Token))
                    {
                        _resetEvent.WaitOne();
                        if (_reviceMsgList.TryRead(out var message))
                        {
                            var clientSession = Session.GetSession(message.MessageId);
                            clientSession?.HandleSessionPacket(message);
                        }
                    }
                }, _cts.Token);
            }

            public void Stop()
            {
                ThreadState = MessageThreadState.Stop;
                _resetEvent.Reset();//暂停
                _cts.CancelAfter(3000);//延时3秒取消消费，防止消息丢失
                _messageThreads.Dispose();
                LogQueue.EnqueueDebugging($"消息消费线程[{_threadId}]已停止.");
            }
        }

    }
}