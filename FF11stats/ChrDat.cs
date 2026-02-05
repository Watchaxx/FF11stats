namespace FF11stats
{
    internal class ChrDat
    {
        #region プロフィール
        public string Name { get; set; } = "Noname";
        public int Race { get; set; } = 0;
        public int Face { get; set; } = 0;
        public int Nation { get; set; } = 0;
        public decimal Rank { get; set; } = 1;
        public decimal Mastery { get; set; } = 0;
        public int Mentor { get; set; } = 0;
        public int Gladiators { get; set; } = 0;
        public int Mercenary { get; set; } = 0;
        public int Campaign { get; set; } = 0;
        public int CoalitionEvaluation { get; set; } = 0;
        public int Unity { get; set; } = 0;
        #endregion
        #region ジョブレベル
        public byte JoblvlWar { get; set; } = 1;
        public byte JoblvlMnk { get; set; } = 1;
        public byte JoblvlWhm { get; set; } = 1;
        public byte JoblvlBlm { get; set; } = 1;
        public byte JoblvlRdm { get; set; } = 1;
        public byte JoblvlThf { get; set; } = 1;
        public byte JoblvlPld { get; set; } = 0;
        public byte JoblvlDrk { get; set; } = 0;
        public byte JoblvlBst { get; set; } = 0;
        public byte JoblvlBrd { get; set; } = 0;
        public byte JoblvlRng { get; set; } = 0;
        public byte JoblvlSam { get; set; } = 0;
        public byte JoblvlNin { get; set; } = 0;
        public byte JoblvlDrg { get; set; } = 0;
        public byte JoblvlSmn { get; set; } = 0;
        public byte JoblvlBlu { get; set; } = 0;
        public byte JoblvlCor { get; set; } = 0;
        public byte JoblvlPup { get; set; } = 0;
        public byte JoblvlDnc { get; set; } = 0;
        public byte JoblvlSch { get; set; } = 0;
        public byte JoblvlGeo { get; set; } = 0;
        public byte JoblvlRun { get; set; } = 0;
        #endregion
        #region マスターレベル
        public byte MstlvlWar { get; set; } = 0;
        public byte MstlvlMnk { get; set; } = 0;
        public byte MstlvlWhm { get; set; } = 0;
        public byte MstlvlBlm { get; set; } = 0;
        public byte MstlvlRdm { get; set; } = 0;
        public byte MstlvlThf { get; set; } = 0;
        public byte MstlvlPld { get; set; } = 0;
        public byte MstlvlDrk { get; set; } = 0;
        public byte MstlvlBst { get; set; } = 0;
        public byte MstlvlBrd { get; set; } = 0;
        public byte MstlvlRng { get; set; } = 0;
        public byte MstlvlSam { get; set; } = 0;
        public byte MstlvlNin { get; set; } = 0;
        public byte MstlvlDrg { get; set; } = 0;
        public byte MstlvlSmn { get; set; } = 0;
        public byte MstlvlBlu { get; set; } = 0;
        public byte MstlvlCor { get; set; } = 0;
        public byte MstlvlPup { get; set; } = 0;
        public byte MstlvlDnc { get; set; } = 0;
        public byte MstlvlSch { get; set; } = 0;
        public byte MstlvlGeo { get; set; } = 0;
        public byte MstlvlRun { get; set; } = 0;
        #endregion
        #region 戦闘スキル
        public decimal SkillHand { get; set; } = 0;
        public decimal SkillDagger { get; set; } = 0;
        public decimal SkillKsword { get; set; } = 0;
        public decimal SkillRsword { get; set; } = 0;
        public decimal SkillKaxe { get; set; } = 0;
        public decimal SkillRaxe { get; set; } = 0;
        public decimal SkillRscythe { get; set; } = 0;
        public decimal SkillRpolearm { get; set; } = 0;
        public decimal SkillKkatana { get; set; } = 0;
        public decimal SkillRkatana { get; set; } = 0;
        public decimal SkillKclub { get; set; } = 0;
        public decimal SkillRclub { get; set; } = 0;
        public decimal SkillArchery { get; set; } = 0;
        public decimal SkillMarksman { get; set; } = 0;
        public decimal SkillThrow { get; set; } = 0;
        public decimal SkillGuard { get; set; } = 0;
        public decimal SkillEvasion { get; set; } = 0;
        public decimal SkillShield { get; set; } = 0;
        public decimal SkillParry { get; set; } = 0;
        #endregion
        #region 魔法スキル
        public decimal SkillDivine { get; set; } = 0;
        public decimal SkillHealing { get; set; } = 0;
        public decimal SkillEnhancing { get; set; } = 0;
        public decimal SkillEnfeebling { get; set; } = 0;
        public decimal SkillElemental { get; set; } = 0;
        public decimal SkillDark { get; set; } = 0;
        public decimal SkillSummoning { get; set; } = 0;
        public decimal SkillNinjutsu { get; set; } = 0;
        public decimal SkillSinging { get; set; } = 0;
        public decimal SkillStringInst { get; set; } = 0;
        public decimal SkillWindInst { get; set; } = 0;
        public decimal SkillBlue { get; set; } = 0;
        public decimal SkillGeomancy { get; set; } = 0;
        public decimal SkillHandbell { get; set; } = 0;
        #endregion
        #region 合成スキル
        public ulong RankSynth { get; set; } = 0;
        public decimal SkillFishing { get; set; } = 0;
        public decimal SkillWood { get; set; } = 0;
        public decimal SkillSmithing { get; set; } = 0;
        public decimal SkillGoldsmithing { get; set; } = 0;
        public decimal SkillClothcraft { get; set; } = 0;
        public decimal SkillLeathercraft { get; set; } = 0;
        public decimal SkillBonecraft { get; set; } = 0;
        public decimal SkillAlchemy { get; set; } = 0;
        public decimal SkillCooking { get; set; } = 0;
        public decimal SkillSynergy { get; set; } = 0;
        #endregion
        #region メリポ
        public uint MeritHpmp { get; set; } = 0;
        public uint MeritStatus { get; set; } = 0;
        public ulong MeritCombatSkills1 { get; set; } = 0;
        public uint MeritCombatSkills2 { get; set; } = 0;
        public ulong MeritMagicSkills { get; set; } = 0;
        public uint MeritOthers { get; set; } = 0;
        public ulong MeritWS { get; set; } = 0;
        //メリポ
        public uint MeritWar1 { get; set; } = 0;
        public uint MeritWar2 { get; set; } = 0;
        public uint MeritMnk1 { get; set; } = 0;
        public uint MeritMnk2 { get; set; } = 0;
        public uint MeritWhm1 { get; set; } = 0;
        public uint MeritWhm2 { get; set; } = 0;
        public uint MeritBlm1 { get; set; } = 0;
        public uint MeritBlm2 { get; set; } = 0;
        public uint MeritRdm1 { get; set; } = 0;
        public uint MeritRdm2 { get; set; } = 0;
        public uint MeritThf1 { get; set; } = 0;
        public uint MeritThf2 { get; set; } = 0;
        public uint MeritPld1 { get; set; } = 0;
        public uint MeritPld2 { get; set; } = 0;
        public uint MeritDrk1 { get; set; } = 0;
        public uint MeritDrk2 { get; set; } = 0;
        public uint MeritBst1 { get; set; } = 0;
        public uint MeritBst2 { get; set; } = 0;
        public uint MeritBrd1 { get; set; } = 0;
        public uint MeritBrd2 { get; set; } = 0;
        public uint MeritRng1 { get; set; } = 0;
        public uint MeritRng2 { get; set; } = 0;
        public uint MeritSam1 { get; set; } = 0;
        public uint MeritSam2 { get; set; } = 0;
        public uint MeritNin1 { get; set; } = 0;
        public uint MeritNin2 { get; set; } = 0;
        public uint MeritDrg1 { get; set; } = 0;
        public uint MeritDrg2 { get; set; } = 0;
        public uint MeritSmn1 { get; set; } = 0;
        public uint MeritSmn2 { get; set; } = 0;
        public uint MeritBlu1 { get; set; } = 0;
        public uint MeritBlu2 { get; set; } = 0;
        public uint MeritCor1 { get; set; } = 0;
        public uint MeritCor2 { get; set; } = 0;
        public uint MeritPup1 { get; set; } = 0;
        public uint MeritPup2 { get; set; } = 0;
        public uint MeritDnc1 { get; set; } = 0;
        public uint MeritDnc2 { get; set; } = 0;
        public uint MeritSch1 { get; set; } = 0;
        public uint MeritSch2 { get; set; } = 0;
        public uint MeritGeo1 { get; set; } = 0;
        public uint MeritGeo2 { get; set; } = 0;
        public uint MeritRun1 { get; set; } = 0;
        public uint MeritRun2 { get; set; } = 0;
        #endregion
        #region ジョブポ
        public ulong JobpoWar { get; set; } = 0;
        public ulong JobpoMnk { get; set; } = 0;
        public ulong JobpoWhm { get; set; } = 0;
        public ulong JobpoBlm { get; set; } = 0;
        public ulong JobpoRdm { get; set; } = 0;
        public ulong JobpoThf { get; set; } = 0;
        public ulong JobpoPld { get; set; } = 0;
        public ulong JobpoDrk { get; set; } = 0;
        public ulong JobpoBst { get; set; } = 0;
        public ulong JobpoBrd { get; set; } = 0;
        public ulong JobpoRng { get; set; } = 0;
        public ulong JobpoSam { get; set; } = 0;
        public ulong JobpoNin { get; set; } = 0;
        public ulong JobpoDrg { get; set; } = 0;
        public ulong JobpoSmn { get; set; } = 0;
        public ulong JobpoBlu { get; set; } = 0;
        public ulong JobpoCor { get; set; } = 0;
        public ulong JobpoPup { get; set; } = 0;
        public ulong JobpoDnc { get; set; } = 0;
        public ulong JobpoSch { get; set; } = 0;
        public ulong JobpoGeo { get; set; } = 0;
        public ulong JobpoRun { get; set; } = 0;
        #endregion
        #region 魔法
        public sbyte[] Magic { get; set; } = new sbyte[1023];
        public sbyte[] PhantomRoll { get; set; } = new sbyte[31];
        #endregion
        #region ミッション
        public int[] Mission { get; set; } = new int[13];
        public sbyte[] Assault { get; set; } = new sbyte[52];
        public sbyte[] CampaignOps { get; set; } = new sbyte[500];
        #endregion
        #region クエスト
        public sbyte[] QuestSand { get; set; } = new sbyte[121];
        public sbyte[] QuestBastok { get; set; } = new sbyte[100];
        public sbyte[] QuestWindurst { get; set; } = new sbyte[100];
        public sbyte[] QuestJeuno { get; set; } = new sbyte[159];
        public sbyte[] QuestOthers { get; set; } = new sbyte[131];
        public sbyte[] QuestOutlands { get; set; } = new sbyte[219];
        public sbyte[] QuestAhturhgan { get; set; } = new sbyte[104];
        public sbyte[] QuestPast { get; set; } = new sbyte[99];
        public sbyte[] QuestAbyssea { get; set; } = new sbyte[192];
        public sbyte[] QuestAdoulin { get; set; } = new sbyte[99];
        public sbyte[] QuestCoalitions { get; set; } = new sbyte[96];
        #endregion
        #region エミネンス
        public int EmiCompleted { get; set; } = 0;
        public sbyte[] EmiTutorialBasics { get; set; } = new sbyte[15];
        public sbyte[] EmiTutorialIntermediate { get; set; } = new sbyte[16];
        public sbyte[] EmiTutorialSynthesis { get; set; } = new sbyte[16];
        public sbyte[] EmiTutorialQuests1 { get; set; } = new sbyte[26];
        public sbyte[] EmiTutorialArtifact { get; set; } = new sbyte[66];
        public sbyte[] EmiTutorialLvlcap { get; set; } = new sbyte[17];
        public sbyte[] EmiTutorialStorage { get; set; } = new sbyte[17];
        public sbyte[] EmiTutorialWS { get; set; } = new sbyte[14];
        public sbyte[] EmiTutorialRhapsodies { get; set; } = new sbyte[24];
        public sbyte[] EmiTutorialSandoria { get; set; } = new sbyte[20];
        public sbyte[] EmiTutorialBastok { get; set; } = new sbyte[20];
        public sbyte[] EmiTutorialWindurst { get; set; } = new sbyte[20];
        public sbyte[] EmiTutorialZilart { get; set; } = new sbyte[16];
        public sbyte[] EmiTutorialPromathia { get; set; } = new sbyte[8];
        public sbyte[] EmiTutorialAhturhgan { get; set; } = new sbyte[6];
        public sbyte[] EmiTutorialAltana { get; set; } = new sbyte[8];
        public sbyte[] EmiTutorialAdoulin { get; set; } = new sbyte[5];
        public sbyte[] EmiCombatGeneral { get; set; } = new sbyte[26];
        public sbyte[] EmiCombatSpoils { get; set; } = new sbyte[57];
        public sbyte[] EmiCombatOriginalArea { get; set; } = new sbyte[111];
        public sbyte[] EmiCombatAdoulinArea { get; set; } = new sbyte[45];
        public sbyte[] EmiCombatZilartArea { get; set; } = new sbyte[22];
        public sbyte[] EmiCombatPromathiaArea { get; set; } = new sbyte[20];
        public sbyte[] EmiCombatAhturhganArea { get; set; } = new sbyte[9];
        public sbyte[] EmiCombatGoddessArea { get; set; } = new sbyte[22];
        public sbyte[] EmiCombatAbysseaArea { get; set; } = new sbyte[9];
        public sbyte[] EmiCombatEschaArea { get; set; } = new sbyte[28];
        public sbyte[] EmiFishingGeneral { get; set; } = new sbyte[18];
        public sbyte[] EmiFishingTenacity { get; set; } = new sbyte[25];
        public sbyte[] EmiCraftingGeneral { get; set; } = new sbyte[1];
        public sbyte[] EmiCraftingEscutcheonsWoodworking { get; set; } = new sbyte[4];
        public sbyte[] EmiCraftingEscutcheonsClothcraft { get; set; } = new sbyte[4];
        public sbyte[] EmiCraftingEscutcheonsAlchemy { get; set; } = new sbyte[4];
        public sbyte[] EmiCraftingEscutcheonsBonecraft { get; set; } = new sbyte[4];
        public sbyte[] EmiCraftingEscutcheonsCooking { get; set; } = new sbyte[4];
        public sbyte[] EmiCraftingEscutcheonsGoldsmithing { get; set; } = new sbyte[4];
        public sbyte[] EmiCraftingEscutcheonsLeathercraft { get; set; } = new sbyte[4];
        public sbyte[] EmiCraftingEscutcheonsSmithing { get; set; } = new sbyte[4];
        public sbyte[] EmiHarvestingGeneral { get; set; } = new sbyte[2];
        public sbyte[] EmiHarvestingOriginalArea { get; set; } = new sbyte[12];
        public sbyte[] EmiHarvestingAdoulinArea { get; set; } = new sbyte[26];
        public sbyte[] EmiHarvestingZilartArea { get; set; } = new sbyte[4];
        public sbyte[] EmiHarvestingPromathiaArea { get; set; } = new sbyte[6];
        public sbyte[] EmiHarvestingAhturhganArea { get; set; } = new sbyte[6];
        public sbyte[] EmiHarvestingGoddessArea { get; set; } = new sbyte[6];
        public sbyte[] EmiHarvestingAbysseaArea { get; set; } = new sbyte[5];
        public sbyte[] EmiContentLairReive { get; set; } = new sbyte[10];
        public sbyte[] EmiContentColonizationReive { get; set; } = new sbyte[14];
        public sbyte[] EmiContentWildskeeperReive { get; set; } = new sbyte[6];
        public sbyte[] EmiContentOther { get; set; } = new sbyte[17];
        public sbyte[] EmiContentDynamis { get; set; } = new sbyte[30];
        public sbyte[] EmiContentLimbus { get; set; } = new sbyte[12];
        public sbyte[] EmiContentZNM { get; set; } = new sbyte[27];
        public sbyte[] EmiContentVagary { get; set; } = new sbyte[5];
        public sbyte[] EmiContentOmen { get; set; } = new sbyte[5];
        public sbyte[] EmiContentOdyssey { get; set; } = new sbyte[3];
        public sbyte[] EmiContentSortie { get; set; } = new sbyte[9];
        public sbyte[] EmiAchievementsJobLevels { get; set; } = new sbyte[88];
        public sbyte[] EmiAchievementsFame { get; set; } = new sbyte[14];
        public sbyte[] EmiUnityWanted { get; set; } = new sbyte[56];
        public sbyte[] EmiVanaversary15 { get; set; } = new sbyte[5];
        public sbyte[] EmiOtherRoeQuests1 { get; set; } = new sbyte[15];
        public sbyte[] EmiOtherRoeQuests2 { get; set; } = new sbyte[7];
        public sbyte[] EmiOtherRoeQuests3 { get; set; } = new sbyte[8];
        #endregion
        #region 移動
        public sbyte[] MovOutpost { get; set; } = new sbyte[17];
        public sbyte[] MovRunicPortal { get; set; } = new sbyte[6];
        public sbyte[] MovSurvivalGuide { get; set; } = new sbyte[98];
        public sbyte[] MovHomePoint { get; set; } = new sbyte[121];
        public sbyte[] MovMount { get; set; } = new sbyte[39];
        #endregion
    }
}