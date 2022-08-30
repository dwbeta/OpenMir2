﻿namespace GameSvr.Command
{
    public class GameCommandConst
    {
        public const string g_sGameLogMsg1 = "{0}\09{1}\09{2}\09{3}\09{4}\09{5}\09{6}\09{7}\09{8}";
        public const string g_sHumanDieEvent = "人物死亡事件";
        public const string g_sHitOverSpeed = "[攻击超速] {0} 间隔:{1} 数量:{2}";
        public const string g_sRunOverSpeed = "[跑步超速] {0} 间隔:{1} 数量:{2}";
        public const string g_sWalkOverSpeed = "[行走超速] {0} 间隔:{1} 数量:{2}";
        public const string g_sSpellOverSpeed = "[魔法超速] {0} 间隔:{1} 数量:{2}";
        public const string g_sBunOverSpeed = "[游戏超速] {0} 间隔:{1} 数量:{2}";
        public const string g_sGameCommandPermissionTooLow = "权限不够!!!";
        public const string g_sGameCommandParamUnKnow = "命令格式: @{0} {1}";
        public const string g_sGameCommandMoveHelpMsg = "地图号";
        public const string g_sGameCommandPositionMoveHelpMsg = "地图号 座标X 座标Y";
        public const string g_sGameCommandPositionMoveCanotMoveToMap = "无法移动到地图: {0} X:{1} Y:{2}";
        public const string g_sGameCommandInfoHelpMsg = "人物名称";
        public const string g_sNowNotOnLineOrOnOtherServer = "{0} 现在不在线，或在其它服务器上!!!";
        public const string g_sGameCommandMobCountHelpMsg = "地图号";
        public const string g_sGameCommandMobCountMapNotFound = "指定的地图不存在!!!";
        public const string g_sGameCommandMobCountMonsterCount = "怪物数量：{0}";
        public const string g_sGameCommandHumanCountHelpMsg = "地图号";
        public const string g_sGameCommandKickHumanHelpMsg = "人物名称";
        public const string g_sGameCommandTingHelpMsg = "人物名称";
        public const string g_sGameCommandSuperTingHelpMsg = "人物名称 范围(0-10)";
        public const string g_sGameCommandMapMoveHelpMsg = "源地图  目标地图";
        public const string g_sGameCommandMapMoveMapNotFound = "地图{0}不存在!!!";
        public const string g_sGameCommandShutupHelpMsg = "人物名称  时间长度(分钟)";
        public const string g_sGameCommandShutupHumanMsg = "{0} 已被禁言{1}分钟";
        public const string g_sGameCommandGamePointHelpMsg = "人物名称 控制符(+,-,=) 游戏点数(1-100000000)";
        public const string g_sGameCommandGamePointHumanMsg = "你的游戏点已增加{0}点，当前总点数为{1}点。";
        public const string g_sGameCommandGamePointGMMsg = "{0}的游戏点已增加{1}点，当前总点数为{2}点。";
        public const string g_sGameCommandCreditPointHelpMsg = "人物名称 控制符(+,-,=) 声望点数(0-255)";
        public const string g_sGameCommandCreditPointHumanMsg = "你的声望点已增加{0}点，当前总声望点数为{1}点。";
        public const string g_sGameCommandCreditPointGMMsg = "{0}的声望点已增加{1}点，当前总声望点数为{2}点。";
        public const string g_sGameCommandGameGoldHelpMsg = " 人物名称 控制符(+,-,=) 游戏币(1-200000000)";
        public const string g_sGameCommandGameGoldHumanMsg = "你的{0}已增加{1}，当前拥有{2}{3}。";
        public const string g_sGameCommandGameGoldGMMsg = "{0}的{1}已增加{2}，当前拥有{3}{4}。";
        public const string g_sGameCommandMapInfoMsg = "地图名称: {0}({1})";
        public const string g_sGameCommandMapInfoSizeMsg = "地图大小: X({0}) Y({1})";
        public const string g_sGameCommandShutupReleaseHelpMsg = "人物名称";
        public const string g_sGameCommandShutupReleaseCanSendMsg = "你已经恢复聊天功能!!!";
        public const string g_sGameCommandShutupReleaseHumanCanSendMsg = "{0} 已经恢复聊天。";
        public const string g_sGameCommandShutupListIsNullMsg = "禁言列表为空!!!";
        public const string g_sGameCommandLevelConsoleMsg = "[等级调整] {0} ({1} -> {2})";
        public const string g_sGameCommandSbkGoldHelpMsg = "城堡名称 控制符(=、-、+) 金币数(1-100000000)";
        public const string g_sGameCommandSbkGoldCastleNotFoundMsg = "城堡{0}未找到!!!";
        public const string g_sGameCommandSbkGoldShowMsg = "{0}的金币数为: {1} 今天收入: {2}";
        public const string g_sGameCommandRecallHelpMsg = "人物名称";
        public const string g_sGameCommandReGotoHelpMsg = "人物名称";
        public const string g_sGameCommandShowHumanFlagHelpMsg = "人物名称 标识号";
        public const string g_sGameCommandShowHumanFlagONMsg = "{0}: [{1}] = ON";
        public const string g_sGameCommandShowHumanFlagOFFMsg = "{0}: [{1}] = OFF";
        public const string g_sGameCommandShowHumanUnitHelpMsg = "人物名称 单元号";
        public const string g_sGameCommandShowHumanUnitONMsg = "{0}: [{1}] = ON";
        public const string g_sGameCommandShowHumanUnitOFFMsg = "{0}: [{1}] = OFF";
        public const string g_sGameCommandMobHelpMsg = "怪物名称 数量 等级";
        public const string g_sGameCommandMobMsg = "怪物名称不正确或其它未问题!!!";
        public const string g_sGameCommandMobNpcHelpMsg = "NPC名称 脚本文件名 外形(数字) 属沙城(0,1)";
        public const string g_sGameCommandNpcScriptHelpMsg = "？？？？";
        public const string g_sGameCommandDelNpcMsg = "命令使用方法不正确，必须与NPC面对面，才能使用此命令!!!";
        public const string g_sGameCommandRecallMobHelpMsg = "怪物名称 数量 等级";
        public const string g_sGameCommandLuckPointHelpMsg = "人物名称 控制符 幸运点数";
        public const string g_sGameCommandLuckPointMsg = "{0} 的幸运点数为:{1}/{2} 幸运值为:{3}";
        public const string g_sGameCommandLotteryTicketMsg = "已中彩票数:{0} 未中彩票数:{1} 一等奖:{2} 二等奖:{3} 三等奖:{4} 四等奖:{5} 五等奖:{6} 六等奖:{7} ";
        public const string g_sGameCommandReloadGuildHelpMsg = "行会名称";
        public const string g_sGameCommandReloadGuildOnMasterserver = "此命令只能在主游戏服务器上执行!!!";
        public const string g_sGameCommandReloadGuildNotFoundGuildMsg = "未找到行会{0}!!!";
        public const string g_sGameCommandReloadGuildSuccessMsg = "行会{0}重加载成功...";
        public const string g_sGameCommandReloadLineNoticeSuccessMsg = "重新加载公告设置信息完成。";
        public const string g_sGameCommandReloadLineNoticeFailMsg = "重新加载公告设置信息失败!!!";
        public const string g_sGameCommandFreePKHelpMsg = "人物名称";
        public const string g_sGameCommandFreePKHumanMsg = "你的PK值已经被清除...";
        public const string g_sGameCommandFreePKMsg = "{0}的PK值已经被清除...";
        public const string g_sGameCommandPKPointHelpMsg = "人物名称";
        public const string g_sGameCommandPKPointMsg = "{0}的PK点数为:{1}";
        public const string g_sGameCommandIncPkPointHelpMsg = "人物名称 PK点数";
        public const string g_sGameCommandIncPkPointAddPointMsg = "{0}的PK值已增加%d点...";
        public const string g_sGameCommandIncPkPointDecPointMsg = "{0}的PK值已减少%d点...";
        public const string g_sGameCommandHumanLocalHelpMsg = "人物名称";
        public const string g_sGameCommandHumanLocalMsg = "{0}来自:{1}";
        public const string g_sGameCommandPrvMsgHelpMsg = "人物名称";
        public const string g_sGameCommandPrvMsgUnLimitMsg = "{0} 已从禁止私聊列表中删除...";
        public const string g_sGameCommandPrvMsgLimitMsg = "{0} 已被加入禁止私聊列表...";
        public const string g_sGamecommandMakeHelpMsg = " 物品名称  数量";
        public const string g_sGamecommandMakeItemNameOrPerMissionNot = "输入的物品名称不正确，或权限不够!!!";
        public const string g_sGamecommandMakeInCastleWarRange = "攻城区域，禁止使用此功能!!!";
        public const string g_sGamecommandMakeInSafeZoneRange = "非安全区，禁止使用此功能!!!";
        public const string g_sGamecommandMakeItemNameNotFound = "{0} 物品名称不正确!!!";
        public const string g_sGamecommandSuperMakeHelpMsg = "身上没指定物品!!!";
        public const string g_sGameCommandViewWhisperHelpMsg = " 人物名称";
        public const string g_sGameCommandViewWhisperMsg1 = "已停止侦听{0}的私聊信息...";
        public const string g_sGameCommandViewWhisperMsg2 = "正在侦听{0}的私聊信息...";
        public const string g_sGameCommandReAliveHelpMsg = " 人物名称";
        public const string g_sGameCommandReAliveMsg = "{0} 已获重生.";
        public const string g_sGameCommandChangeJobHelpMsg = " 人物名称 职业类型(Warr Wizard Taos)";
        public const string g_sGameCommandChangeJobMsg = "{0} 的职业更改成功。";
        public const string g_sGameCommandChangeJobHumanMsg = "职业更改成功。";
        public const string g_sGameCommandTestGetBagItemsHelpMsg = "(用于测试升级武器方面参数)";
        public const string g_sGameCommandShowUseItemInfoHelpMsg = "人物名称";
        public const string g_sGameCommandBindUseItemHelpMsg = "人物名称 物品类型 绑定方法";
        public const string g_sGameCommandBindUseItemNoItemMsg = "{0}的{1}没有戴物品!!!";
        public const string g_sGameCommandBindUseItemAlreadBindMsg = "{0}的{1}上的物品早已绑定过了!!!";
        public const string g_sGameCommandMobFireBurnHelpMsg = "命令格式: {0} {1} {2} {3} {4} {5} {6}";
        public const string g_sGameCommandMobFireBurnMapNotFountMsg = "地图{0} 不存在";
        public static string sGetSellOffGlod = "{0} {1}增加";
    }
}