﻿using M2Server.Player;
using SystemModule;
using SystemModule.Enums;

namespace M2Server.GameCommand.Commands
{
    /// <summary>
    /// 调整指定物品名称
    /// </summary>
    [Command("ChangeItemName", "调整指定物品名称", 10, Help = "物品编号 物品ID号 物品名称")]
    public class ChangeItemNameCommand : GameCommand
    {
        [ExecuteCommand]
        public void Execute(string[] @params, PlayObject playObject)
        {
            if (@params == null)
            {
                return;
            }
            var sMakeIndex = @params.Length > 0 ? @params[0] : "";
            var sItemIndex = @params.Length > 1 ? @params[1] : "";
            var sItemName = @params.Length > 2 ? @params[2] : "";
            if (string.IsNullOrEmpty(sMakeIndex) || string.IsNullOrEmpty(sItemIndex) || string.IsNullOrEmpty(sItemName))
            {
                playObject.SysMsg(Command.CommandHelp, MsgColor.Red, MsgType.Hint);
                return;
            }
            var nMakeIndex = HUtil32.StrToInt(sMakeIndex, -1);
            var nItemIndex = HUtil32.StrToInt(sItemIndex, -1);
            if (nMakeIndex <= 0 || nItemIndex < 0)
            {
                playObject.SysMsg(Command.CommandHelp, MsgColor.Red, MsgType.Hint);
                return;
            }
            if (M2Share.CustomItemMgr.AddCustomItemName(nMakeIndex, nItemIndex, sItemName))
            {
                M2Share.CustomItemMgr.SaveCustomItemName();
                playObject.SysMsg("物品名称设置成功。", MsgColor.Green, MsgType.Hint);
                return;
            }
            playObject.SysMsg("此物品，已经设置了其它的名称!!!", MsgColor.Red, MsgType.Hint);
        }
    }
}