﻿using M2Server.Actor;
using M2Server.Guild;
using M2Server.Player;
using SystemModule;
using SystemModule.Enums;

namespace M2Server.GameCommand.Commands {
    /// <summary>
    /// 开始行会争霸赛
    /// </summary>
    [Command("StartContest", "开始行会争霸赛", 10)]
    public class StartContestCommand : GameCommand {
        [ExecuteCommand]
        public void Execute(PlayObject playObject) {
            PlayObject mPlayObject;
            PlayObject playObjectA;
            bool bo19;
            if (!playObject.Envir.Flag.Fight3Zone) {
                playObject.SysMsg("此命令不能在当前地图中使用!!!", MsgColor.Red, MsgType.Hint);
                return;
            }
            playObject.SysMsg("开始行会争霸赛。", MsgColor.Red, MsgType.Hint);
            IList<BaseObject> list10 = new List<BaseObject>();
            IList<PlayObject> list14 = new List<PlayObject>();
            IList<GuildInfo> guildList = new List<GuildInfo>();
            M2Share.WorldEngine.GetMapRageHuman(playObject.Envir, playObject.CurrX, playObject.CurrY, 1000, ref list10);
            for (var i = 0; i < list10.Count; i++) {
                mPlayObject = list10[i] as PlayObject;
                if (!mPlayObject.ObMode || !mPlayObject.AdminMode) {
                    mPlayObject.FightZoneDieCount = 0;
                    if (mPlayObject.MyGuild == null) {
                        continue;
                    }
                    bo19 = false;
                    for (var j = 0; j < list14.Count; j++) {
                        playObjectA = list14[j];
                        if (mPlayObject.MyGuild == playObjectA.MyGuild) {
                            bo19 = true;
                        }
                    }
                    if (!bo19) {
                        guildList.Add(mPlayObject.MyGuild);
                    }
                }
            }
            playObject.SysMsg("行会争霸赛已经开始。", MsgColor.Green, MsgType.Hint);
            M2Share.WorldEngine.CryCry(Messages.RM_CRY, playObject.Envir, playObject.CurrX, playObject.CurrY, 1000, M2Share.Config.CryMsgFColor, M2Share.Config.CryMsgBColor, "- 行会战争已爆发。");
            var s20 = "";
            GuildInfo guild;
            for (var i = 0; i < guildList.Count; i++) {
                guild = guildList[i];
                guild.StartTeamFight();
                for (var ii = 0; ii < list10.Count; ii++) {
                    mPlayObject = list10[i] as PlayObject;
                    if (mPlayObject.MyGuild == guild) {
                        guild.AddTeamFightMember(mPlayObject.ChrName);
                    }
                }
                s20 = s20 + guild.GuildName + ' ';
            }
            M2Share.WorldEngine.CryCry(Messages.RM_CRY, playObject.Envir, playObject.CurrX, playObject.CurrY, 1000, M2Share.Config.CryMsgFColor, M2Share.Config.CryMsgBColor, " -参加的门派:" + s20);
        }
    }
}