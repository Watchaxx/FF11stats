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
        public short[] Magic { get; set; } = new short[1023];
        public short[] PhantomRoll { get; set; } = new short[31];
        #endregion
        #region ミッション
        public int[] Mission { get; set; } = new int[13];
        public short[] Assault { get; set; } = new short[52];
        public short[] CampaignOps { get; set; } = new short[500];
        #endregion
        #region クエスト
        public short[] QuestSand { get; set; } = new short[121];
        public short[] QuestBastok { get; set; } = new short[100];
        public short[] QuestWindurst { get; set; } = new short[100];
        public short[] QuestJeuno { get; set; } = new short[159];
        public short[] QuestOthers { get; set; } = new short[131];
        public short[] QuestOutlands { get; set; } = new short[219];
        public short[] QuestAhturhgan { get; set; } = new short[104];
        public short[] QuestPast { get; set; } = new short[99];
        public short[] QuestAbyssea { get; set; } = new short[192];
        public short[] QuestAdoulin { get; set; } = new short[99];
        public short[] QuestCoalitions { get; set; } = new short[96];
        #endregion
        #region エミネンス
        public int EmiCompleted { get; set; } = 0;
        public short[] EmiTutorialBasics { get; set; } = new short[15];
        public short[] EmiTutorialIntermediate { get; set; } = new short[16];
        public short[] EmiTutorialSynthesis { get; set; } = new short[16];
        public short[] EmiTutorialQuests1 { get; set; } = new short[26];
        public short[] EmiTutorialArtifact { get; set; } = new short[66];
        public short[] EmiTutorialLvlcap { get; set; } = new short[17];
        public short[] EmiTutorialStorage { get; set; } = new short[17];
        public short[] EmiTutorialWS { get; set; } = new short[14];
        public short[] EmiTutorialRhapsodies { get; set; } = new short[24];
        public short[] EmiTutorialSandoria { get; set; } = new short[20];
        public short[] EmiTutorialBastok { get; set; } = new short[20];
        public short[] EmiTutorialWindurst { get; set; } = new short[20];
        public short[] EmiTutorialZilart { get; set; } = new short[16];
        public short[] EmiTutorialPromathia { get; set; } = new short[8];
        public short[] EmiTutorialAhturhgan { get; set; } = new short[6];
        public short[] EmiTutorialAltana { get; set; } = new short[8];
        public short[] EmiTutorialAdoulin { get; set; } = new short[5];
        public short[] EmiCombatGeneral { get; set; } = new short[26];
        public short[] EmiCombatSpoils { get; set; } = new short[57];
        public short[] EmiCombatOriginalArea { get; set; } = new short[111];
        public short[] EmiCombatAdoulinArea { get; set; } = new short[45];
        public short[] EmiCombatZilartArea { get; set; } = new short[22];
        public short[] EmiCombatPromathiaArea { get; set; } = new short[20];
        public short[] EmiCombatAhturhganArea { get; set; } = new short[9];
        public short[] EmiCombatGoddessArea { get; set; } = new short[22];
        public short[] EmiCombatAbysseaArea { get; set; } = new short[9];
        public short[] EmiCombatEschaArea { get; set; } = new short[28];
        public short[] EmiFishingGeneral { get; set; } = new short[18];
        public short[] EmiFishingTenacity { get; set; } = new short[25];
        public short[] EmiCraftingGeneral { get; set; } = new short[1];
        public short[] EmiCraftingEscutcheonsWoodworking { get; set; } = new short[4];
        public short[] EmiCraftingEscutcheonsClothcraft { get; set; } = new short[4];
        public short[] EmiCraftingEscutcheonsAlchemy { get; set; } = new short[4];
        public short[] EmiCraftingEscutcheonsBonecraft { get; set; } = new short[4];
        public short[] EmiCraftingEscutcheonsCooking { get; set; } = new short[4];
        public short[] EmiCraftingEscutcheonsGoldsmithing { get; set; } = new short[4];
        public short[] EmiCraftingEscutcheonsLeathercraft { get; set; } = new short[4];
        public short[] EmiCraftingEscutcheonsSmithing { get; set; } = new short[4];
        public short[] EmiHarvestingGeneral { get; set; } = new short[2];
        public short[] EmiHarvestingOriginalArea { get; set; } = new short[12];
        public short[] EmiHarvestingAdoulinArea { get; set; } = new short[26];
        public short[] EmiHarvestingZilartArea { get; set; } = new short[4];
        public short[] EmiHarvestingPromathiaArea { get; set; } = new short[6];
        public short[] EmiHarvestingAhturhganArea { get; set; } = new short[6];
        public short[] EmiHarvestingGoddessArea { get; set; } = new short[6];
        public short[] EmiHarvestingAbysseaArea { get; set; } = new short[5];
        public short[] EmiContentLairReive { get; set; } = new short[10];
        public short[] EmiContentColonizationReive { get; set; } = new short[14];
        public short[] EmiContentWildskeeperReive { get; set; } = new short[6];
        public short[] EmiContentOther { get; set; } = new short[17];
        public short[] EmiContentDynamis { get; set; } = new short[30];
        public short[] EmiContentLimbus { get; set; } = new short[12];
        public short[] EmiContentZNM { get; set; } = new short[27];
        public short[] EmiContentVagary { get; set; } = new short[5];
        public short[] EmiContentOmen { get; set; } = new short[5];
        public short[] EmiContentOdyssey { get; set; } = new short[3];
        public short[] EmiContentSortie { get; set; } = new short[9];
        public short[] EmiAchievementsJobLevels { get; set; } = new short[88];
        public short[] EmiAchievementsFame { get; set; } = new short[14];
        public short[] EmiUnityWanted { get; set; } = new short[56];
        public short[] EmiVanaversary15 { get; set; } = new short[5];
        public short[] EmiOtherRoeQuests1 { get; set; } = new short[15];
        public short[] EmiOtherRoeQuests2 { get; set; } = new short[7];
        public short[] EmiOtherRoeQuests3 { get; set; } = new short[8];
        #endregion
        #region 移動
        public short[] MovOutpost { get; set; } = new short[17];
        public short[] MovRunicPortal { get; set; } = new short[6];
        public short[] MovSurvivalGuide { get; set; } = new short[98];
        public short[] MovHomePoint { get; set; } = new short[121];
        public short[] MovMount { get; set; } = new short[39];
        #endregion
    }
}