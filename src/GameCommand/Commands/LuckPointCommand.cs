﻿using M2Server.Player;
using SystemModule;
using SystemModule.Enums;

namespace M2Server.GameCommand.Commands {
    /// <summary>
    /// 调整指定玩家幸运点
    /// </summary>
    [Command("LuckPoint", "查看指定玩家幸运点", CommandHelp.GameCommandLuckPointHelpMsg, 10)]
    public class LuckPointCommand : GameCommand {
        [ExecuteCommand]
        public void Execute(string[] @params, PlayObject playObject) {
            if (@params == null) {
                return;
            }
            var sHumanName = @params.Length > 0 ? @params[0] : "";
            var sCtr = @params.Length > 1 ? @params[1] : "";
            var sPoint = @params.Length > 2 ? @params[2] : "";
            if (string.IsNullOrEmpty(sHumanName) || !string.IsNullOrEmpty(sHumanName) && sHumanName[0] == '?') {
                playObject.SysMsg(Command.CommandHelp, MsgColor.Red, MsgType.Hint);
                return;
            }
            var mPlayObject = M2Share.WorldEngine.GetPlayObject(sHumanName);
            if (mPlayObject == null) {
                playObject.SysMsg(string.Format(CommandHelp.NowNotOnLineOrOnOtherServer, sHumanName), MsgColor.Red, MsgType.Hint);
                return;
            }
            if (string.IsNullOrEmpty(sCtr)) {
                playObject.SysMsg(string.Format(CommandHelp.GameCommandLuckPointMsg, sHumanName, mPlayObject.BodyLuckLevel, mPlayObject.BodyLuck, mPlayObject.Luck), MsgColor.Green, MsgType.Hint);
                return;
            }
            var nPoint = (byte)HUtil32.StrToInt(sPoint, 0);
            var cMethod = sCtr[0];
            switch (cMethod) {
                case '=':
                    mPlayObject.Luck = nPoint;
                    break;
                case '-':
                    if (mPlayObject.Luck >= nPoint) {
                        mPlayObject.Luck -= nPoint;
                    }
                    else {
                        mPlayObject.Luck = 0;
                    }
                    break;
                case '+':
                    mPlayObject.Luck += nPoint;
                    break;
            }
        }
    }
}