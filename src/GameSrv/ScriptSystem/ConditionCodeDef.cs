﻿namespace GameSrv
{
    /// <summary>
    /// 条件检测编码定义
    /// </summary>
    public class ConditionCodeDef
    {
        public const string sCHECK = "CHECK";
        public const int nCHECK = 1;
        public const string sRANDOM = "RANDOM";
        public const int nRANDOM = 2;
        public const string sGENDER = "GENDER";
        public const int nGENDER = 3;
        public const string sDAYTIME = "DAYTIME";
        public const int nDAYTIME = 4;
        public const string sCHECKOPEN = "CHECKOPEN";
        public const int nCHECKOPEN = 5;
        public const string sCHECKUNIT = "CHECKUNIT";
        public const int nCHECKUNIT = 6;
        public const string sCHECKLEVEL = "CHECKLEVEL";
        public const int nCHECKLEVEL = 7;
        public const string sCHECKJOB = "CHECKJOB";
        public const int nCHECKJOB = 8;
        public const string sCHECKBBCOUNT = "CHECKBBCOUNT";
        public const int nCHECKBBCOUNT = 9;
        public const string sCHECKITEM = "CHECKITEM";
        public const int nCHECKITEM = 20;
        public const string sCHECKITEMW = "CHECKITEMW";
        public const int nCHECKITEMW = 21;
        public const string sCHECKGOLD = "CHECKGOLD";
        public const int nCHECKGOLD = 22;
        public const string sISTAKEITEM = "ISTAKEITEM";
        public const int nISTAKEITEM = 23;
        public const string sCHECKDURA = "CHECKDURA";
        public const int nCHECKDURA = 24;
        public const string sCHECKDURAEVA = "CHECKDURAEVA";
        public const int nCHECKDURAEVA = 25;
        public const string sDAYOFWEEK = "DAYOFWEEK";
        public const int nDAYOFWEEK = 26;
        public const string sHOUR = "HOUR";
        public const int nHOUR = 27;
        public const string sMIN = "MIN";
        public const int nMIN = 28;
        public const string sCHECKPKPOINT = "CHECKPKPOINT";
        public const int nCHECKPKPOINT = 29;
        public const string sCHECKLUCKYPOINT = "CHECKLUCKYPOINT";
        public const int nCHECKLUCKYPOINT = 30;
        public const string sCHECKMONMAP = "CHECKMONMAP";
        public const int nCHECKMONMAP = 31;
        public const string sCHECKMONAREA = "CHECKMONAREA";
        public const int nCHECKMONAREA = 32;
        public const string sCHECKHUM = "CHECKHUM";
        public const int nCHECKHUM = 33;
        public const string sCHECKBAGGAGE = "CHECKBAGGAGE";
        public const int nCHECKBAGGAGE = 34;
        public const string sEQUAL = "EQUAL";
        public const int nEQUAL = 35;
        public const string sLARGE = "LARGE";
        public const int nLARGE = 36;
        public const string sSMALL = "SMALL";
        public const int nSMALL = 37;
        public const string sSC_CHECKMAGIC = "CHECKMAGIC";
        public const int nSC_CHECKMAGIC = 38;
        public const string sSC_CHKMAGICLEVEL = "CHKMAGICLEVEL";
        public const int nSC_CHKMAGICLEVEL = 39;
        public const string sSC_CHECKMONRECALL = "CHECKMONRECALL";
        public const int nSC_CHECKMONRECALL = 40;
        public const string sSC_CHECKHORSE = "CHECKHORSE";
        public const int nSC_CHECKHORSE = 41;
        public const string sSC_CHECKRIDING = "CHECKRIDING";
        public const int nSC_CHECKRIDING = 42;
        public const string sSC_STARTDAILYQUEST = "STARTDAILYQUEST";
        public const int nSC_STARTDAILYQUEST = 45;
        public const string sSC_CHECKDAILYQUEST = "CHECKDAILYQUEST";
        public const int nSC_CHECKDAILYQUEST = 46;
        public const string sSC_RANDOMEX = "RANDOMEX";
        public const int nSC_RANDOMEX = 47;
        public const string sCHECKNAMELIST = "CHECKNAMELIST";
        public const int nCHECKNAMELIST = 48;
        public const string sSC_CHECKWEAPONLEVEL = "CHECKWEAPONLEVEL";
        public const int nSC_CHECKWEAPONLEVEL = 49;
        public const string sSC_CHECKWEAPONATOM = "CHECKWEAPONATOM";
        public const int nSC_CHECKWEAPONATOM = 50;
        public const string sSC_CHECKREFINEWEAPON = "CHECKREFINEWEAPON";
        public const int nSC_CHECKREFINEWEAPON = 51;
        public const string sSC_CHECKWEAPONMCTYPE = "CHECKWEAPONMCTYPE";
        public const int nSC_CHECKWEAPONMCTYPE = 52;
        public const string sSC_CHECKREFINEITEM = "CHECKREFINEITEM";
        public const int nSC_CHECKREFINEITEM = 53;
        public const string sSC_HASWEAPONATOM = "HASWEAPONATOM";
        public const int nSC_HASWEAPONATOM = 54;
        public const string sSC_ISGUILDMASTER = "ISGUILDMASTER";
        public const int nSC_ISGUILDMASTER = 55;
        public const string sSC_CANPROPOSECASTLEWAR = "CANPROPOSECASTLEWAR";
        public const int nSC_CANPROPOSECASTLEWAR = 56;
        public const string sSC_CANHAVESHOOTER = "CANHAVESHOOTER";
        public const int nSC_CANHAVESHOOTER = 57;
        public const string sSC_CHECKFAME = "CHECKFAME";
        public const int nSC_CHECKFAME = 58;
        public const string sSC_ISONCASTLEWAR = "ISONCASTLEWAR";
        public const int nSC_ISONCASTLEWAR = 59;
        public const string sSC_ISONREADYCASTLEWAR = "ISONREADYCASTLEWAR";
        public const int nSC_ISONREADYCASTLEWAR = 60;
        public const string sSC_ISCASTLEGUILD = "ISCASTLEGUILD";
        public const int nSC_ISCASTLEGUILD = 61;
        public const string sSC_ISATTACKGUILD = "ISATTACKGUILD";

        // 是否为攻城方
        public const int nSC_ISATTACKGUILD = 63;

        public const string sSC_ISDEFENSEGUILD = "ISDEFENSEGUILD";

        // 是否为守城方
        public const int nSC_ISDEFENSEGUILD = 65;

        public const string sSC_CHECKSHOOTER = "CHECKSHOOTER";
        public const int nSC_CHECKSHOOTER = 66;
        public const string sSC_CHECKSAVEDSHOOTER = "CHECKSAVEDSHOOTER";
        public const int nSC_CHECKSAVEDSHOOTER = 67;
        public const string sSC_HASGUILD = "HAVEGUILD";

        // 是否加入行会
        public const int nSC_HASGUILD = 68;

        public const string sSC_CHECKCASTLEDOOR = "CHECKCASTLEDOOR";

        // 检查城门
        public const int nSC_CHECKCASTLEDOOR = 69;

        public const string sSC_CHECKCASTLEDOOROPEN = "CHECKCASTLEDOOROPEN";

        // 城门是否打开
        public const int nSC_CHECKCASTLEDOOROPEN = 70;

        public const string sSC_CHECKPOS = "CHECKPOS";
        public const int nSC_CHECKPOS = 71;
        public const string sSC_CANCHARGESHOOTER = "CANCHARGESHOOTER";
        public const int nSC_CANCHARGESHOOTER = 72;
        public const string sSC_ISATTACKALLYGUILD = "ISATTACKALLYGUILD";

        // 是否为攻城方联盟行会
        public const int nSC_ISATTACKALLYGUILD = 73;
        public const string sSC_ISDEFENSEALLYGUILD = "ISDEFENSEALLYGUILD";

        // 是否为守城方联盟行会
        public const int nSC_ISDEFENSEALLYGUILD = 74;

        public const string sSC_TESTTEAM = "TESTTEAM";
        public const int nSC_TESTTEAM = 75;
        public const string sSC_ISSYSOP = "ISSYSOP";
        public const int nSC_ISSYSOP = 76;
        public const string sSC_ISADMIN = "ISADMIN";
        public const int nSC_ISADMIN = 77;
        public const string sSC_CHECKBONUS = "CHECKBONUS";
        public const int nSC_CHECKBONUS = 78;
        public const string sSC_CHECKMARRIAGE = "CHECKMARRIAGE";
        public const int nSC_CHECKMARRIAGE = 79;
        public const string sSC_CHECKMARRIAGERING = "CHECKMARRIAGERING";
        public const int nSC_CHECKMARRIAGERING = 80;
        public const string sSC_CHECKGMETERM = "CHECKGMETERM";
        public const int nSC_CHECKGMETERM = 100;
        public const string sSC_CHECKOPENGME = "CHECKOPENGME";
        public const int nSC_CHECKOPENGME = 101;
        public const string sSC_CHECKENTERGMEMAP = "CHECKENTERGMEMAP";
        public const int nSC_CHECKENTERGMEMAP = 102;
        public const string sSC_CHECKSERVER = "CHECKSERVER";
        public const int nSC_CHECKSERVER = 103;
        public const string sSC_ELARGE = "ELARGE";
        public const int nSC_ELARGE = 104;
        public const string sSC_ESMALL = "ESMALL";
        public const int nSC_ESMALL = 105;
        public const string sSC_CHECKGROUPCOUNT = "CHECKGROUPCOUNT";
        public const int nSC_CHECKGROUPCOUNT = 106;
        public const string sSC_CHECKACCESSORY = "CHECKACCESSORY";
        public const int nSC_CHECKACCESSORY = 107;
        public const string sSC_ONERROR = "ONERROR";
        public const int nSC_ONERROR = 108;
        public const string sSC_CHECKARMOR = "CHECKARMOR";
        public const int nSC_CHECKARMOR = 109;
        public const string sCHECKACCOUNTLIST = "CHECKACCOUNTLIST";
        public const int nCHECKACCOUNTLIST = 135;
        public const string sCHECKIPLIST = "CHECKIPLIST";
        public const int nCHECKIPLIST = 136;
        public const string sCHECKCREDITPOINT = "CHECKCREDITPOINT";
        public const int nCHECKCREDITPOINT = 137;
        public const string sSC_CHECKPOSEDIR = "CHECKPOSEDIR";
        public const int nSC_CHECKPOSEDIR = 138;
        public const string sSC_CHECKPOSELEVEL = "CHECKPOSELEVEL";
        public const int nSC_CHECKPOSELEVEL = 139;
        public const string sSC_CHECKPOSEGENDER = "CHECKPOSEGENDER";
        public const int nSC_CHECKPOSEGENDER = 140;
        public const string sSC_CHECKLEVELEX = "CHECKLEVELEX";
        public const int nSC_CHECKLEVELEX = 141;
        public const string sSC_CHECKBONUSPOINT = "CHECKBONUSPOINT";
        public const int nSC_CHECKBONUSPOINT = 142;
        public const string sSC_CHECKMARRY = "CHECKMARRY";
        public const int nSC_CHECKMARRY = 143;
        public const string sSC_CHECKPOSEMARRY = "CHECKPOSEMARRY";
        public const int nSC_CHECKPOSEMARRY = 144;
        public const string sSC_CHECKMARRYCOUNT = "CHECKMARRYCOUNT";
        public const int nSC_CHECKMARRYCOUNT = 145;
        public const string sSC_CHECKMASTER = "CHECKMASTER";
        public const int nSC_CHECKMASTER = 146;
        public const string sSC_HAVEMASTER = "HAVEMASTER";
        public const int nSC_HAVEMASTER = 147;
        public const string sSC_CHECKPOSEMASTER = "CHECKPOSEMASTER";
        public const int nSC_CHECKPOSEMASTER = 148;
        public const string sSC_POSEHAVEMASTER = "POSEHAVEMASTER";
        public const int nSC_POSEHAVEMASTER = 149;
        public const string sSC_CHECKISMASTER = "CHECKPOSEISMASTER";
        public const int nSC_CHECKISMASTER = 150;
        public const string sSC_CHECKPOSEISMASTER = "CHECKISMASTER";
        public const int nSC_CHECKPOSEISMASTER = 151;
        public const string sSC_CHECKNAMEIPLIST = "CHECKNAMEIPLIST";
        public const int nSC_CHECKNAMEIPLIST = 152;
        public const string sSC_CHECKACCOUNTIPLIST = "CHECKACCOUNTIPLIST";
        public const int nSC_CHECKACCOUNTIPLIST = 153;
        public const string sSC_CHECKSLAVECOUNT = "CHECKSLAVECOUNT";
        public const int nSC_CHECKSLAVECOUNT = 154;
        public const string sSC_CHECKCASTLEMASTER = "ISCASTLEMASTER";
        public const int nSC_CHECKCASTLEMASTER = 155;
        public const string sSC_ISNEWHUMAN = "ISNEWHUMAN";
        public const int nSC_ISNEWHUMAN = 156;
        public const string sSC_CHECKMEMBERTYPE = "CHECKMEMBERTYPE";
        public const int nSC_CHECKMEMBERTYPE = 157;
        public const string sSC_CHECKMEMBERLEVEL = "CHECKMEMBERLEVEL";
        public const int nSC_CHECKMEMBERLEVEL = 158;
        public const string sSC_CHECKGAMEGOLD = "CHECKGAMEGOLD";
        public const int nSC_CHECKGAMEGOLD = 159;
        public const string sSC_CHECKGAMEPOINT = "CHECKGAMEPOINT";
        public const int nSC_CHECKGAMEPOINT = 160;
        public const string sSC_CHECKNAMELISTPOSITION = "CHECKNAMELISTPOSITION";
        public const int nSC_CHECKNAMELISTPOSITION = 161;
        public const string sSC_CHECKGUILDLIST = "CHECKGUILDLIST";
        public const int nSC_CHECKGUILDLIST = 162;
        public const string sSC_CHECKRENEWLEVEL = "CHECKRENEWLEVEL";
        public const int nSC_CHECKRENEWLEVEL = 163;
        public const string sSC_CHECKSLAVELEVEL = "CHECKSLAVELEVEL";
        public const int nSC_CHECKSLAVELEVEL = 164;
        public const string sSC_CHECKSLAVENAME = "CHECKSLAVENAME";
        public const int nSC_CHECKSLAVENAME = 165;
        public const string sSC_CHECKCREDITPOINT = "CHECKCREDITPOINT";
        public const int nSC_CHECKCREDITPOINT = 166;
        public const string sSC_CHECKOFGUILD = "CHECKOFGUILD";
        public const int nSC_CHECKOFGUILD = 167;
        public const string sSC_CHECKPAYMENT = "CHECKPAYMENT";
        public const int nSC_CHECKPAYMENT = 168;
        public const string sSC_CHECKUSEITEM = "CHECKUSEITEM";
        public const int nSC_CHECKUSEITEM = 169;
        public const string sSC_CHECKBAGSIZE = "CHECKBAGSIZE";
        public const int nSC_CHECKBAGSIZE = 170;
        public const string sSC_CHECKLISTCOUNT = "CHECKLISTCOUNT";
        public const int nSC_CHECKLISTCOUNT = 171;
        public const string sSC_CHECKDC = "CHECKDC";
        public const int nSC_CHECKDC = 172;
        public const string sSC_CHECKMC = "CHECKMC";
        public const int nSC_CHECKMC = 173;
        public const string sSC_CHECKSC = "CHECKSC";
        public const int nSC_CHECKSC = 174;
        public const string sSC_CHECKHP = "CHECKHP";
        public const int nSC_CHECKHP = 175;
        public const string sSC_CHECKMP = "CHECKMP";
        public const int nSC_CHECKMP = 176;
        public const string sSC_CHECKITEMTYPE = "CHECKITEMTYPE";
        public const int nSC_CHECKITEMTYPE = 180;
        public const string sSC_CHECKEXP = "CHECKEXP";
        public const int nSC_CHECKEXP = 181;
        public const string sSC_CHECKCASTLEGOLD = "CHECKCASTLEGOLD";
        public const int nSC_CHECKCASTLEGOLD = 182;
        public const string sSC_PASSWORDERRORCOUNT = "PASSWORDERRORCOUNT";
        public const int nSC_PASSWORDERRORCOUNT = 183;
        public const string sSC_ISLOCKPASSWORD = "ISLOCKPASSWORD";
        public const int nSC_ISLOCKPASSWORD = 184;
        public const string sSC_ISLOCKSTORAGE = "ISLOCKSTORAGE";
        public const int nSC_ISLOCKSTORAGE = 185;
        public const string sSC_CHECKBUILDPOINT = "CHECKGUILDBUILDPOINT";
        public const int nSC_CHECKBUILDPOINT = 186;
        public const string sSC_CHECKAURAEPOINT = "CHECKGUILDAURAEPOINT";
        public const int nSC_CHECKAURAEPOINT = 187;
        public const string sSC_CHECKSTABILITYPOINT = "CHECKGUILDSTABILITYPOINT";
        public const int nSC_CHECKSTABILITYPOINT = 188;
        public const string sSC_CHECKFLOURISHPOINT = "CHECKGUILDFLOURISHPOINT";
        public const int nSC_CHECKFLOURISHPOINT = 189;
        public const string sSC_CHECKCONTRIBUTION = "CHECKCONTRIBUTION";

        // 贡献度
        public const int nSC_CHECKCONTRIBUTION = 190;

        public const string sSC_CHECKRANGEMONCOUNT = "CHECKRANGEMONCOUNT";

        // 检查一个区域中有多少怪
        public const int nSC_CHECKRANGEMONCOUNT = 191;

        public const string sSC_CHECKITEMADDVALUE = "CHECKITEMADDVALUE";
        public const int nSC_CHECKITEMADDVALUE = 192;
        public const string sSC_CHECKINMAPRANGE = "CHECKINMAPRANGE";
        public const int nSC_CHECKINMAPRANGE = 193;
        public const string sSC_CASTLECHANGEDAY = "CASTLECHANGEDAY";
        public const int nSC_CASTLECHANGEDAY = 194;
        public const string sSC_CASTLEWARDAY = "CASTLEWARAY";
        public const int nSC_CASTLEWARDAY = 195;
        public const string sSC_ONLINELONGMIN = "ONLINELONGMIN";
        public const int nSC_ONLINELONGMIN = 196;
        public const string sSC_CHECKGUILDCHIEFITEMCOUNT = "CHECKGUILDCHIEFITEMCOUNT";
        public const int nSC_CHECKGUILDCHIEFITEMCOUNT = 197;
        public const string sSC_CHECKNAMEDATELIST = "CHECKNAMEDATELIST";
        public const int nSC_CHECKNAMEDATELIST = 198;
        public const string sSC_CHECKMAPHUMANCOUNT = "CHECKMAPHUMANCOUNT";
        public const int nSC_CHECKMAPHUMANCOUNT = 199;
        public const string sSC_CHECKMAPMONCOUNT = "CHECKMAPMONCOUNT";
        public const int nSC_CHECKMAPMONCOUNT = 200;
        public const string sSC_CHECKVAR = "CHECKVAR";
        public const int nSC_CHECKVAR = 201;
        public const string sSC_CHECKSERVERNAME = "CHECKSERVERNAME";
        public const int nSC_CHECKSERVERNAME = 202;
        public const string sCHECKMAPNAME = "CHECKMAPNAME";
        public const int nCHECKMAPNAME = 203;
        public const string sINSAFEZONE = "INSAFEZONE";

        public const int nINSAFEZONE = 204;
        public const string sCHECKSKILL = "CHECKSKILL";
        public const int nCHECKSKILL = 205;
        public const int nSC_CHECKUSERDATE = 206;
        public const string sSC_CHECKUSERDATE = "CHECKUSERDATE";
        public const string sSC_CHECKCONTAINSTEXT = "CHECKCONTAINSTEXT";
        public const int nSC_CHECKCONTAINSTEXT = 207;
        public const string sSC_COMPARETEXT = "COMPARETEXT";
        public const int nSC_COMPARETEXT = 208;
        public const string sSC_CHECKTEXTLIST = "CHECKTEXTLIST";
        public const int nSC_CHECKTEXTLIST = 209;
        public const string sSC_ISGROUPMASTER = "ISGROUPMASTER";
        public const int nSC_ISGROUPMASTER = 210;
        public const string sSC_CHECKCONTAINSTEXTLIST = "CHECKCONTAINSTEXTLIST";
        public const int nSC_CHECKCONTAINSTEXTLIST = 211;
        public const string sSC_CHECKONLINE = "CHECKONLINE";
        public const int nSC_CHECKONLINE = 212;
        public const string sSC_CHECKTEXTLENGTH = "CHECKTEXTLENGTH";
        public const int nSC_CHECKTEXTLENGTH = 213;
        public const string sSC_ISDUPMODE = "ISDUPMODE";
        public const int nSC_ISDUPMODE = 214;
        public const string sSC_ISOFFLINEMODE = "ISOFFLINEMODE";
        public const int nSC_ISOFFLINEMODE = 215;
        public const string sSC_CHECKSTATIONTIME = "CHECKSTATIONTIME";
        public const int nSC_CHECKSTATIONTIME = 216;
        public const string sSC_CHECKSIGNMAP = "CHECKSIGNMAP";
        public const int nSC_CHECKSIGNMAP = 217;
        public const string sSC_HAVEHERO = "HAVEHERO";
        public const int nSC_HAVEHERO = 218;
        public const string sSC_CHECKGUILDMEMBERMAXLIMIT = "CHECKGUILDMEMBERMAXLIMIT";
        public const int nSC_CHECKGUILDMEMBERMAXLIMIT = 222;
        public const string sSC_CHECKGUILDNAMEDATELIST = "CHECKGUILDNAMEDATELIST";
        public const int nSC_CHECKGUILDNAMEDATELIST = 223;
        public const string sSC_CHECKRANGEROUPCOUNT = "CHECKRANGEROUPCOUNT";
        public const int nSC_CHECKRANGEROUPCOUNT = 224;
        public const int nSC_CHECKONLINEPLAYCOUNT = 225;
        public const string sSC_CHECKONLINEPLAYCOUNT = "CHECKONLINEPLAYCOUNT";
        public const int nSC_CHECKITEMLIMIT = 226;
        public const string sSC_CHECKITEMLIMIT = "CHECKITEMLIMIT";
        public const int nSC_CHECKITEMLIMITCOUNT = 227;
        public const string sSC_CHECKITEMLIMITCOUNT = "CHECKITEMLIMITCOUNT";

        public const int nSC_CHECKMEMORYITEM = 228;
        public const string sSC_CHECKMEMORYITEM = "CHECKMEMORYITEM";
        public const int nSC_CHECKUPGRADEITEMS = 229;
        public const string sSC_CHECKUPGRADEITEMS = "CHECKUPGRADEITEMS";
        public const int nSC_CHECKIPUTTEM = 230;
        public const string sSC_CHECKIPUTTEM = "CHECKIPUTTEM";
        public const int nSC_CHECKDEATH = 231;
        public const string sSC_CHECKDEATH = "CHECKDEATH";
        public const int nSC_ISUNDERWAR = 232;
        public const string sSC_ISUNDERWAR = "ISUNDERWAR";
        public const int nSC_CHECKPKPOINTEX = 233;
        public const string sSC_CHECKPKPOINTEX = "CHECKPKPOINTEX";
        public const int nSC_CHECKUSEITEMBIND = 234;
        public const string sSC_CHECKUSEITEMBIND = "CHECKUSEITEMBIND";
        public const int nSC_CHECKITEMBIND = 235;
        public const string sSC_CHECKITEMBIND = "CHECKITEMBIND";
        public const int nSC_CHECKITEMNEWADDVALUE = 236;
        public const string sSC_CHECKITEMNEWADDVALUE = "CHECKITEMNEWADDVALUE";
        public const int nSC_ISSPACELOCK = 237;
        public const string sSC_ISSPACELOCK = "ISSPACELOCK";
        public const int nSC_CHECKRANGEMAPMAGICEVENTCOUNT = 238;
        public const string sSC_CHECKRANGEMAPMAGICEVENTCOUNT = "CHECKRANGEMAPMAGICEVENTCOUNT";
        public const string sSC_CHECKITEMNEWADDVALUECOUNT = "CHECKITEMNEWADDVALUECOUNT";
        public const int nSC_CHECKITEMNEWADDVALUECOUNT = 239;
        public const string sSC_GETDUELMAP = "GETDUELMAP";
        public const int nSC_GETDUELMAP = 240;
        public const string sSC_CHECKMAPDUELING = "CHECKMAPDUELING";
        public const int nSC_CHECKMAPDUELING = 241;
        public const string sSC_CHECKHUMDUELING = "CHECKHUMDUELING";
        public const int nSC_CHECKHUMDUELING = 242;
        public const string sSC_CHECKCANUSEITEM = "CHECKCANUSEITEM";

        public const int nSC_CHECKCANUSEITEM = 243;
        public const string sSC_CHECKINCURRRECT = "CHECKINCURRRECT";
        public const int nSC_CHECKINCURRRECT = 244;
        public const string sSC_CHECKGUILDMEMBER = "CHECKGUILDMEMBER";
        public const int nSC_CHECKGUILDMEMBER = 245;
        public const string sSC_INDEXOF = "INDEXOF";
        public const int nSC_INDEXOF = 246;
        public const string sSC_CHECKMASKED = "CHECKMASKED";
        public const int nSC_CHECKMASKED = 247;
        public const string sSC_CHECKUSEITEMSTARSLEVEL = "CHECKUSEITEMSTARSLEVEL";
        public const int nSC_CHECKUSEITEMSTARSLEVEL = 248;
        public const string sSC_CHECKBAGITEMSTARSLEVEL = "CHECKBAGITEMSTARSLEVEL";
        public const int nSC_CHECKBAGITEMSTARSLEVEL = 249;
        public const string sSC_CHECKHEROGROUP = "CHECKHEROGROUP";
        public const int nSC_CHECKHEROGROUP = 250;
        public const string sSC_CHECKPUTITEMTYPE = "CHECKPUTITEMTYPE";
        public const int nSC_CHECKPUTITEMTYPE = 251;
        public const string sSC_CHECKSLAVERANGE = "CHECKSLAVERANGE";
        public const int nSC_CHECKSLAVERANGE = 252;
        public const string sSC_ISAI = "ISAI";
        public const int nSC_ISAI = 253;
        public const string sSC_CHECKBAGITEMINLIST = "CHECKBAGITEMINLIST";
        public const int nSC_CHECKBAGITEMINLIST = 254;
        public const int nSC_INCASTLEWARAREA = 255;
        public const string sSC_INCASTLEWARAREA = "INCASTLEWARAREA";
        public const string sSC_ISONMAP = "ISONMAP";// 检测地图命令
        public const int nSC_ISONMAP = 478;

        public const string sSC_CHECKISONMAP = "ISONMAP";
        // 检测当前人是否在MAP地图上
        public const int nSC_CHECKISONMAP = 256;

        public const string sSC_REVIVESLAVE = "REVIVESLAVES";
        public const int nSC_REVIVESLAVE = 257;
        public const string sSC_CHECKMAGICLVL = "CHECKMAGICLVL";
        public const int nSC_CHECKMAGICLVL = 258;
        public const string sSC_CHECKGROUPCLASS = "CHECKGROUPCLASS";
        public const int nSC_CHECKGROUPCLASS = 259;
        public const string sSC_ISHIGH = "ISHIGH";
        public const int nSC_ISHIGH = 260;
        // ==================================================================
        public const string sCheckDiemon = "CHECKDIEMON";
        // 检查人物死亡被指定怪物杀死
        public const int nCheckDiemon = 209;
        public const string scheckkillplaymon = "CHECKKILLPLAYMON";
        // 检查杀死怪物
        public const int ncheckkillplaymon = 210;
        public const string sSC_CHECKRANDOMNO = "CHECKRANDOMNO";
        // 检测输入的验证码是否正确
        public const int nSC_CHECKRANDOMNO = 212;
        public const string sSC_KILLBYHUM = "KILLBYHUM";
        // 是否被人杀
        public const int nSC_KILLBYHUM = 214;
        public const string sSC_KILLBYMON = "KILLBYMON";
        // 是否被怪杀
        public const int nSC_KILLBYMON = 215;
        /// <summary>
        /// 检测人物是否在安全区
        /// </summary>
        public const string sSC_CHECKINSAFEZONE = "INSAFEZONE";
        public const int nSC_CHECKINSAFEZONE = 216;
        /// <summary>
        /// 检查放入装备指定的属性点
        /// </summary>
        public const string sSC_CHECKDLGITEMADDVALUE = "CHECKDLGITEMADDVALUE";
        public const int nSC_CHECKDLGITEMADDVALUE = 218;
        /// <summary>
        /// 检查放入装备的类型
        /// </summary>
        public const string sSC_CHECKDLGITEMTYPE = "CHECKDLGITEMTYPE";
        public const int nSC_CHECKDLGITEMTYPE = 219;
        /// <summary>
        /// 检查放入装备名称特征字符
        /// </summary>
        public const string sSC_CHECKDLGITEMNAME = "CHECKDLGITEMNAME";
        public const int nSC_CHECKDLGITEMNAME = 220;

        /// <summary>
        /// 检查已杀死怪物
        /// </summary>
        public const string sSCHECKDEATHPLAYMON = "CHECKDEATHPLAYMON";
        /// <summary>
        /// 检查已杀死怪物
        /// </summary>
        public const string sSCHECKKILLMOBNAME = "CHECKKILLMONNAME";
        public const int nSCHECKDEATHPLAYMON = 257;
        public const string sSC_CHECKMAP = "CHECKMAP";
        public const int nSC_CHECKMAP = 258;
    }
}