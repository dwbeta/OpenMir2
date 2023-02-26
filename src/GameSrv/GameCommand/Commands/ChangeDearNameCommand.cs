﻿using GameSrv.Player;
using SystemModule.Enums;

namespace GameSrv.GameCommand.Commands {
    /// <summary>
    /// 调整指定玩家配偶名称
    /// </summary>
    [Command("ChangeDearName", "调整指定玩家配偶名称", help: "人物名称 配偶名称(如果为 无 则清除)", 10)]
    public class ChangeDearNameCommand : GameCommand {
        [ExecuteCommand]
        public void Execute(string[] @Params, PlayObject PlayObject) {
            if (@Params == null) {
                return;
            }
            string sHumanName = @Params.Length > 0 ? @Params[0] : "";
            string sDearName = @Params.Length > 1 ? @Params[1] : "";
            if (string.IsNullOrEmpty(sHumanName) || string.IsNullOrEmpty(sDearName)) {
                PlayObject.SysMsg(Command.CommandHelp, MsgColor.Red, MsgType.Hint);
                return;
            }
            PlayObject m_PlayObject = M2Share.WorldEngine.GetPlayObject(sHumanName);
            if (m_PlayObject != null) {
                if (string.Compare(sDearName, "无", StringComparison.OrdinalIgnoreCase) == 0) {
                    m_PlayObject.DearName = "";
                    m_PlayObject.RefShowName();
                    PlayObject.SysMsg(sHumanName + " 的配偶名清除成功。", MsgColor.Green, MsgType.Hint);
                }
                else {
                    m_PlayObject.DearName = sDearName;
                    m_PlayObject.RefShowName();
                    PlayObject.SysMsg(sHumanName + " 的配偶名更改成功。", MsgColor.Green, MsgType.Hint);
                }
            }
            else {
                PlayObject.SysMsg(string.Format(CommandHelp.NowNotOnLineOrOnOtherServer, sHumanName), MsgColor.Red, MsgType.Hint);
            }
        }
    }
}