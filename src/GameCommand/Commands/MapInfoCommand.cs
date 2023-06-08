﻿using M2Server.Player;
using SystemModule;
using SystemModule.Enums;

namespace M2Server.GameCommand.Commands
{
    [Command("MapInfo", "显示当前地图信息", 10)]
    public class MapInfoCommand : GameCommand
    {
        [ExecuteCommand]
        public void Execute(string[] @params, PlayObject playObject)
        {
            if (@params == null || @params.Length <= 0)
            {
                return;
            }
            var sMap = @params[2];
            var nX = HUtil32.StrToInt16(@params[0], 0);
            var nY = HUtil32.StrToInt16(@params[1], 0);
            if (!string.IsNullOrEmpty(sMap) && nX >= 0 && nY >= 0)
            {
                var map = M2Share.MapMgr.FindMap(sMap);
                if (map != null && map.IsValidCell(nX, nY))
                {
                    ref var cellInfo = ref map.GetCellInfo(nX, nY, out var cellSuccess);
                    if (cellSuccess)
                    {
                        playObject.SysMsg("标志: " + cellInfo.Attribute, MsgColor.Green, MsgType.Hint);
                        if (cellInfo.IsAvailable)
                        {
                            playObject.SysMsg("对象数: " + cellInfo.Count, MsgColor.Green, MsgType.Hint);
                        }
                    }
                    else
                    {
                        playObject.SysMsg("取地图单元信息失败: " + sMap, MsgColor.Red, MsgType.Hint);
                    }
                }
            }
            else
            {
                playObject.SysMsg("请按正确格式输入: " + this.Command.Name + " 地图号 X Y", MsgColor.Green, MsgType.Hint);
            }
        }
    }
}