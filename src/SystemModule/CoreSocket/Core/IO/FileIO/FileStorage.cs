using System;
using System.IO;
using System.Threading;
using SystemModule.Extensions;
using TouchSocket.Resources;

namespace TouchSocket.Core;

/// <summary>
/// 文件存储器。在该存储器中，读写线程安全。
/// </summary>
[IntelligentCoder.AsyncMethodPoster(Flags = IntelligentCoder.MemberFlags.Public)]
public partial class FileStorage
{
    internal volatile int m_reference;
    private readonly ReaderWriterLockSlim m_lockSlim;
    private bool m_disposedValue;
    private byte[] m_fileData;

    /// <summary>
    /// 初始化一个文件存储器。在该存储器中，读写线程安全。
    /// </summary>
    internal FileStorage(FileInfo fileInfo, FileAccess fileAccess) : this()
    {
        FileAccess = fileAccess;
        FileInfo = fileInfo;
        Path = fileInfo.FullName;
        m_reference = 0;
        FileStream = fileAccess == FileAccess.Read ? fileInfo.OpenRead() : fileInfo.OpenWrite();
        m_lockSlim = new ReaderWriterLockSlim();
    }

    private FileStorage()
    {
        AccessTime = DateTime.Now;
        AccessTimeout = TimeSpan.FromSeconds(60);
    }

    /// <summary>
    /// 最后访问时间。
    /// </summary>
    public DateTime AccessTime { get; private set; }

    /// <summary>
    /// 访问超时时间。默认10s
    /// </summary>
    public TimeSpan AccessTimeout { get; set; }

    /// <summary>
    /// 是否为缓存型。为false时，意味着该文件句柄正在被该程序占用。
    /// </summary>
    public bool Cache { get; private set; }

    /// <summary>
    /// 访问属性
    /// </summary>
    public FileAccess FileAccess { get; private set; }

    /// <summary>
    /// 文件信息
    /// </summary>
    public FileInfo FileInfo { get; private set; }

    /// <summary>
    /// 文件流。
    /// 一般情况下，请不要直接访问该对象。否则有可能会产生不可预测的错误。
    /// </summary>
    public FileStream FileStream { get; private set; }

    /// <summary>
    /// 文件长度
    /// </summary>
    public long Length => FileStream.Length;

    /// <summary>
    /// 文件路径
    /// </summary>
    public string Path { get; private set; }

    /// <summary>
    /// 引用次数。
    /// </summary>
    public int Reference => m_reference;

    /// <summary>
    /// 创建一个只读的、已经缓存的文件信息。该操作不会占用文件句柄。
    /// </summary>
    /// <param name="path"></param>
    /// <param name="fileStorage"></param>
    /// <param name="msg"></param>
    /// <returns></returns>
    public static bool TryCreateCacheFileStorage(string path, out FileStorage fileStorage, out string msg)
    {
        path = System.IO.Path.GetFullPath(path);
        if (!File.Exists(path))
        {
            fileStorage = null;
            msg = TouchSocketStatus.FileNotExists.GetDescription(path);
            return false;
        }
        try
        {
            fileStorage = new FileStorage()
            {
                Cache = true,
                FileAccess = FileAccess.Read,
                FileInfo = new FileInfo(path),
                Path = path,
                m_reference = 0,
                m_fileData = File.ReadAllBytes(path)
            };
            msg = null;
            return true;
        }
        catch (Exception ex)
        {
            fileStorage = null;
            msg = ex.Message;
            return false;
        }
    }

    /// <summary>
    /// 写入时清空缓存区
    /// </summary>
    public void Flush()
    {
        AccessTime = DateTime.Now;
        FileStream.Flush();
    }

    /// <summary>
    /// 从指定位置，读取数据到缓存区。线程安全。
    /// </summary>
    /// <param name="stratPos"></param>
    /// <param name="buffer"></param>
    /// <param name="offset"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public int Read(long stratPos, byte[] buffer, int offset, int length)
    {
        AccessTime = DateTime.Now;
        using (WriteLock writeLock = new WriteLock(m_lockSlim))
        {
            if (m_disposedValue)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }
            if (FileAccess == FileAccess.Write)
            {
                throw new Exception("该流不允许读取。");
            }
            if (Cache)
            {
                int r = (int)Math.Min(m_fileData.Length - stratPos, length);
                Array.Copy(m_fileData, stratPos, buffer, offset, r);
                return r;
            }
            else
            {
                FileStream.Position = stratPos;
                return FileStream.Read(buffer, offset, length);
            }
        }
    }

    /// <summary>
    /// 减少引用次数，并尝试释放流。
    /// </summary>
    /// <param name="delayTime">延迟释放时间。当设置为0时，立即释放,单位毫秒。</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public Result TryReleaseFile(int delayTime = 0)
    {
        return FilePool.TryReleaseFile(Path, delayTime);
    }

    /// <summary>
    /// 从指定位置，写入数据到存储区。线程安全。
    /// </summary>
    /// <param name="stratPos"></param>
    /// <param name="buffer"></param>
    /// <param name="offset"></param>
    /// <param name="length"></param>
    public void Write(long stratPos, byte[] buffer, int offset, int length)
    {
        AccessTime = DateTime.Now;
        using (WriteLock writeLock = new WriteLock(m_lockSlim))
        {
            if (m_disposedValue)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }
            if (FileAccess == FileAccess.Read)
            {
                throw new Exception("该流不允许写入。");
            }
            FileStream.Position = stratPos;
            FileStream.Write(buffer, offset, length);
            FileStream.Flush();
        }
    }

    internal void Dispose()
    {
        if (m_disposedValue)
        {
            return;
        }
        using (WriteLock writeLock = new WriteLock(m_lockSlim))
        {
            m_disposedValue = true;
            FileStream.SafeDispose();
            m_fileData = null;
        }
    }
}