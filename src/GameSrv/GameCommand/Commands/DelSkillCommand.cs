﻿using GameSrv.Player;
using SystemModule.Enums;
using SystemModule.Packets.ClientPackets;

namespace GameSrv.GameCommand.Commands {
    /// <summary>
    /// 删除指定玩家技能
    /// </summary>
    [Command("DelSkill", "删除指定玩家技能", "人物名称 技能名称", 10)]
    public class DelSkillCommand : GameCommand {
        [ExecuteCommand]
        public void Execute(string[] @Params, PlayObject PlayObject) {
            if (@Params == null) {
                return;
            }
            string sHumanName = @Params.Length > 0 ? @Params[0] : "";
            string sSkillName = @Params.Length > 1 ? @Params[1] : "";
            string Herostr = @Params.Length > 2 ? @Params[2] : "";
            bool boDelAll;
            UserMagic UserMagic;
            if (string.IsNullOrEmpty(sHumanName) || (string.IsNullOrEmpty(sSkillName))) {
                PlayObject.SysMsg(Command.CommandHelp, MsgColor.Red, MsgType.Hint);
                return;
            }
            if (string.Compare(sSkillName, "All", StringComparison.OrdinalIgnoreCase) == 0) {
                boDelAll = true;
            }
            else {
                boDelAll = false;
            }
            PlayObject m_PlayObject = M2Share.WorldEngine.GetPlayObject(sHumanName);
            if (m_PlayObject == null) {
                PlayObject.SysMsg(string.Format(CommandHelp.NowNotOnLineOrOnOtherServer, sHumanName), MsgColor.Red, MsgType.Hint);
                return;
            }
            for (int i = m_PlayObject.MagicList.Count - 1; i >= 0; i--) {
                if (m_PlayObject.MagicList.Count <= 0) {
                    break;
                }
                UserMagic = m_PlayObject.MagicList[i];
                if (UserMagic != null) {
                    if (boDelAll) {
                        m_PlayObject.MagicList.RemoveAt(i);
                    }
                    else {
                        if (string.Compare(UserMagic.Magic.Desc, sSkillName, StringComparison.OrdinalIgnoreCase) == 0) {
                            m_PlayObject.SendDelMagic(UserMagic);
                            m_PlayObject.MagicList.RemoveAt(i);
                            m_PlayObject.SysMsg($"技能{sSkillName}已删除。", MsgColor.Green, MsgType.Hint);
                            PlayObject.SysMsg($"{sHumanName}的技能{sSkillName}已删除。", MsgColor.Green, MsgType.Hint);
                            break;
                        }
                    }
                }
            }
            m_PlayObject.RecalcAbilitys();
        }
    }
}