﻿using M2Server.Player;
using SystemModule.Enums;

namespace M2Server.GameCommand.Commands {
    /// <summary>
    /// 查看时间日期
    /// </summary>
    [Command("Date", "查看时间日期", "")]
    public class DataCommand : GameCommand {
        [ExecuteCommand]
        public void Execute(PlayObject playObject) {
            playObject.SysMsg(CommandHelp.NowCurrDateTime + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), MsgColor.Blue, MsgType.Hint);
        }
    }
}