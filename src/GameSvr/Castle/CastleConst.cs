﻿using GameSvr.Actor;
using GameSvr.Guild;

namespace GameSvr.Castle
{
    public class CastleConst
    {
        /// <summary>
        /// 最大守卫次数
        /// </summary>
        public const int MaxCastleArcher = 12;
        /// <summary>
        /// 最大城堡守卫
        /// </summary>
        public const int MaxCalsteGuard = 4;
    }

    public class TAttackerInfo
    {
        public DateTime AttackDate;
        public string sGuildName;
        public GuildInfo Guild;
    }

    public struct TDefenseUnit
    {
        public int nMainDoorX;
        public int nMainDoorY;
        public string sMainDoorName;
        public bool boXXX;
        public ushort wMainDoorHP;
        public TBaseObject MainDoor;
        public TBaseObject LeftWall;
        public TBaseObject CenterWall;
        public TBaseObject RightWall;
        public TBaseObject Archer;
    }

    public class TObjUnit
    {
        public short nX;
        public short nY;
        public string sName;
        public bool nStatus;
        public ushort nHP;
        public TBaseObject BaseObject;
    }
}
