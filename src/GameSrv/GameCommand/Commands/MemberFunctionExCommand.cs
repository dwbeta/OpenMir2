﻿using GameSrv.Player;

namespace GameSrv.GameCommand.Commands {
    [Command("MemberFunctionEx", "", help: "打开会员功能窗口", 0)]
    public class MemberFunctionExCommand : GameCommand {
        [ExecuteCommand]
        public void Execute(PlayObject PlayObject) {
            if (M2Share.FunctionNPC != null) {
                M2Share.FunctionNPC.GotoLable(PlayObject, "@Member", false);
            }
        }
    }
}