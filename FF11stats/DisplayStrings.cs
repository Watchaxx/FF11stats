using Dic = System.Collections.Generic.Dictionary<byte, string>;

namespace FF11stats
{
    internal class DisplayStrings
    {
        const string WAR = "戦士";
        const string MNK = "モンク";
        const string WHM = "白魔道士";
        const string BLM = "黒魔道士";
        const string RDM = "赤魔道士";
        const string THF = "シーフ";
        const string PLD = "ナイト";
        const string DRK = "暗黒騎士";
        const string BST = "獣使い";
        const string BRD = "吟遊詩人";
        const string RNG = "狩人";
        const string SAM = "侍";
        const string NIN = "忍者";
        const string DRG = "竜騎士";
        const string SMN = "召喚士";
        const string BLU = "青魔道士";
        const string COR = "コルセア";
        const string PUP = "からくり士";
        const string DNC = "踊り子";
        const string SCH = "学者";
        const string GEO = "風水士";
        const string RUN = "魔導剣士";

#pragma warning disable IDE0051
        const string SandOria = "サンドリア王国";
        const string Bastok = "バストゥーク共和国";
        const string Windurst = "ウィンダス連邦";
        const string Jeuno = "ジュノ大公国";
        const string Ronfaure = "ロンフォール";
        const string Zulkheim = "ザルクヘイム";
        const string Norvallen = "ノルバレン";
        const string Gustaberg = "グスタベルグ";
        const string Derfland = "デルフラント";
        const string Sarutabaruta = "サルタバルタ";
        const string Kolshushu = "コルシュシュ";
        const string Aragoneu = "アラゴーニュ";
        const string Fauregandi = "フォルガンディ";
        const string Valdeaunia = "バルドニア";
        const string Qufim = "クフィム";
        const string LiTelor = "リ・テロア";
        const string Kuzotz = "クゾッツ";
        const string Vollbow = "ヴォルボー";
        const string ElshimoLowlands = "低地エルシモ";
        const string ElshimoUplands = "高地エルシモ";
        const string TuLia = "トゥー・リア";
        const string Dynamis = "デュナミス";
        const string Movalpolos = "ムバルポロス";
        const string TavnazianMarquisate = "タブナジア侯国";
        const string TavnazianArchipelago = "タブナジア群島";
        const string Promyvion = "プロミヴォン";
        const string Lumoria = "ルモリア";
        const string Limbus = "リンバス";
        const string EmpireOfAhtUrhgan = "アトルガン皇国";
        const string WestAhtUrhgan = "西アトルガン地方";
        const string MamoolJaSavagelands = "マムージャ蕃国";
        const string HalvungTerritory = "ハルブーン傭兵団領";
        const string ArrapagoIslands = "アラパゴ諸島";
        const string RuinsOfAlzadaal = "アルザダール文明遺跡群";
        const string RonfaureFront = "ロンフォール戦線";
        const string NorvallenFront = "ノルバレン戦線";
        const string GustabergFront = "グスタベルグ戦線";
        const string DerflandFront = "デルフラント戦線";
        const string SarutabarutaFront = "サルタバルタ戦線";
        const string AragoneuFront = "アラゴーニュ戦線";
        const string FauregandiFront = "フォルガンディ戦線";
        const string ValdeauniaFront = "バルドニア戦線";
        const string OrcishHosts = "オーク帝国軍";
        const string QuadavShieldwarriors = "クゥダフ兵団";
        const string YagudoTheomilitary = "ヤグード教団軍";
        const string DarkKindred = "闇の王親衛隊";
        const string Abyssea = "アビセア";
        const string Threshold = "スレッショルド";
        const string Abdhaljs = "アブダルス";
        const string SacredCityOfAdoulin = "神聖アドゥリン都市同盟";
        const string AdoulinIslands = "アドゥリン諸島";
        const string EastUlbukaTerritory = "東ウルブカ地方";
        const string RaKaznar = "ラ・カザナル";
        const string Escha = "エスカ";
        const string FarEast = "ひんがし";

        const string PhanauetChannel = "ファノエ運河";
        const string CarpentersLanding = "ギルド桟橋";
        const string Manaclipper = "マナクリッパー";
        const string BibikiBay = "ビビキー湾";
        const string UleguerandRange = "ウルガラン山脈";
        const string BearclawPinnacle = "熊爪嶽";
        const string AttohwaChasm = "アットワ地溝";
        const string BoneyardGully = "千骸谷";
        const string PsoXja = "ソ・ジヤ";
        const string ShroudedMaw = "異界の口";
        const string OldtonMovalpolos = "ムバルポロス旧市街";
        const string NewtonMovalpolos = "ムバルポロス新市街";
        const string MineShaft2716 = "2716号採石場";
        const string HallOfTransference = "転移の間";
        const string AbysseaKonschtat = "アビセア-コンシュタット";
        const string PromyvionHolla = "プロミヴォン-ホラ";
        const string SpireOfHolla = "ホラの塔";
        const string PromyvionDem = "プロミヴォン-デム";
        const string SpireOfDem = "デムの塔";
        const string PromyvionMea = "プロミヴォン-メア";
        const string SpireOfMea = "メアの塔";
        const string PromyvionVahzl = "プロミヴォン-ヴァズ";
        const string SpireOfVahzl = "ヴァズの塔";
        const string LufaiseMeadows = "ルフェーゼ野";
        const string MisareauxCoast = "ミザレオ海岸";
        const string TavnazianSafehold = "タブナジア地下壕";
        const string PhomiunaAqueducts = "フォミュナ水道";
        const string Sacrarium = "礼拝堂";
        const string RiverneSiteB01 = "リヴェーヌ岩塊群サイトB01";
        const string RiverneSiteA01 = "リヴェーヌ岩塊群サイトA01";
        const string MonarchLinn = "帝龍の飛泉";
        const string SealionsDen = "海獅子の巣窟";
        const string AlTaieu = "アル・タユ";
        const string GrandPalaceOfHuXzoi = "フ・ゾイの王宮";
        const string GardenOfRuHmet = "ル・メトの園";
        const string EmpyrealParadox = "天象の鎖";
        const string Temenos = "テメナス";
        const string Apollyon = "アポリオン";
        const string DynamisValkurm = "デュナミス-バルクルム";
        const string DynamisBuburimu = "デュナミス-ブブリム";
        const string DynamisQufim = "デュナミス-クフィム";
        const string DynamisTavnazia = "デュナミス-タブナジア";
        const string DioramaAbdhaljsGhelsba = "アブダルスの箱庭-ゲルスバ";
        const string AbdhaljsIslePurgonorgo = "アブダルスの島-プルゴノルゴ";
        const string AbysseaTahrongi = "アビセア-タロンギ";
        const string OpenSeaRouteToAlZahbi = "外洋航路：アルザビ行き";
        const string OpenSeaRouteToMhaura = "外洋航路：マウラ行き";
        const string AlZahbi = "アルザビ";
        const string AhtUrhganWhitegate = "アトルガン白門";
        const string WajaomWoodlands = "ワジャーム樹林";
        const string BhaflauThickets = "バフラウ段丘";
        const string Nashmau = "ナシュモ";
        const string ArrapagoReef = "アラパゴ暗礁域";
        const string IlrusiAtoll = "イルルシ環礁";
        const string Periqia = "ペリキア";
        const string TalaccaCove = "タラッカ入江";
        const string SilverSeaRouteToNashmau = "銀海航路：ナシュモ行き";
        const string SilverSeaRouteToAlZahbi = "銀海航路：アルザビ行き";
        const string AshuTalif = "アシュタリフ号";
        const string MountZhayolm = "ゼオルム火山";
        const string Halvung = "ハルブーン";
        const string LebrosCavern = "レベロス風穴";
        const string NavukgoExecutionChamber = "ナバゴ処刑場";
        const string Mamook = "マムーク";
        const string MamoolJaTrainingGrounds = "マムージャ兵訓練所";
        const string JadeSepulcher = "翡翠廟";
        const string AydeewaSubterrane = "エジワ蘿洞";
        const string LeujaoamSanctum = "ルジャワン霊窟";
        const string ChocoboCircuit = "チョコボサーキット";
        const string Colosseum = "コロセウム";
        const string AlzadaalUnderseaRuins = "アルザダール海底遺跡群";
        const string ZhayolmRemnants = "ゼオルム遺構";
        const string ArrapagoRemnants = "アラパゴ遺構";
        const string BhaflauRemnants = "バフラウ遺構";
        const string SilverSeaRemnants = "銀海遺構";
        const string NyzulIsle = "ナイズル島";
        const string HazhalmTestingGrounds = "ハザルム試験場";
        const string CaedarvaMire = "カダーバの浮沼";
        const string SouthernSandOriaS = "南サンドリア〔Ｓ〕";
        const string EastRonfaureS = "東ロンフォール〔Ｓ〕";
        const string JugnerForestS = "ジャグナー森林〔Ｓ〕";
        const string VunkerlInletS = "ブンカール浦〔Ｓ〕";
        const string BatalliaDownsS = "バタリア丘陵〔Ｓ〕";
        const string LaVauleS = "ラヴォール村〔Ｓ〕";
        const string EverbloomHollow = "常花の石窟";
        const string BastokMarketsS = "バストゥーク商業区〔Ｓ〕";
        const string NorthGustabergS = "北グスタベルグ〔Ｓ〕";
        const string GraubergS = "グロウベルグ〔Ｓ〕";
        const string PashhowMarshlandsS = "パシュハウ沼〔Ｓ〕";
        const string RolanberryFieldsS = "ロランベリー耕地〔Ｓ〕";
        const string BeadeauxS = "ベドー〔Ｓ〕";
        const string RuhotzSilvermines = "ルホッツ銀山";
        const string WindurstWatersS = "ウィンダス水の区〔Ｓ〕";
        const string WestSarutabarutaS = "西サルタバルタ〔Ｓ〕";
        const string FortKarugoNarugoS = "カルゴナルゴ城砦〔Ｓ〕";
        const string MeriphataudMountainsS = "メリファト山地〔Ｓ〕";
        const string SauromugueChampaignS = "ソロムグ原野〔Ｓ〕";
        const string CastleOztrojaS = "オズトロヤ城〔Ｓ〕";
        const string WestRonfaure = "西ロンフォール";
        const string EastRonfaure = "東ロンフォール";
        const string LaTheinePlateau = "ラテーヌ高原";
        const string ValkurmDunes = "バルクルム砂丘";
        const string JugnerForest = "ジャグナー森林";
        const string BatalliaDowns = "バタリア丘陵";
        const string NorthGustaberg = "北グスタベルグ";
        const string SouthGustaberg = "南グスタベルグ";
        const string KonschtatHighlands = "コンシュタット高地";
        const string PashhowMarshlands = "パシュハウ沼";
        const string RolanberryFields = "ロランベリー耕地";
        const string BeaucedineGlacier = "ボスディン氷河";
        const string Xarcabard = "ザルカバード";
        const string CapeTeriggan = "テリガン岬";
        const string EasternAltepaDesert = "東アルテパ砂漠";
        const string WestSarutabaruta = "西サルタバルタ";
        const string EastSarutabaruta = "東サルタバルタ";
        const string TahrongiCanyon = "タロンギ大峡谷";
        const string BuburimuPeninsula = "ブブリム半島";
        const string MeriphataudMountains = "メリファト山地";
        const string SauromugueChampaign = "ソロムグ原野";
        const string SanctuaryOfZiTah = "聖地ジ・タ";
        const string RoMaeve = "ロ・メーヴ";
        const string YuhtungaJungle = "ユタンガ大森林";
        const string YhoatorJungle = "ヨアトル大森林";
        const string WesternAltepaDesert = "西アルテパ砂漠";
        const string QufimIsland = "クフィム島";
        const string BehemothsDominion = "ベヒーモスの縄張り";
        const string ValleyOfSorrows = "慟哭の谷";
        const string GhoyusReverie = "ゴユの空洞";
        const string RuAunGardens = "ル・オンの庭";
        const string MordionGaol = "モルディオン監獄";
        const string AbysseaLaTheine = "アビセア-ラテーヌ";
        const string OuterRaKaznarU2 = "ラ・カザナル宮外郭〔Ｕ２〕";
        const string DynamisBeaucedine = "デュナミス-ボスディン";
        const string DynamisXarcabard = "デュナミス-ザルカバード";
        const string BeaucedineGlacierS = "ボスディン氷河〔Ｓ〕";
        const string XarcabardS = "ザルカバード〔Ｓ〕";
        const string CastleZvahlBaileysS = "ズヴァール城外郭〔Ｓ〕";
        const string HorlaisPeak = "ホルレーの岩峰";
        const string GhelsbaOutpost = "ゲルスバ野営陣";
        const string FortGhelsba = "ゲルスバ砦";
        const string YughottGrotto = "ユグホトの岩屋";
        const string PalboroughMines = "パルブロ鉱山";
        const string WaughroonShrine = "ワールンの祠";
        const string Giddeus = "ギデアス";
        const string BalgasDais = "バルガの舞台";
        const string Beadeaux = "ベドー";
        const string QulunDome = "クゥルンの大伽藍";
        const string Davoi = "ダボイ";
        const string MonasticCavern = "修道窟";
        const string CastleOztroja = "オズトロヤ城";
        const string AltarRoom = "祭壇の間";
        const string BoyahdaTree = "ボヤーダ樹";
        const string DragonsAery = "龍のねぐら";
        const string CastleZvahlKeepS = "ズヴァール城内郭〔Ｓ〕";
        const string ThroneRoomS = "王の間〔Ｓ〕";
        const string MiddleDelkfuttsTower = "デルクフの塔中層";
        const string UpperDelkfuttsTower = "デルクフの塔上層";
        const string TempleOfUggalepih = "ウガレピ寺院";
        const string DenOfRancor = "怨念洞";
        const string CastleZvahlBaileys = "ズヴァール城外郭";
        const string CastleZvahlKeep = "ズヴァール城内郭";
        const string SacrificialChamber = "生贄の間";
        const string GarlaigeCitadelS = "ガルレージュ要塞〔Ｓ〕";
        const string ThroneRoom = "王の間";
        const string RanguemontPass = "ラングモント峠";
        const string BostaunieuxOubliette = "ボストーニュ監獄";
        const string ChamberOfOracles = "宣託の間";
        const string ToraimaraiCanal = "トライマライ水路";
        const string FullMoonFountain = "満月の泉";
        const string CrawlersNestS = "クロウラーの巣〔Ｓ〕";
        const string ZeruhnMines = "ツェールン鉱山";
        const string KorrolokaTunnel = "コロロカの洞門";
        const string KuftalTunnel = "クフタルの洞門";
        const string EldiemeNecropolisS = "エルディーム古墳〔Ｓ〕";
        const string SeaSerpentGrotto = "海蛇の岩窟";
        const string VeLugannonPalace = "ヴェ・ルガノン宮殿";
        const string ShrineOfRuAvitau = "ル・アビタウ神殿";
        const string StellarFulcrum = "天輪の場";
        const string LaLoffAmphitheater = "ラ・ロフの劇場";
        const string CelestialNexus = "宿星の座";
        const string WalkOfEchoes = "ウォークオブエコーズ";
        const string MaquetteAbdhaljsLegionA = "アブダルスの模型-レギオンA";
        const string LowerDelkfuttsTower = "デルクフの塔下層";
        const string DynamisSandOria = "デュナミス-サンドリア";
        const string DynamisBastok = "デュナミス-バストゥーク";
        const string DynamisWindurst = "デュナミス-ウィンダス";
        const string DynamisJeuno = "デュナミス-ジュノ";
        const string OuterRaKaznarU3 = "ラ・カザナル宮外郭〔Ｕ３〕";
        const string KingRanperresTomb = "龍王ランペールの墓";
        const string DangrufWadi = "ダングルフの涸れ谷";
        const string InnerHorutotoRuins = "内ホルトト遺跡";
        const string OrdellesCaves = "オルデール鍾乳洞";
        const string OuterHorutotoRuins = "外ホルトト遺跡";
        const string EldiemeNecropolis = "エルディーム古墳";
        const string GusgenMines = "グスゲン鉱山";
        const string CrawlersNest = "クロウラーの巣";
        const string MazeOfShakhrami = "シャクラミの地下迷宮";
        const string GarlaigeCitadel = "ガルレージュ要塞";
        const string CloisterOfGales = "突風の回廊";
        const string CloisterOfStorms = "雷鳴の回廊";
        const string CloisterOfFrost = "凍結の回廊";
        const string FeiYin = "フェ・イン";
        const string IfritsCauldron = "イフリートの釜";
        const string QuBiaArena = "ク・ビアの闘技場";
        const string CloisterOfFlames = "灼熱の回廊";
        const string QuicksandCaves = "流砂洞";
        const string CloisterOfTremors = "震動の回廊";
        const string CloisterOfTides = "海流の回廊";
        const string GustavTunnel = "グスタフの洞門";
        const string LabyrinthOfOnzozo = "オンゾゾの迷路";
        const string AbysseaAttohwa = "アビセア-アットワ";
        const string AbysseaMisareaux = "アビセア-ミザレオ";
        const string AbysseaVunkerl = "アビセア-ブンカール";
        const string AbysseaAltepa = "アビセア-アルテパ";
        const string ShipBoundForSelbina = "航路：セルビナ行き";
        const string ShipBoundForMhaura = "航路：マウラ行き";
        const string Provenance = "真界";
        const string SandOriaJeunoAirship = "飛空艇航路";
        const string BastokJeunoAirship = "飛空艇航路";
        const string WindurstJeunoAirship = "飛空艇航路";
        const string KazhamJeunoAirship = "飛空艇航路";
        const string ThroneRoomV = "王の間〔Ｖ〕";
        const string SouthernSandOria = "南サンドリア";
        const string NorthernSandOria = "北サンドリア";
        const string PortSandOria = "サンドリア港";
        const string ChateaudOraguille = "ドラギーユ城";
        const string BastokMines = "バストゥーク鉱山区";
        const string BastokMarkets = "バストゥーク商業区";
        const string PortBastok = "バストゥーク港";
        const string Metalworks = "大工房";
        const string WindurstWaters = "ウィンダス水の区";
        const string WindurstWalls = "ウィンダス石の区";
        const string PortWindurst = "ウィンダス港";
        const string WindurstWoods = "ウィンダス森の区";
        const string HeavensTower = "天の塔";
        const string RuLudeGardens = "ル・ルデの庭";
        const string UpperJeuno = "ジュノ上層";
        const string LowerJeuno = "ジュノ下層";
        const string PortJeuno = "ジュノ港";
        const string Rabao = "ラバオ";
        const string Selbina = "セルビナ";
        const string Mhaura = "マウラ";
        const string Kazham = "カザム";
        const string HallOfTheGods = "神々の間";
        const string Norg = "ノーグ";
        const string AbysseaUleguerand = "アビセア-ウルガラン";
        const string AbysseaGrauberg = "アビセア-グロウベルグ";
        const string AbysseaEmpyrealParadox = "アビセア-天象の鎖";
        const string WesternAdoulin = "西アドゥリン";
        const string EasternAdoulin = "東アドゥリン";
        const string RalaWaterways = "ララ水道";
        const string RalaWaterwaysU = "ララ水道〔Ｕ〕";
        const string YahseHuntingGrounds = "ヤッセの狩り場";
        const string CeizakBattlegrounds = "ケイザック古戦場";
        const string ForetDeHennetiel = "エヌティエル水林";
        const string YorciaWeald = "ヨルシア森林";
        const string YorciaWealdU = "ヨルシア森林〔Ｕ〕";
        const string MorimarBasaltFields = "モリマー台地";
        const string MarjamiRavine = "マリアミ渓谷";
        const string KamihrDrifts = "カミール山麓";
        const string SihGates = "シィの門";
        const string MohGates = "モーの門";
        const string CirdasCaverns = "シルダス洞窟";
        const string CirdasCavernsU = "シルダス洞窟〔Ｕ〕";
        const string DhoGates = "ドーの門";
        const string WohGates = "ウォーの門";
        const string OuterRaKaznar = "ラ・カザナル宮外郭";
        const string OuterRaKaznarU1 = "ラ・カザナル宮外郭〔Ｕ１〕";
        const string RaKaznarInnerCourt = "ラ・カザナル宮内郭";
        const string RaKaznarTurris = "ラ・カザナル宮天守";
        const string GworaCorridor = "グォラ-歩廊";
        const string WalkOfEchoesP2 = "ウォークオブエコーズ〔Ｐ２〕";
        const string MogGarden = "モグガーデン";
        const string Leafallia = "リファーリア";
        const string MountKamihr = "カミール山";
        const string SilverKnife = "シルバー・ナイフ";
        const string CelenniaMemorialLibrary = "セレニア図書館";
        const string Feretory = "魂の聖櫃";
        const string MaquetteAbdhaljsLegionB = "アブダルスの模型-レギオンB";
        const string EschaZiTah = "エスカ-ジ・タ";
        const string EschaRuAun = "エスカ-ル・オン";
        const string DesuetiaEmpyrealParadox = "デスエチア-天象の鎖";
        const string Reisenjima = "醴泉島";
        const string ReisenjimaHenge = "醴泉島-秘境";
        const string ReisenjimaSanctorium = "醴泉島の祠";
        const string DynamisSandOriaD = "デュナミス-サンドリア〔Ｄ〕";
        const string DynamisBastokD = "デュナミス-バストゥーク〔Ｄ〕";
        const string DynamisWindurstD = "デュナミス-ウィンダス〔Ｄ〕";
        const string DynamisJeunoD = "デュナミス-ジュノ〔Ｄ〕";
        const string WalkOfEchoesP1 = "ウォークオブエコーズ〔Ｐ１〕";
        const string GworaThroneRoom = "グォラ-王の間";

        const string af = "アーティファクト";
        const string cap = "レベルキャップ解放";
        const string core = "C.レイヴ：";
        const string exbg = "マイバッグ拡張";
        const string exmb = "モグ金庫拡張";
        const string fame = "名声：";
        const string fika = "格闘をした時間";
        const string gima = "ギルドマスターからの課題";
        const string gimt = "ギルドマスターと話す";
        const string har = "採集：";
        const string jobg = "ジョブ取得";
        const string lare = "レイア・レイヴ：";
        const string mogh = "モグハウス出口拡張：";
        const string reg = "リージョン：";
        const string se = "戦闘：";
        const string spil = "戦利品";
        const string stag = "監視哨";
        const string to = "討伐：";
        const string tb = "討伐:";
        const string yug = "ユグナス調査指令";
        const string lv30 = "レベル30";
        const string lv50 = "レベル50";
        const string lv75 = "レベル75";
        const string lv99 = "レベル99";

        #region クエスト
        internal Dic QuestBs { get; } = new( 100 ) { { 0, "セイレーンの涙" }, { 1, "ガルカと少女" }, { 2, "ようこそバストゥークへ" }, { 3, "待ち人来たらず" }, { 4, "クゥダフの呪い" },
            { 05, "甲羅を脱いで" }, { 6, "ミスリルに賭けた男たち" }, { 7, "11人目の真実" }, { 8, "買い取りなら天晶堂" }, { 9, "犬は忘れない" },
            { 10, "ダングルフの奇岩" }, { 11, "灯台もと暗し" }, { 12, "豊かな食卓" }, { 13, "エルヴァーンの彫金師" }, { 14, "カマドに火をつけて" },
            { 15, "スモークオンザマウンテン" }, { 16, "スタンプラリー" }, { 17, "共に白髪の生えるまで" }, { 18, "幸せのさじ加減" }, { 19, "心の壁" },
            { 20, "ライバル" }, { 21, "ママは冒険者？" }, { 22, "ママの大仕事" }, { 23, "決別" }, { 24, "砂丘に舞う光" },
            { 25, "ゴキゲンナナメな機械" }, { 26, "工房長の秘密" }, { 27, "常連客" }, { 28, "暗黒剣" }, { 29, "クラウツ橋の隣人" },
            { 30, "冒険者の帰還" }, { 31, "臥竜の滝" }, { 32, "憎悪" }, { 33, "雨煙るベドー" }, { 34, "呪いの視線" },
            { 35, "飛空艇の恐怖" }, { 36, "おばあちゃんの知恵袋" }, { 37, "男の仕事" }, { 38, "骨のある生活" }, { 39, "ツェールン鉱山の大掃除" },
            { 40, "黒の技" }, { 41, "釣りとバケツの関係" }, { 42, "イフリートの空に向かう船" }, { 43, "狂想曲「氷河に果てる恋」" }, { 44, "ブリジッドのファッションチェック" },
            { 45, "グスタベルグ観光案内" }, { 46, "砂の道を拓く" }, { 47, "死を運ぶ刃" }, { 48, "猛き獣の拳を" }, { 49, "アルタナの悲しみ" },
            { 50, "センスを磨くのにゃ" }, { 51, "さまよえる亡霊" }, { 52, "そして、めぐりあう" }, { 53, "守るべき何か" }, { 54, "祖母の心孫知らず" },
            { 55, "200年のすれ違い" }, { 56, "語り部の遺品" }, { 57, "黒の伝承" }, { 58, "暗黒の虜囚" }, { 59, "死神の刃は黒く輝く" },
            { 60, "アヤメとカエデ" }, { 61, "死に至る病" }, { 62, "黄昏の恋人たち" }, { 63, "星に願いを" }, { 64, "退魔の報酬～バストゥーク編" },
            { 65, "その重さとの闘い" }, { 66, "明日へと向かう銃弾" }, { 67, "剣を継ぐ者" }, { 68, "遺せなかった拳" }, { 69, "護衛の報酬～バストゥーク編" },
            { 70, "落とし主は誰だinバストゥーク" }, { 71, "あの日の約束" }, { 72, "ブリジッドのファッションチェックⅡ" }, { 73, "暗き地の底より" }, { 74, "聖典の持ち主" },
            { 75, "ムバルポロスを探れ" }, { 76, "美空を目指す" }, { 77, "羽ばたく力を" }, { 78, "名づけ子に" }, { 79, "ひとりでできる？" },
            { 80, "回路をめぐる思惑" }, { 81, "七つの緻密なトリックを" }, { 82, "山猫の誘惑" }, { 83, "力と覚悟" }, { 84, "真心の温度" },
            { 85, "いつか見た夢" }, { 86, "錬金レボリューション" }, { 87, "錬成指南" }, { 88, "あの人のように" }, { 89, "錬成支援" },
            { 90, "新魔法フェイス（バストゥーク）" }, { 98, "土の試練・改" }, { 99, "土の試練" } };
        internal Dic QuestWs { get; } = new( 100 ) { { 0, "ララブのしっぽ亭" }, { 1, "芸術家によるラプソディ" }, { 2, "信仰の行く先" }, { 3, "花と修羅" }, { 4, "帽子屋の宣伝" },
            { 05, "貴婦人の所望" }, { 6, "特ダネ・ウィンダス" }, { 7, "盗まれた特ダネ" }, { 8, "古文書の解読" }, { 9, "知識の守り手" },
            { 10, "ある愛のうた" }, { 11, "茶褐色の秘密" }, { 12, "買出し部隊" }, { 13, "夜に隠れて" }, { 14, "魔法の水" },
            { 15, "呪われたリボン" }, { 16, "水呼びの扉" }, { 17, "教材募集" }, { 18, "トップを目指すタイプ" }, { 19, "暁を覚えず" },
            { 20, "間違いと過ち" }, { 21, "いきなりウィンダスの危機" }, { 22, "ロイヤルお鍋" }, { 23, "音楽のあるレストラン" }, { 24, "夜空はコイン" },
            { 25, "競売所の手紙" }, { 26, "美声のススメ" }, { 27, "闇のまなざし" }, { 28, "死神のまなざし" }, { 29, "ゴーレムのまなざし" },
            { 30, "マンドラゴラの軌跡" }, { 31, "天からの贈り物" }, { 32, "過去からの呼び声" }, { 33, "錬金術の実験" }, { 34, "おさかなチェック" },
            { 35, "星降る丘" }, { 36, "航海帽子" }, { 37, "正義の一味" }, { 38, "オバケの家" }, { 39, "名探偵誕生？" },
            { 40, "スターオニオンズ危機一髪" }, { 41, "泥棒スターオニオンズ団" }, { 42, "カーディアンはトライマライの夢を見るか？" }, { 43, "ヤクソク" }, { 44, "壊れた世界" },
            { 45, "2人の世界" }, { 46, "3本の杖" }, { 47, "スーパードクターO" }, { 48, "クロウラーを狩る者" }, { 49, "売れ筋商品" },
            { 50, "闘魂伝" }, { 51, "双子石の絆" }, { 52, "病気のチョコボ" }, { 53, "特製シチュー" }, { 54, "仲良くしたい？" },
            { 55, "手ごたえは宝石" }, { 56, "NEWカーディアンくんの誕生" }, { 57, "正しいあいさつ" }, { 58, "伝説の大作戦" }, { 59, "NEWカーディアンさまの野望" },
            { 60, "星の涙" }, { 61, "牙もつもの" }, { 62, "一輪のお花さんがほしいにゃ" }, { 63, "3賢者" }, { 64, "思ひ出" },
            { 65, "星の大樹" }, { 66, "天晶堂へ集え" }, { 67, "アタルフォーネ盗賊団の宝" }, { 68, "侯国の栄光" }, { 69, "罪狩り" },
            { 70, "火の部族" }, { 71, "断ち切らん、その鎖を" }, { 72, "7色の光を！" }, { 73, "人形使い" }, { 74, "同窓の輪" },
            { 75, "誰そ彼そ" }, { 76, "月の導き" }, { 77, "若木" }, { 78, "口の院の悲劇" }, { 79, "血塗られた道" },
            { 80, "スカリーY" }, { 81, "仮面同盟" }, { 82, "プルゴノルゴ島の戦い" },
            { 90, "退魔の報酬～ウィンダス編" }, { 91, "護衛の報酬～ウィンダス編" }, { 92, "落とし主は誰だinウィンダス" }, { 93, "笑み曲ぐ夢魔と" }, { 94, "山猫のウィンク" },
            { 95, "ババン・ナ・ウェイレアのぼうけん" }, { 96, "新魔法フェイス（ウィンダス）" } };
        internal Dic QuestJn { get; } = new( 160 ) { { 0, "ダボイ村の紋章" }, { 1, "姉ちゃんを助けて" }, { 2, "デリケートな時計塔" }, { 3, "署名を集めろ" }, { 4, "傷ついたチョコボ" },
            { 05, "息子に罪はない" }, { 6, "亡き夫へのキャンドル" }, { 7, "ひみつ魔術セット" }, { 8, "やさしいカカシ" }, { 9, "マイ占い玉を作ろう！" },
            { 10, "タルットカード収集" }, { 11, "占い普及大作戦！" }, { 12, "古い歌碑" }, { 13, "自暴自棄の吟遊詩人" }, { 14, "ゴミのおつかい" },
            { 15, "なくしものはなんですか" }, { 16, "街燈ボランティア" }, { 17, "主婦のこだわり" }, { 18, "天晶堂入会" }, { 19, "カカシがいない" },
            { 20, "獣使いジョブゲット" }, { 21, "吟遊詩人ジョブゲット" }, { 22, "時計塔と青年" }, { 23, "キャンドルの原料" }, { 24, "子供との取引" },
            { 25, "北の地への導き" }, { 26, "アンチーク・コレクター" }, { 27, "天晶堂での取引" }, { 28, "ゴブリンのかばん1" }, { 29, "ゴブリンのかばん2" },
            { 30, "ゴブリンのかばん3" }, { 31, "ゴブリンのかばん4" }, { 32, "ゴブリンのかばん5" }, { 33, "ヨバクリのかばん1" }, { 34, "ヨバクリのかばん2" },
            { 35, "ヨバクリのかばん3" }, { 36, "ヨバクリのかばん4" }, { 37, "ゴウツバクリのかばん" }, { 38, "ベドーの謎その1" }, { 39, "ベドーの謎その2" },
            { 48, "腕におぼえあり！" }, { 49, "仕立て屋ゴブリン" },
            { 50, "キレイな石ころりんなのにゃ" }, { 51, "ボルグヘルツの失われた魔手＜戦士＞" }, { 52, "ボルグヘルツの失われた魔手＜モンク＞" }, { 53, "ボルグヘルツの失われた魔手＜白魔道士＞" }, { 54, "ボルグヘルツの失われた魔手＜黒魔道士＞" },
            { 55, "ボルグヘルツの失われた魔手＜赤魔道士＞" }, { 56, "ボルグヘルツの失われた魔手＜シーフ＞" }, { 57, "ボルグヘルツの失われた魔手＜ナイト＞" }, { 58, "ボルグヘルツの失われた魔手＜暗黒騎士＞" }, { 59, "ボルグヘルツの失われた魔手＜獣使い＞" },
            { 60, "ボルグヘルツの失われた魔手＜吟遊詩人＞" }, { 61, "ボルグヘルツの失われた魔手＜狩人＞" }, { 62, "ボルグヘルツの失われた魔手＜侍＞" }, { 63, "ボルグヘルツの失われた魔手＜忍者＞" }, { 64, "ボルグヘルツの失われた魔手＜竜騎士＞" },
            { 65, "ボルグヘルツの失われた魔手＜召喚士＞" }, { 66, "信じるは己の腕" }, { 67, "黄金の羽根を残して" }, { 68, "闇に散りしものたち" }, { 69, "新たなる朝" },
            { 70, "傷ついたもの" }, { 71, "誰がための鎮魂歌" }, { 72, "時の輪の交わる処" }, { 73, "君への忘れもの" }, { 74, "武に賭けた想い" },
            { 75, "謎の遺跡ソ・ジヤ" }, { 76, "故郷に錦を" }, { 77, "冤罪" }, { 78, "本当の愛を求めて" }, { 79, "消えた銀星号" },
            { 80, "虚ろなる記憶" }, { 81, "其の者の名は" }, { 82, "少女と鏡" }, { 83, "導かれるもの" }, { 84, "双対の力" },
            { 85, "冥闇" }, { 86, "天光" }, { 87, "伝える言葉" }, { 88, "カメレオンのまやかしを" }, { 89, "ふたりの想い" },
            { 90, "日輪を担いて" }, { 91, "心のシグナル" }, { 92, "亡者の影" }, { 93, "世界に在りて君は何を想うのか？" }, { 94, "山猫の招待" },
            { 95, "アトルガン皇国へ" }, { 96, "逃げだしたチョコボ" }, { 97, "プレリュード" }, { 98, "未完成の円舞（ワルツ）" }, { 99, "追想のポリフォニー" },
            { 100, "復活のステージ" }, { 101, "祝福のフィナーレ" }, { 102, "魔法人形「みとどけくん」" }, { 103, "竜虎相搏つ" }, { 104, "神器＜戦士＞" },
            { 105, "神器＜モンク＞" }, { 106, "神器＜白魔道士＞" }, { 107, "神器＜黒魔道士＞" }, { 108, "神器＜赤魔道士＞" }, { 109, "神器＜シーフ＞" },
            { 110, "神器＜ナイト＞" }, { 111, "神器＜暗黒騎士＞" }, { 112, "神器＜獣使い＞" }, { 113, "神器＜吟遊詩人＞" }, { 114, "神器＜狩人＞" },
            { 115, "神器＜侍＞" }, { 116, "神器＜忍者＞" }, { 117, "神器＜竜騎士＞" }, { 118, "神器＜召喚士＞" }, { 119, "神器＜青魔道士＞" },
            { 120, "神器＜コルセア＞" }, { 121, "神器＜からくり士＞" }, { 122, "神器＜踊り子＞" }, { 123, "神器＜学者＞" },
            { 128, "限界への挑戦" }, { 129, "すべての高い山に登れ" },
            { 130, "風の行方は" }, { 131, "天かける雲のごとく" }, { 132, "星の輝きを手に" }, { 133, "光とともにあれ" }, { 134, "人体強化の術！" },
            { 135, "続・人体強化の術！" }, { 136, "真・人体強化の術！" }, { 137, "東方の秘術！" }, { 138, "ある食客のメッセージ" }, { 139, "最後の試練！" },
            { 140, "捲土重来" }, { 141, "阿吽の試練・弐式" }, { 142, "阿吽の試練・参式" }, { 143, "阿吽の試練・肆式" }, { 144, "阿吽の試練・伍式" },
            { 146, "契約と覚悟、武の道程" }, { 147, "VW作戦第103計画バルクルム砂丘" }, { 148, "VW作戦第118計画ブブリム半島" }, { 149, "西の国からの調査団" },
            { 150, "中の国の磁場調査" }, { 151, "危険地帯の磁場調査" }, { 152, "ストレンジワープ" }, { 153, "磁場記録代行" }, { 154, "黄昏テレポート" },
            { 155, "錯綜メモリアル" }, { 156, "核熱エミネンス" }, { 157, "ライドオン！" }, { 158, "古代の飛翔機" } };
        internal Dic QuestFr { get; } = new( 220 ) { { 1, "火のなる木" }, { 2, "王への挨拶" }, { 3, "画廊の迷宮" }, { 4, "みんなで怨み" },
            { 06, "トンベリーニョ" }, { 7, "若きロテノーの悩み" }, { 8, "ああ！奇跡の出会い！" }, { 9, "おお！勇気ある決断！" },
            { 10, "温泉へ行こう" }, { 11, "オポオポ王への道" }, { 12, "不敗の心得" }, { 13, "落とし主は誰だinカザム" },
            { 29, "火の試練・改" }, { 30, "火の試練" },
            { 123, "ある刀鍛冶の依頼" }, { 124, "ブラックマーケット" },
            { 125, "大いなる力宿るモノ" }, { 126, "大自然の極上酒" }, { 127, "みんなのうらみ" }, { 128, "濡れた巻物の秘密" }, { 129, "サハギンの宝物庫" },
            { 130, "占拠された倉庫" }, { 131, "輝けるサブリガ" }, { 132, "輝けるレギンス" }, { 133, "神刀" }, { 134, "黄泉送り" },
            { 135, "先代の遺品" }, { 136, "海賊たちの20年" }, { 137, "想いを遺すために" }, { 138, "物に宿る魂" }, { 139, "内に眠る力" },
            { 140, "武技相伝" }, { 141, "誓いの連鎖" }, { 143, "水の試練・改" }, { 144, "水の試練" },
            { 154, "オポオポの怒り" }, { 155, "彷徨いし魂の鎮魂" }, { 156, "不浄なる魂の浄化" }, { 157, "神威" }, { 158, "神威" }, { 159, "1人でも開いちゃう？" },
            { 186, "砂漠の旅の必需品" }, { 187, "古代魔法の石版" }, { 188, "クフタル観光案内" }, { 189, "太公望は死なず" },
            { 190, "折れぬ魂" }, { 191, "勇魚" }, { 192, "夢追い旅" }, { 193, "黄金のたてがみ" }, { 194, "根気" },
            { 202, "風の試練・改" }, { 203, "風の試練" },
            { 214, "VW作戦の表裏" }, { 215, "VW作戦第250計画エルシモ島" }, { 216, "VW作戦第247計画ゼプウェル島" }, { 217, "VW作戦第121計画リ・テロア" }, { 218, "VW作戦第130計画トゥー・リア" } };
        internal Dic QuestAt { get; } = new( 110 ) { { 0, "はやくメモメモにゃ！" }, { 1, "ことばのパズル" }, { 2, "オルドゥーム" }, { 3, "恋のレシピ" }, { 4, "バラカフ回想録" },
            { 05, "渇望" }, { 6, "海鳥は賽を振る" }, { 7, "オートマトン" }, { 8, "弱点分析作戦" }, { 9, "始まりの夜" },
            { 10, "苦闘打開作戦" }, { 12, "シャララト日和" }, { 13, "にわか雨～君の面影を探して" }, { 14, "闇への抵抗II" },
            { 15, "Cook☆ルン" }, { 16, "その女、性悪につき" }, { 17, "双角の仕事人" }, { 18, "トトルンのトレジャーハント" }, { 19, "封滅トレージアンター" },
            { 20, "つるはしにかける思い" }, { 21, "開門" }, { 22, "兆候" }, { 23, "変容" }, { 24, "双翼は朝凪に舞う" },
            { 25, "白昼わだつみを駆る" }, { 26, "やがて海霧の夜に翔ぶ" }, { 27, "投げ込んだのは貴方じゃないですか" }, { 28, "キモいから名前で呼ぶな" }, { 29, "「何もできない」だなんて言わせない" },
            { 30, "再会の暁" }, { 31, "友情のカルテ" }, { 32, "バラカフ事件録" },
            { 40, "不滅" }, { 41, "海路の果てに" }, { 43, "天駆ける剣" }, { 44, "詠うは誰そ彼の" },
            { 45, "風纏う弓" }, { 46, "土噛みし拳" }, { 47, "水和ぐ盾" }, { 48, "炎熾す鎌" },
            { 60, "トリックスターの描く夢" }, { 61, "グルメな人々" }, { 62, "消えたカボチャ頭" }, { 63, "ふたりのバランス" }, { 64, "空知らぬ雨" },
            { 65, "主人と私" }, { 66, "愛あるがゆえに" }, { 67, "翠緑のむこうへ" }, { 68, "VW作戦第050計画西アトルガン地方" }, { 69, "VW作戦第068計画エジワ蘿洞" },
            { 70, "盗まれた皇宮の宝" }, { 71, "任務、任務……また任務！" }, { 72, "英魂と鎮魂" }, { 73, "アトルガンの秘宝" }, { 74, "アトルガンの守護者" },
            { 75, "白き神" }, { 76, "冥途の紋" }, { 77, "冥路の磁針" }, { 78, "修羅の道" },
            { 90, "昇進試験～一等傭兵" }, { 91, "昇進試験～上等傭兵" }, { 92, "昇進試験～傭兵長" }, { 93, "昇進試験～伍長" }, { 94, "昇進試験～軍曹" },
            { 95, "昇進試験～曹長" }, { 96, "昇進試験～特務曹長" }, { 97, "昇進試験～少尉" }, { 98, "昇進試験～中尉" }, { 99, "昇進試験～大尉" },
            { 101, "アシュタリフ号威力偵察" }, { 102, "宮廷絵師護衛指令" }, { 103, "アシュタリフ号船長暗殺指令" } };
        internal Dic QuestWg { get; } = new( 100 ) { { 0, "失われた地図" }, { 1, "追憶の風に抱かれて" }, { 2, "週刊！　ナイコパニィコ" }, { 3, "枯れずの太陽" }, { 4, "コッコちゃんと碧い石" },
            { 05, "ウィンダス食世界の夜明け" }, { 6, "魔道大典グリモア" }, { 7, "第四共和軍団入団試験" }, { 8, "コブラ傭兵団入団試験" }, { 9, "王立騎士団入団試験" },
            { 10, "赤と黒" }, { 11, "裏のある頼み" }, { 12, "沈黙の契約" }, { 13, "静かなる警鐘" }, { 14, "鍛冶の響き" },
            { 15, "少年たちの贈り物" }, { 16, "オーク軍団掃討作戦" }, { 17, "胎動、牙持つ乙女" }, { 18, "禍つ闇、襲来" }, { 19, "解明への灯" },
            { 20, "新たなる猜疑" }, { 21, "封邪の印" }, { 22, "女神像の守り手" }, { 23, "鎮魂の祈り" }, { 24, "巨人偵察作戦II（ツー）" },
            { 25, "ちいさな勝利、ひとつの決意" }, { 26, "失われた書" }, { 27, "憂国の使者" }, { 28, "降臨、異貌の徒" }, { 29, "漁師の錨" },
            { 30, "美女と野獣" }, { 31, "スウォーム！" }, { 32, "その名はシュルツII世" }, { 33, "暗転" }, { 34, "真紅のグリモア" },
            { 35, "騒乱の行方" }, { 36, "隠滅の炎" }, { 37, "羽撃け、鷲獅子" }, { 38, "それぞれの死地へ" }, { 39, "勃発、ミスラ大戦" },
            { 40, "淑女たちの饗宴" }, { 41, "手作りバッグ" }, { 42, "旋風、再び" }, { 43, "栄誉と背反" }, { 44, "名誉の代償" },
            { 45, "不帰の道程" }, { 46, "朔北の爪牙" }, { 47, "隠者と神獣と" }, { 48, "ジュエラーの涙" }, { 49, "向かうべき道" },
            { 50, "囚われし者" }, { 51, "不慮の援軍" }, { 52, "雪原を朱に染めて" }, { 53, "光の記憶" }, { 54, "星月、その姿は" },
            { 55, "とある契約" }, { 56, "乙女の祈り" }, { 57, "子と父" }, { 58, "潜みし影" }, { 59, "己の行く先に" },
            { 60, "影" }, { 61, "それぞれの未来へ" }, { 62, "壊乱、オズトロヤ城" }, { 63, "魂の果て" }, { 64, "彼女の想ひ出～帰郷" },
            { 65, "彼女の想ひ出～涙の豆料理" }, { 66, "彼女の想ひ出～彼と少女の事情" }, { 67, "彼女の想ひ出～墓前の決意" }, { 68, "彼女の想ひ出～キューピッド作戦" }, { 69, "彼女の想ひ出～紅の足跡" },
            { 70, "彼女の想ひ出～蒼の足跡" }, { 71, "彼女の想ひ出～翠の足跡" }, { 72, "彼女の想ひ出～不治の病" }, { 73, "暁よりの使者、再び" }, { 74, "暁に燃ゆる拳" }, { 75, "禁断の再会" },
            { 80, "彼方よりの使者" }, { 81, "ジュノ招集" }, { 82, "新たな作戦領域" }, { 83, "VW作戦第126計画クフィム島" },
            { 84, "ケット・シーの導き" }, { 85, "真相見えぬ戦い" }, { 86, "ジュノ招集、再び" }, { 87, "新たなる脅威" }, { 88, "しばしの休息" }, { 89, "震える世界" },
            { 90, "前虎後狼" }, { 91, "消失、そして……" }, { 92, "三度の招集" }, { 93, "白水晶の輝き" }, { 94, "未知なる領域への侵入" },
            { 95, "真界" }, { 96, "水晶の龍" }, { 97, "物語の終わりと始まり" }, { 98, "世界の理" } };
        internal Dic QuestAb { get; } = new( 200 ) { { 0, "食料調達" }, { 1, "陽光の恩恵" }, { 2, "闇への抵抗III" }, { 3, "隻眼の代償" }, { 4, "折れない心" },
            { 05, "爆薬実験" }, { 6, "リサイクラー" }, { 7, "ライフライン" }, { 8, "音信不通" }, { 9, "失われし記憶" },
            { 10, "アビセアに芽吹く運命" }, { 11, "絶望の野に咲く花" }, { 12, "壊れた絆、つながる思い" }, { 13, "アビセアの錬金術師" }, { 14, "5人の戦士" },
            { 15, "買い取りなら天晶堂2" }, { 16, "物資来たらず" }, { 17, "ライブラコレクション" }, { 18, "エース失踪" }, { 19, "アビセアの鷹" },
            { 20, "星の木の実回収" }, { 21, "職人魂" }, { 22, "オブストラクション" }, { 23, "飢えに備えて" }, { 24, "道を切り開け！" },
            { 25, "新種確保！？" }, { 26, "熱病の子を救って" }, { 27, "そこにある絆" }, { 28, "カーディアン点検" }, { 29, "無へ誘う使者" },
            { 30, "シアリングワード耐久テスト" }, { 31, "最前線に待ったなし" }, { 32, "ビッグブリッヂの修繕" }, { 33, "盗聴パール最前線" }, { 34, "心配事" },
            { 35, "水質汚染調査" }, { 36, "水質汚染調査II" }, { 37, "髭に宿る力" }, { 38, "ブンカールに蒔かれた貝殻" }, { 39, "前哨基地に向かえ！" },
            { 40, "てんでばらばらな調査隊" }, { 41, "チョコボの焦心苦慮" }, { 42, "キジの代わりに" }, { 43, "天晶堂での取引II" }, { 44, "大気汚染の調査" },
            { 45, "ヨランオランの秘策" }, { 46, "大地からの噴煙" }, { 47, "主婦のこだわりII" }, { 48, "孤立小隊捜索" }, { 49, "一輪の花" },
            { 50, "弔い" }, { 51, "未知の素材の研究" }, { 52, "落とした料理書" }, { 53, "スモークオンザミザレオ" }, { 54, "ジーグリンデの研究" },
            { 55, "ミッシングボム" }, { 56, "メディカルアラート" }, { 57, "冥界からの呼び声" }, { 58, "失われし生物の回帰" }, { 59, "新薬を試して" },
            { 60, "チョコボの異変" }, { 61, "だいじなだいじな卵" }, { 62, "ラッキー占い" }, { 63, "ある娘の使命" }, { 64, "ナツカシイ★オモカゲ" },
            { 65, "カエラナイ★ゴシュジンサマ" }, { 66, "コロロの心配" }, { 67, "雪山の灯" }, { 68, "雪の波に乗って" }, { 69, "モグハウスがなくても負けないクポ" },
            { 70, "某国の偵察任務" }, { 71, "某国の偵察任務II" }, { 72, "雪原に咲く花" }, { 73, "拳を故郷に" }, { 74, "偵察の報酬" },
            { 75, "捲土重来を期す" }, { 76, "邁進！滑落！千人落しの崖！！" }, { 77, "紅き空の学び舎" }, { 78, "隠し味を探せ！" }, { 79, "工兵隊任務補佐" },
            { 80, "支給品配達" }, { 81, "医療隊レポート回収" }, { 82, "月に祈りを" }, { 83, "白夜に見る夢" }, { 84, "しるべなき墓標" },
            { 85, "獅子なる証" }, { 86, "ブリジッドのファッションチェックIII" }, { 87, "ドミニオンオプスNo.1～アルテパ編" }, { 88, "ドミニオンオプスNo.2～アルテパ編" }, { 89, "ドミニオンオプスNo.3～アルテパ編" },
            { 90, "ドミニオンオプスNo.4～アルテパ編" }, { 91, "ドミニオンオプスNo.5～アルテパ編" }, { 92, "ドミニオンオプスNo.6～アルテパ編" }, { 93, "ドミニオンオプスNo.7～アルテパ編" }, { 94, "ドミニオンオプスNo.8～アルテパ編" },
            { 95, "ドミニオンオプスNo.9～アルテパ編" }, { 96, "ドミニオンオプスNo.10～アルテパ編" }, { 97, "ドミニオンオプスNo.11～アルテパ編" }, { 98, "ドミニオンオプスNo.12～アルテパ編" }, { 99, "ドミニオンオプスNo.13～アルテパ編" },
            { 100, "ドミニオンオプスNo.14～アルテパ編" }, { 101, "ドミニオンオプスNo.1～ウルガラン編" }, { 102, "ドミニオンオプスNo.2～ウルガラン編" }, { 103, "ドミニオンオプスNo.3～ウルガラン編" }, { 104, "ドミニオンオプスNo.4～ウルガラン編" },
            { 105, "ドミニオンオプスNo.5～ウルガラン編" }, { 106, "ドミニオンオプスNo.6～ウルガラン編" }, { 107, "ドミニオンオプスNo.7～ウルガラン編" }, { 108, "ドミニオンオプスNo.8～ウルガラン編" }, { 109, "ドミニオンオプスNo.9～ウルガラン編" },
            { 110, "ドミニオンオプスNo.10～ウルガラン編" }, { 111, "ドミニオンオプスNo.11～ウルガラン編" }, { 112, "ドミニオンオプスNo.12～ウルガラン編" }, { 113, "ドミニオンオプスNo.13～ウルガラン編" }, { 114, "ドミニオンオプスNo.14～ウルガラン編" },
            { 115, "ドミニオンオプスNo.1～グロウベルグ編" }, { 116, "ドミニオンオプスNo.2～グロウベルグ編" }, { 117, "ドミニオンオプスNo.3～グロウベルグ編" }, { 118, "ドミニオンオプスNo.4～グロウベルグ編" }, { 119, "ドミニオンオプスNo.5～グロウベルグ編" },
            { 120, "ドミニオンオプスNo.6～グロウベルグ編" }, { 121, "ドミニオンオプスNo.7～グロウベルグ編" }, { 122, "ドミニオンオプスNo.8～グロウベルグ編" }, { 123, "ドミニオンオプスNo.9～グロウベルグ編" }, { 124, "ドミニオンオプスNo.10～グロウベルグ編" },
            { 125, "ドミニオンオプスNo.11～グロウベルグ編" }, { 126, "ドミニオンオプスNo.12～グロウベルグ編" }, { 127, "ドミニオンオプスNo.13～グロウベルグ編" }, { 128, "ドミニオンオプスNo.14～グロウベルグ編" }, { 129, "防壁修復資材運搬任務I～アットワ編" },
            { 130, "防壁修復資材運搬任務I～ミザレオ編" }, { 131, "防壁修復資材運搬任務I～ブンカール編" }, { 132, "防壁修復資材運搬任務II～アットワ編" }, { 133, "防壁修復資材運搬任務II～ミザレオ編" }, { 134, "防壁修復資材運搬任務II～ブンカール編" },
            { 135, "兵装運搬任務I～アットワ編" }, { 136, "兵装運搬任務I～ミザレオ編" }, { 137, "兵装運搬任務I～ブンカール編" }, { 138, "兵装運搬任務II～アットワ編" }, { 139, "兵装運搬任務II～ミザレオ編" },
            { 140, "兵装運搬任務II～ブンカール編" }, { 141, "トラップ強化任務I～アットワ編" }, { 142, "トラップ強化任務I～ミザレオ編" }, { 143, "トラップ強化任務I～ブンカール編" }, { 144, "トラップ強化任務II～アットワ編" },
            { 145, "トラップ強化任務II～ミザレオ編" }, { 146, "トラップ強化任務II～ブンカール編" }, { 147, "補給活動～ラテーヌ編" }, { 148, "補給活動～コンシュタット編" }, { 149, "補給活動～タロンギ編" },
            { 150, "補給活動～アットワ編" }, { 151, "補給活動～ミザレオ編" }, { 152, "補給活動～ブンカール編" }, { 153, "補給活動～アルテパ編" }, { 154, "補給活動～ウルガラン編" },
            { 155, "補給活動～グロウベルグ編" }, { 156, "保守点検活動～ラテーヌ編" }, { 157, "保守点検活動～コンシュタット編" }, { 158, "保守点検活動～タロンギ編" }, { 159, "保守点検活動～アットワ編" },
            { 160, "保守点検活動～ミザレオ編" }, { 161, "保守点検活動～ブンカール編" }, { 162, "保守点検活動～アルテパ編" }, { 163, "保守点検活動～ウルガラン編" }, { 164, "保守点検活動～グロウベルグ編" },
            { 165, "すべてのはじまり" }, { 166, "導きの鍵" }, { 167, "終焉の来訪者" }, { 168, "第一接触" }, { 169, "異界の抵抗軍" },
            { 170, "狂った世界" }, { 171, "綻びた世界" }, { 172, "アビセアの英雄" }, { 173, "聖地への誘い" }, { 174, "世界創生" },
            { 175, "神のみ座と御使い" }, { 176, "紅き空、蒼き月、神の都" }, { 177, "神竜" }, { 178, "世界に在りて……" }, { 179, "少女との約束" },
            { 180, "黄金兜の大巨人" }, { 181, "猛毒の大蜥蜴" }, { 182, "伝承の大蚯蚓" }, { 183, "禁断の地アビセア" }, { 184, "バストアの大海獣" },
            { 185, "魅惑の大提灯" }, { 186, "渇きの煉獄蝶" }, { 187, "アビセアの死闘" }, { 188, "砂漠舞う風獣" }, { 189, "雪原の吸血虫" },
            { 190, "毒吹く巻き貝" }, { 191, "アビセアの覇者" } };
        internal Dic QuestAd { get; } = new( 100 ) { { 0, "とあるトウィザリムの生態" }, { 1, "森の死神" }, { 2, "生まれ出ずる悩み" }, { 3, "過酷な潮干狩り" }, { 4, "チャプリ駆除" },
            { 05, "マグマ調査" }, { 6, "紫に染まる大河" }, { 7, "清浄な砂浜" }, { 8, "氷の衣を纏った木々" }, { 9, "湯けむり泉質調査旅" },
            { 10, "じじいへの差し入れ" }, { 11, "遠い友達" }, { 12, "開拓業務のコツ伝授" }, { 13, "憧れの開拓者" }, { 14, "おつかいやるのん？" },
            { 15, "西アドゥリンのウェイポイント" }, { 16, "東アドゥリンのウェイポイント" }, { 17, "大木粉砕の心得" }, { 18, "河の流れを読む極意" }, { 19, "大岩破壊の極意" },
            { 20, "ツタ登りの極意" }, { 21, "息をひそめて蜂を待つ" }, { 22, "珍味求めて幾年月" }, { 23, "混浴温泉の心得" }, { 24, "這い寄るトゲトゲ" },
            { 25, "氷壁破壊の極意" }, { 26, "魔力断絶の学識" }, { 27, "運命と愛の流刑地" }, { 28, "いたいけなモンスター" }, { 29, "眠れる果実" },
            { 30, "深淵の森" }, { 31, "興醒めの騒動" }, { 32, "自慢の料理" }, { 33, "開拓支援の不思議な力" }, { 34, "腹が減っては仕事ができぬ" },
            { 35, "商売道具と人助け" }, { 36, "とある衛兵の巡回業務" }, { 37, "闇への抵抗IV" }, { 38, "怪しい届け物" }, { 39, "腹が減ったはただの建前" },
            { 40, "野菜と成長促進剤" }, { 41, "ただの食いしん坊のごとく" }, { 42, "メグちゃんの病気" }, { 43, "心臓破りの巡回業務" }, { 44, "這い寄る混沌" },
            { 45, "カフェマスターのお願い" }, { 46, "感染する混沌" }, { 47, "時計仕掛けのララ水道" }, { 48, "あるチーフマネージャーの笑害" }, { 49, "あるチーフマネージャーの笑壁" },
            { 50, "あるチーフマネージャーの笑撃" }, { 51, "あるお笑いパフォーマーの笑止" }, { 52, "ベジタブルレボリューション" }, { 53, "ベジタブルエボリューション" }, { 54, "ベジタブルカリカリクライシス" },
            { 55, "ベジタブルカリカリセンセーション" }, { 56, "渇く男" }, { 57, "更に渇く男" }, { 58, "渇欲のストロボ" }, { 59, "幻世の渇愛" },
            { 60, "風水学入門" }, { 61, "残された時間" }, { 62, "鈴は鳴りわたる" }, { 63, "ザカライアの一族" }, { 64, "言霊" },
            { 65, "大地の忘れ形見" }, { 66, "鈴の音色は儚く遠く" }, { 67, "ルーンを識る者" }, { 68, "エンデヴァー＜理の覚醒＞" }, { 69, "フォージング＜導きの剣＞" },
            { 70, "レガシー＜継ぐ識力＞" }, { 71, "プリオーデイン＜天命の匣＞" }, { 72, "エピファニー＜真意＞" }, { 73, "クイエセンス＜裏式＞" }, { 74, "よすが人" },
            { 75, "森の帳に潜む罠" }, { 76, "幻の果実水" }, { 77, "私怨" }, { 78, "渓谷を下る水" }, { 79, "穢れた土地" },
            { 80, "ヨルシアに群れる花" }, { 81, "快気の光" }, { 82, "密会" }, { 83, "淀み" }, { 84, "悪人か善人か" },
            { 85, "成功の秘訣" }, { 86, "侵食" }, { 87, "古の棍" }, { 88, "先の剣" }, { 89, "解離" },
            { 90, "輝く瞳" }, { 91, "メルヴィアン殺人事件" }, { 92, "無慈悲な冷気" }, { 93, "イングリッドの儀式" }, { 94, "彼の日の軌跡" },
            { 95, "栄えある称号は" }, { 96, "蝶なる聖戦" }, { 97, "静かなる森" }, { 98, "悠久の風" } };
        internal Dic QuestWk { get; } = new( 100 ) { { 0, "資材調達:ケイザック古戦場" }, { 1, "資材調達:エヌティエル水林" }, { 2, "資材調達:モリマー台地" }, { 3, "資材調達:ヨルシア森林" }, { 4, "資材調達:マリアミ渓谷" },
            { 05, "資材調達:カミール山麓" }, { 6, "資材調達:シルダス洞窟" }, { 7, "資材調達:ラ・カザナル宮外郭" }, { 8, "進路確保:ケイザック古戦場" }, { 9, "進路確保:エヌティエル水林" },
            { 10, "進路確保:モリマー台地" }, { 11, "進路確保:ヨルシア森林" }, { 12, "進路確保:マリアミ渓谷" }, { 13, "進路確保:カミール山麓" }, { 14, "進路確保:シルダス洞窟" },
            { 15, "進路確保:ラ・カザナル宮外郭" }, { 16, "治安維持:ケイザック古戦場" }, { 17, "治安維持:ヤッセの狩り場" }, { 18, "治安維持:エヌティエル水林" }, { 19, "治安維持:モリマー台地" },
            { 20, "治安維持:ヨルシア森林" }, { 21, "治安維持:マリアミ渓谷" }, { 22, "治安維持:カミール山麓" }, { 23, "治安維持:シルダス洞窟" }, { 24, "治安維持:ラ・カザナル宮外郭" },
            { 25, "巡回警備:ララ水道" }, { 26, "巡回警備:シィの門" }, { 27, "巡回警備:モーの門" }, { 28, "巡回警備:シルダス洞窟" }, { 29, "巡回警備:ドーの門" },
            { 30, "巡回警備:ウォーの門" }, { 31, "巡回警備:ラ・カザナル宮外郭" }, { 32, "拠点物資:エヌティエル水林" }, { 33, "拠点物資:モリマー台地" }, { 34, "拠点物資:ヨルシア森林" },
            { 35, "拠点物資:マリアミ渓谷" }, { 36, "拠点物資:カミール山麓" }, { 37, "資材宅配:エヌティエル水林" }, { 38, "資材宅配:モリマー台地" }, { 39, "資材宅配:ヨルシア森林" },
            { 40, "資材宅配:マリアミ渓谷" }, { 41, "資材宅配:カミール山麓" }, { 42, "戦線物資:ケイザック古戦場" }, { 43, "戦線物資:エヌティエル水林" }, { 44, "戦線物資:モリマー台地" },
            { 45, "戦線物資:ヨルシア森林" }, { 46, "戦線物資:マリアミ渓谷" }, { 47, "戦線物資:カミール山麓" }, { 48, "地脈調査:ケイザック古戦場" }, { 49, "地脈調査:エヌティエル水林" },
            { 50, "地脈調査:モリマー台地" }, { 51, "地脈調査:ヨルシア森林" }, { 52, "地脈調査:マリアミ渓谷" }, { 53, "地脈調査:カミール山麓" }, { 54, "地脈調査:シィの門" },
            { 55, "地脈調査:シルダス洞窟" }, { 56, "地脈調査:ドーの門" }, { 57, "素材探究:エヌティエル水林" }, { 58, "素材探究:モリマー台地" }, { 59, "素材探究:ヨルシア森林" },
            { 60, "素材探究:マリアミ渓谷" }, { 61, "素材探究:カミール山麓" }, { 62, "素材探究:シルダス洞窟" }, { 63, "素材探究:ラ・カザナル宮外郭" }, { 64, "素材調達:ララ水道" },
            { 65, "素材調達:ケイザック古戦場" }, { 66, "素材調達:ヤッセの狩り場" }, { 67, "素材調達:エヌティエル水林" }, { 68, "素材調達:モリマー台地" }, { 69, "素材調達:ヨルシア森林" },
            { 70, "素材調達:マリアミ渓谷" }, { 71, "素材調達:カミール山麓" }, { 72, "素材調達:シィの門" }, { 73, "素材調達:モーの門" }, { 74, "素材調達:シルダス洞窟" },
            { 75, "素材調達:ドーの門" }, { 76, "素材調達:ウォーの門" }, { 77, "素材調達:ラ・カザナル宮外郭" }, { 78, "素材調達:ラ・カザナル宮内郭" },
            { 80, "物品捜索:ケイザック古戦場" }, { 81, "物品捜索:エヌティエル水林" }, { 82, "物品捜索:モリマー台地" }, { 83, "物品捜索:ヨルシア森林" }, { 84, "物品捜索:マリアミ渓谷" },
            { 85, "物品捜索:カミール山麓" }, { 86, "生態研究:ララ水道" }, { 87, "生態研究:ケイザック古戦場" }, { 88, "生態研究:エヌティエル水林" }, { 89, "生態研究:モリマー台地" },
            { 90, "生態研究:ヨルシア森林" }, { 91, "生態研究:マリアミ渓谷" }, { 92, "生態研究:カミール山麓" }, { 93, "開拓応援:エヌティエル水林" }, { 94, "開拓応援:マリアミ渓谷" }, { 95, "開拓応援:カミール山麓" } };
        #endregion
        #region チュートリアル
        internal Dic EmiTutorialBasics { get; } = new( 15 ) { { 0, "始まりの軌跡" }, { 1, "繋がりの軌跡" }, { 2, "FoVの自主訓練を受ける" }, { 3, "ヒーリングで回復する" }, { 4, "モンスターを1匹倒す" },
            { 05, "GoVの自主訓練を受ける" }, { 6, "はじめてのアンバスケード" }, { 7, "フェイスを呼び出す" }, { 8, "フェイス：ヴァレンラール" }, { 9, "フェイス：ミリ・アリアポー" },
            { 10, "フェイス：テンゼン" }, { 11, "フェイス：アーデルハイト" }, { 12, "フェイス：ヨアヒム" }, { 13, "A.M.A.N. トローブってなぁに？" }, { 14, "アシストチャンネル" } };
        internal Dic EmiTutorialIntermediate { get; } = new( 16 ) {
            { 00, "メインジョブのレベルを99にする" }, { 1, "エミネンスポイントを貯める" }, { 2, "エミネンスポイントを貯める2" }, { 3, "エミネンスポイントを貯める3" }, { 4, "アイテムレベルを117にする" },
            { 05, "ワイルドキーパー・レイヴ" }, { 6, $"戦闘:スカーム-{RalaWaterwaysU}" }, { 7, $"戦闘:スカーム-{CirdasCavernsU}" }, { 8, $"戦闘:スカーム-{YorciaWealdU}" }, { 9, "アンバスケードをクリアする" },
            { 10, "アーティファクトを強化" }, { 11, "アーティファクトを強化2" }, { 12, $"戦闘:A・スカーム-{RalaWaterwaysU}" }, { 13, $"戦闘:A・スカーム-{CirdasCavernsU}" }, { 14, $"A・スカーム-{YorciaWealdU}" }, { 15, "メンターライセンス" } };
        internal Dic EmiTutorialSynthesis { get; } = new( 16 ) { { 0, $"木工{gimt}" }, { 1, $"鍛冶{gimt}" }, { 2, $"彫金{gimt}" }, { 3, $"織工{gimt}" }, { 4, $"革工{gimt}" },
            { 5, $"骨工{gimt}" }, { 6, $"錬金術{gimt}" }, { 7, $"調理{gimt}" }, { 8, "木工：化粧箱" }, { 9, "鍛冶：ブロンズナイフ" }, { 10, "彫金：カッパーリング" },
            { 11, "裁縫：ヘッドギア" }, { 12, "革細工：レザーバンダナ" }, { 13, "骨細工：胡粉" }, { 14, "錬金術：黒インク" }, { 15, "調理：石のスープ" } };
        internal Dic EmiTutorialQuests1 { get; } = new( 26 ) { { 0, $"{mogh}サンドリア" }, { 1, $"{mogh}バストゥーク" }, { 2, $"{mogh}ウィンダス" }, { 3, $"{mogh}ジュノ" }, { 4, $"{mogh}アトルガン" },
            { 05, $"サポート{jobg}" }, { 6, "フェイス取得：サンドリア" }, { 7, "フェイス取得：バストゥーク" }, { 8, "フェイス取得：ウィンダス" }, { 9, "チョコボ乗り免許証取得" },
            { 10, $"{PLD}{jobg}" }, { 11, $"{DRK}{jobg}" }, { 12, $"{BST}{jobg}" }, { 13, $"{BRD}{jobg}" }, { 14, $"{RNG}{jobg}" },
            { 15, $"{SAM}{jobg}" }, { 16, $"{NIN}{jobg}" }, { 17, $"{DRG}{jobg}" }, { 18, $"{SMN}{jobg}" }, { 19, $"{BLU}{jobg}" },
            { 20, $"{COR}{jobg}" }, { 21, $"{PUP}{jobg}" }, { 22, $"{DNC}{jobg}" }, { 23, $"{SCH}{jobg}" }, { 24, $"{GEO}{jobg}" }, { 25, $"{RUN}{jobg}" } };
        internal Dic EmiTutorialArtifact { get; } = new( 66 ) { { 0, $"{WAR}{af}1" }, { 1, $"{WAR}{af}2" }, { 2, $"{WAR}{af}3" }, { 3, $"{MNK}{af}1" }, { 4, $"{MNK}{af}2" }, { 5, $"{MNK}{af}3" },
            { 06, $"{WHM}{af}1" }, { 7, $"{WHM}{af}2" }, { 8, $"{WHM}{af}3" }, { 9, $"{BLM}{af}1" }, { 10, $"{BLM}{af}2" }, { 11, $"{BLM}{af}3" },
            { 12, $"{RDM}{af}1" }, { 13, $"{RDM}{af}2" }, { 14, $"{RDM}{af}3" }, { 15, $"{THF}{af}1" }, { 16, $"{THF}{af}2" }, { 17, $"{THF}{af}3" },
            { 18, $"{PLD}{af}1" }, { 19, $"{PLD}{af}2" }, { 20, $"{PLD}{af}3" }, { 21, $"{DRK}{af}1" }, { 22, $"{DRK}{af}2" }, { 23, $"{DRK}{af}3" },
            { 24, $"{BST}{af}1" }, { 25, $"{BST}{af}2" }, { 26, $"{BST}{af}3" }, { 27, $"{BRD}{af}1" }, { 28, $"{BRD}{af}2" }, { 29, $"{BRD}{af}3" },
            { 30, $"{RNG}{af}1" }, { 31, $"{RNG}{af}2" }, { 32, $"{RNG}{af}3" }, { 33, $"{SAM}{af}1" }, { 34, $"{SAM}{af}2" }, { 35, $"{SAM}{af}3" },
            { 36, $"{NIN}{af}1" }, { 37, $"{NIN}{af}2" }, { 38, $"{NIN}{af}3" }, { 39, $"{DRG}{af}1" }, { 40, $"{DRG}{af}2" }, { 41, $"{DRG}{af}3" },
            { 42, $"{SMN}{af}1" }, { 43, $"{SMN}{af}2" }, { 44, $"{SMN}{af}3" }, { 45, $"{BLU}{af}1" }, { 46, $"{BLU}{af}2" }, { 47, $"{BLU}{af}3" },
            { 48, $"{COR}{af}1" }, { 49, $"{COR}{af}2" }, { 50, $"{COR}{af}3" }, { 51, $"{PUP}{af}1" }, { 52, $"{PUP}{af}2" }, { 53, $"{PUP}{af}3" },
            { 54, $"{DNC}{af}1" }, { 55, $"{DNC}{af}2" }, { 56, $"{DNC}{af}3" }, { 57, $"{SCH}{af}1" }, { 58, $"{SCH}{af}2" }, { 59, $"{SCH}{af}3" },
            { 60, $"{GEO}{af}1" }, { 61, $"{GEO}{af}2" }, { 62, $"{GEO}{af}3" }, { 63, $"{RUN}{af}1" }, { 64, $"{RUN}{af}2" }, { 65, $"{RUN}{af}3" } };
        internal Dic EmiTutorialLvlcap { get; } = new( 17 ) { { 0, $"{cap}55" }, { 1, $"{cap}60" }, { 2, $"{cap}65" }, { 3, $"{cap}70" }, { 4, $"{cap}75" },
            { 05, $"{cap}80" }, { 6, $"{cap}85" }, { 7, $"{cap}90" }, { 8, $"{cap}95" }, { 9, $"{cap}99" },
            { 10, $"{cap}75({BLU})" }, { 11, $"{cap}75({COR})" }, { 12, $"{cap}75({PUP})" }, { 13, $"{cap}75({DNC})" }, { 14, $"{cap}75({SCH})" },
            { 15, $"{cap}75({GEO})" }, { 16, $"{cap}75({RUN})" } };
        internal Dic EmiTutorialStorage { get; } = new( 13 ) { { 0, $"{exbg}35" }, { 1, $"{exbg}40" }, { 2, $"{exbg}45" }, { 3, $"{exbg}50" }, { 4, $"{exbg}55" },
            { 05, $"{exbg}60" }, { 6, $"{exbg}65" }, { 7, $"{exbg}70" }, { 8, $"{exbg}75" }, { 9, $"{exbg}80" },
            { 10, $"{exmb}60" }, { 11, $"{exmb}70" }, { 12, $"{exmb}80" } };
        internal Dic EmiTutorialWS { get; } = new( 14 ) { { 0, "夢想阿修羅拳" }, { 1, "エヴィサレーション" }, { 2, "サベッジブレード" }, { 3, "グラウンドストライク" }, { 4, "デシメーション" },
            { 05, "スチールサイクロン" }, { 6, "スパイラルヘル" }, { 7, "インパルスドライヴ" }, { 8, "空" }, { 9, "九之太刀・花車" },
            { 10, "ブラックヘイロー" }, { 11, "レトリビューション" }, { 12, "エンピリアルアロー" }, { 13, "デトネーター" } };
        #endregion
        #region 戦闘：広域
        internal Dic EmiCombatGeneral { get; } = new( 26 ) {
            { 0, "モンスター討伐数合計" }, { 1, "モンスター討伐数合計2" }, { 2, "モンスター討伐数合計3" }, { 3, "レベルシンク中討伐数" }, { 4, "レベルシンク中討伐数2" },
            { 5, "500以上ダメージ" }, { 6, "1000以上ダメージ" }, { 7, "1500以上ダメージ" }, { 8, "2000以上ダメージ" },
            { 9, "10～20ダメージ" }, { 10, "110～120ダメージ" }, { 11, "310～320ダメージ" }, { 12, "510～520ダメージ" }, { 13, "1110～1120ダメージ" },
            { 14, "ダメージ合計" }, { 15, "ダメージ合計2" }, { 16, "ダメージ合計3" }, { 17, "回復量合計" }, { 18, "回復量合計2" }, { 19, "回復量合計3" },
            { 20, "被ダメージ合計" }, { 21, "被ダメージ合計2" }, { 22, "被ダメージ合計3" }, { 23, "ウェポンスキル使用回数" }, { 24, "500以上回復" }, { 25, "750以上回復" } };
        internal Dic EmiCombatSpoils { get; } = new( 51 ) {
            { 00, "炎のクリスタル" }, { 1, "氷のクリスタル" }, { 2, "風のクリスタル" }, { 3, "土のクリスタル" }, { 4, "雷のクリスタル" }, { 5, "水のクリスタル" }, { 6, "光のクリスタル" }, { 7, "闇のクリスタル" },
            { 08, "炎の石印" }, { 9, "氷の石印" }, { 10, "風の石印" }, { 11, "土の石印" }, { 12, "雷の石印" }, { 13, "水の石印" }, { 14, "光の石印" }, { 15, "闇の石印" },
            { 16, "炎将の赤石" }, { 17, "女王の透石" }, { 18, "鳥王の翠石" }, { 19, "巨人の黄石" }, { 20, "隠者の紫石" }, { 21, "海蛇の藍石" }, { 22, "七色の白石" }, { 23, "星月の黒石" },
            { 30, "コウモリの翼" }, { 31, "黒虎の牙" }, { 32, "火打石" }, { 33, "野兎の毛皮" }, { 34, "蜂蜜" }, { 35, "大羊の毛皮" }, { 36, "トカゲの皮" }, { 37, "甲虫の甲殻" }, { 38, "ツェールンの煤" },
            { 39, "銀の認識票" }, { 40, "クゥダフヘルム" }, { 41, "トレントの球根" }, { 42, "ワイルドオニオン" }, { 43, "ネムリタケ" }, { 44, "砂コウモリの牙" }, { 45, "亜鉛鉱" }, { 46, "大鳥の羽根" }, { 47, "マンドラゴラの三葉" },
            { 48, "マンドラゴラの四葉" }, { 49, "コルネット" }, { 50, "ユタンガの硫黄" }, { 51, "偉そうな手紙" }, { 52, "ヤグードの数珠" }, { 53, "マヨイタケ" }, { 54, "蜂の巣のかけら" }, { 55, "レミ貝の殻" }, { 56, "双子石のピアス" } };
        #endregion
        #region 戦闘：エリア別
        internal Dic EmiCombatOriginalArea { get; } = new( 99 ) { { 0, $"{se}{WestRonfaure}" }, { 1, $"{to}Jaggedy-Eared Jack" }, { 2, $"{se}{EastRonfaure}" }, { 3, $"{to}Swamfisk" },
            { 04, $"{se}{GhelsbaOutpost}" }, { 5, $"{to}Thousandarm Deshglesh" }, { 6, $"{se}{FortGhelsba}" }, { 7, $"{to}Hundredscar Hajwaj" },
            { 08, $"{se}{YughottGrotto}" }, { 9, $"{to}Ashmaker Gotblut" }, { 10, $"{se}{KingRanperresTomb}" }, { 11, $"{to}Barbastelle" },
            { 12, $"{se}{BostaunieuxOubliette}" }, { 13, $"{to}Bloodsucker" }, { 14, $"{se}{ValkurmDunes}" }, { 15, $"{to}Valkurm Emperor" },
            { 16, $"{se}{KonschtatHighlands}" }, { 17, $"{to}Bendigeit Vran" }, { 18, $"{se}{GusgenMines}" }, { 19, $"{to}Juggler Hecatomb" },
            { 20, $"{se}{LaTheinePlateau}" }, { 21, $"{to}Bloodtear Baldurf" }, { 22, $"{se}{OrdellesCaves}" }, { 23, $"{to}Morbolger" },
            { 30, $"{se}{JugnerForest}" }, { 31, $"{to}King Arthro" }, { 32, $"{se}{BatalliaDowns}" }, { 33, $"{to}Lumber Jack" }, { 34, $"{se}{EldiemeNecropolis}" },
            { 35, $"{to}Cwn Cyrff" }, { 36, $"{se}{Davoi}" }, { 37, $"{to}Hawkeyed Dnatbat" }, { 38, $"{se}{NorthGustaberg}" }, { 39, $"{to}Maighdean Uaine" },
            { 40, $"{se}{SouthGustaberg}" }, { 41, $"{to}Carnero" }, { 42, $"{se}{ZeruhnMines}" }, { 43, $"{se}{PalboroughMines}" }, { 44, $"{to}Zi'Ghi Boneeater" },
            { 45, $"{se}{DangrufWadi}" }, { 46, $"{to}Teporingo" }, { 47, $"{se}{PashhowMarshlands}" }, { 48, $"{to}Ni'Zho Bladebender" }, { 49, $"{se}{RolanberryFields}" },
            { 50, $"{to}Simurgh" }, { 51, $"{se}{CrawlersNest}" }, { 52, $"{to}Demonic Tiphia" }, { 53, $"{se}{Beadeaux}" }, { 54, $"{to}Zo'Khu Blackcloud" },
            { 60, $"{se}{WestSarutabaruta}" }, { 61, $"{to}Nunyenunc" }, { 62, $"{se}{EastSarutabaruta}" }, { 63, $"{to}Spiny Spipi" }, { 64, $"{se}{Giddeus}" },
            { 65, $"{to}Hoo Mjuu the Torrent" }, { 66, $"{se}{ToraimaraiCanal}" }, { 67, $"{to}Oni Carcass" }, { 68, $"{se}{InnerHorutotoRuins}" }, { 69, $"{to}Maltha" },
            { 70, $"{se}{OuterHorutotoRuins}" }, { 71, $"{to}Bomb King" }, { 72, $"{se}{BuburimuPeninsula}" }, { 73, $"{to}Helldiver" }, { 74, $"{se}{TahrongiCanyon}" },
            { 75, $"{to}Serpopard Ishtar" }, { 76, $"{se}{MazeOfShakhrami}" }, { 77, $"{to}Argus" }, { 78, $"{se}{MeriphataudMountains}" }, { 79, $"{to}Daggerclaw Dracos" },
            { 80, $"{se}{SauromugueChampaign}" }, { 81, $"{to}Roc" }, { 82, $"{se}{GarlaigeCitadel}" }, { 83, $"{to}Serket" }, { 84, $"{se}{CastleOztroja}" }, { 85, $"{to}Lii Jixa the Somnolist" },
            { 90, $"{se}{BeaucedineGlacier}" }, { 91, $"{to}Nue" }, { 92, $"{se}{RanguemontPass}" }, { 93, $"{to}Gloom Eye" }, { 94, $"{se}{FeiYin}" }, { 95, $"{to}Goliath" }, { 96, $"{se}{Xarcabard}" },
            { 97, $"{to}Biast" }, { 98, $"{se}{CastleZvahlBaileys}" }, { 99, $"{to}Duke Haborym" }, { 100, $"{se}{CastleZvahlKeep}" }, { 101, $"{to}Baron Vapula" }, { 102, $"{se}{QufimIsland}" }, { 103, $"{to}Dosetsu Tree" },
            { 104, $"{se}{LowerDelkfuttsTower}" }, { 105, $"{to}Epialtes" }, { 106, $"{se}{MiddleDelkfuttsTower}" }, { 107, $"{to}Ogygos" }, { 108, $"{se}{UpperDelkfuttsTower}" }, { 109, $"{to}Enkelados" }, { 110, $"{se}ベヒーモスの縄張り" } };
        internal Dic EmiCombatAdoulinArea { get; } = Caa();
        internal Dic EmiCombatZilartArea { get; } = new( 22 ) { { 0, $"{se}{SanctuaryOfZiTah}" }, { 1, $"{se}{RoMaeve}" },
            { 02, $"{se}{BoyahdaTree}" }, { 3, $"{se}{DragonsAery}" }, { 4, $"{se}{EasternAltepaDesert}" }, { 5, $"{se}{WesternAltepaDesert}" }, { 6, $"{se}{QuicksandCaves}" },
            { 07, $"{se}{GustavTunnel}" }, { 8, $"{se}{KuftalTunnel}" }, { 9, $"{se}{CapeTeriggan}" }, { 10, $"{se}{ValleyOfSorrows}" }, { 11, $"{se}{YuhtungaJungle}" },
            { 12, $"{se}{SeaSerpentGrotto}" }, { 13, $"{se}{YhoatorJungle}" }, { 14, $"{se}{TempleOfUggalepih}" }, { 15, $"{se}{DenOfRancor}" }, { 16, $"{se}{IfritsCauldron}" },
            { 17, $"{se}{RuAunGardens}" }, { 18, $"{se}{VeLugannonPalace}" }, { 19, $"{se}{ShrineOfRuAvitau}" }, { 20, $"{se}{LabyrinthOfOnzozo}" }, { 21, $"{se}{KorrolokaTunnel}" } };
        internal Dic EmiCombatPromathiaArea { get; } = new( 20 ) { { 0, $"{se}{OldtonMovalpolos}" }, { 1, $"{se}{NewtonMovalpolos}" }, { 2, $"{se}{LufaiseMeadows}" }, { 3, $"{se}{MisareauxCoast}" },
            { 04, $"{se}{PhomiunaAqueducts}" }, { 5, $"{se}{RiverneSiteA01}" }, { 6, $"{se}{RiverneSiteB01}" }, { 7, $"{se}{Sacrarium}" },
            { 08, $"{se}{PromyvionHolla}" }, { 9, $"{se}{PromyvionDem}" }, { 10, $"{se}{PromyvionMea}" }, { 11, $"{se}{PromyvionVahzl}" },
            { 12, $"{se}{AlTaieu}" }, { 13, $"{se}{GrandPalaceOfHuXzoi}" }, { 14, $"{se}{GardenOfRuHmet}" }, { 15, $"{se}{CarpentersLanding}" },
            { 16, $"{se}{BibikiBay}" }, { 17, $"{se}{AttohwaChasm}" }, { 18, $"{se}{PsoXja}" }, { 19, $"{se}{UleguerandRange}" } };
        internal Dic EmiCombatAhturhganArea { get; } = new( 9 ) { { 0, $"{se}{BhaflauThickets}" }, { 1, $"{se}{Mamook}" }, { 2, $"{se}{WajaomWoodlands}" }, { 3, $"{se}{AydeewaSubterrane}" },
            { 4, $"{se}{Halvung}" }, { 5, $"{se}{MountZhayolm}" }, { 6, $"{se}{CaedarvaMire}" }, { 7, $"{se}{ArrapagoReef}" }, { 8, $"{se}{AlzadaalUnderseaRuins}" } };
        internal Dic EmiCombatGoddessArea { get; } = new( 22 ) { { 0, $"{se}{EastRonfaureS}" }, { 1, $"{se}{JugnerForestS}" },
            { 02, $"{se}{BatalliaDownsS}" }, { 3, $"{se}{LaVauleS}" }, { 4, $"{se}{EldiemeNecropolisS}" }, { 5, $"{se}{NorthGustabergS}" }, { 6, $"{se}{GraubergS}" },
            { 07, $"{se}{VunkerlInletS}" }, { 8, $"{se}{PashhowMarshlandsS}" }, { 9, $"{se}{RolanberryFieldsS}" }, { 10, $"{se}{BeadeauxS}" }, { 11, $"{se}{CrawlersNestS}" },
            { 12, $"{se}{WestSarutabarutaS}" }, { 13, $"{se}{FortKarugoNarugoS}" }, { 14, $"{se}{MeriphataudMountainsS}" }, { 15, $"{se}{SauromugueChampaignS}" }, { 16, $"{se}{CastleOztrojaS}" },
            { 17, $"{se}{GarlaigeCitadelS}" }, { 18, $"{se}{BeaucedineGlacierS}" }, { 19, $"{se}{XarcabardS}" }, { 20, $"{se}{CastleZvahlBaileysS}" }, { 21, $"{se}{CastleZvahlKeepS}" } };
        internal Dic EmiCombatAbysseaArea { get; } = new( 9 ) { { 0, $"{se}{AbysseaLaTheine}" }, { 1, $"{se}{AbysseaKonschtat}" }, { 2, $"{se}{AbysseaTahrongi}" },
            { 3, $"{se}{AbysseaAttohwa}" }, { 4, $"{se}{AbysseaMisareaux}" }, { 5, $"{se}{AbysseaVunkerl}" }, { 6, $"{se}{AbysseaAltepa}" }, { 7, $"{se}{AbysseaUleguerand}" }, { 8, $"{se}{AbysseaGrauberg}" } };
        internal Dic EmiCombatEschaArea { get; } = Cea();
        #endregion
        #region 釣り
        internal Dic EmiFishingGeneral { get; } = new( 18 ) { { 0, "漁師ギルドマスターと話す" }, { 1, "獲物を1匹釣る" }, { 2, "小型の獲物合計1" }, { 3, "大型の獲物合計1" }, { 4, "錆びたもの合計" }, { 5, "モンスター合計" },
            { 06, "フィッシュランキングに登録" }, { 7, "獲物合計(全域)1" }, { 8, "獲物合計(海水)" }, { 9, "獲物合計(淡水)" }, { 10, "ヤナギの釣竿で釣る" }, { 11, "イチイの釣竿で釣る" },
            { 12, "バンブーロッドで釣る" }, { 13, "獲物を10種類釣る" }, { 14, "獲物を25種類釣る" }, { 15, "獲物を50種類釣る" }, { 16, "獲物を75種類釣る" }, { 17, "獲物を100種類釣る" } };
        internal Dic EmiFishingTenacity { get; } = new( 25 ) { { 0, $"{fika}1" }, { 1, $"{fika}2" }, { 2, $"{fika}3" }, { 3, $"{fika}4" }, { 4, $"{fika}5" },
            { 05, $"{fika}6" }, { 6, $"{fika}7" }, { 7, $"{fika}8" }, { 8, "獲物の大きさと重さ" }, { 9, $"{reg}{Ronfaure}" },
            { 10, $"{reg}{Gustaberg}" }, { 11, $"{reg}{Sarutabaruta}" }, { 12, $"{reg}{Zulkheim}" }, { 13, $"{reg}{Kolshushu}" }, { 14, $"{reg}{Norvallen}" },
            { 15, $"{reg}{Derfland}" }, { 16, $"{reg}{Aragoneu}" }, { 17, $"{reg}{Qufim}" }, { 18, $"{reg}{Fauregandi}" }, { 19, $"{reg}{Kuzotz}" },
            { 20, $"{reg}{Vollbow}" }, { 21, $"{reg}{ElshimoLowlands}" }, { 22, $"{reg}{ElshimoUplands}" }, { 23, $"{reg}{LiTelor}" }, { 24, "機船航路(セルビナ・マウラ)" } };
        #endregion
        #region 合成
        internal Dic EmiCraftingGeneral { get; } = new( 1 ) { { 0, "合成成功回数合計" } };
        internal Dic EmiCraftingEscutcheons { get; } = new( 4 ) { { 0, $"{gima}1" }, { 1, $"{gima}2" }, { 2, $"{gima}3" }, { 3, $"{gima}4" } };
        #endregion
        #region 採集
        internal Dic EmiHarvestingGeneral { get; } = new( 2 ) { { 0, "採集成功回数合計" }, { 1, "採集成功回数合計2" } };
        internal Dic EmiHarvestingOriginalArea { get; } = new( 12 ) { { 0, har + EastRonfaure }, { 1, har + GhelsbaOutpost }, { 2, har + GusgenMines }, { 3, har + JugnerForest },
            { 4, har + ZeruhnMines }, { 5, har + PalboroughMines }, { 6, har + WestSarutabaruta }, { 7, har + Giddeus },
            { 8, har + BuburimuPeninsula }, { 9, har + TahrongiCanyon }, { 10, har + MazeOfShakhrami }, { 11, har + YughottGrotto } };
        internal Dic EmiHarvestingAdoulinArea { get; } = new( 26 ) { { 0, $"{har}{CeizakBattlegrounds}1" },
            { 01, $"{har}{CeizakBattlegrounds}2" }, { 2, $"{har}{YahseHuntingGrounds}1" }, { 3, $"{har}{YahseHuntingGrounds}2" }, { 4, $"{har}{ForetDeHennetiel}1" }, { 5, $"{har}{ForetDeHennetiel}2" },
            { 06, $"{har}{MorimarBasaltFields}1" }, { 7, $"{har}{MorimarBasaltFields}2" }, { 8, $"{har}{YorciaWeald}1" }, { 9, $"{har}{YorciaWeald}2" }, { 10, $"{har}{MarjamiRavine}1" },
            { 11, $"{har}{MarjamiRavine}2" }, { 12, $"{har}{KamihrDrifts}1" }, { 13, $"{har}{KamihrDrifts}2" }, { 14, $"{har}{SihGates}1" }, { 15, $"{har}{SihGates}2" },
            { 16, $"{har}{MohGates}1" }, { 17, $"{har}{MohGates}2" }, { 18, $"{har}{CirdasCaverns}1" }, { 19, $"{har}{CirdasCaverns}2" }, { 20, $"{har}{DhoGates}1" },
            { 21, $"{har}{DhoGates}2" }, { 22, $"{har}{WohGates}1" }, { 23, $"{har}{WohGates}2" }, { 24, $"{har}{OuterRaKaznar}1" }, { 25, $"{har}{OuterRaKaznar}2" } };
        internal Dic EmiHarvestingZilartArea { get; } = new( 4 ) { { 0, har + YuhtungaJungle }, { 1, har + YhoatorJungle }, { 2, har + IfritsCauldron }, { 3, har + KorrolokaTunnel } };
        internal Dic EmiHarvestingPromathiaArea { get; } = new( 6 ) { { 0, har + OldtonMovalpolos }, { 1, har + NewtonMovalpolos },
            { 2, har + LufaiseMeadows }, { 3, har + MisareauxCoast }, { 4, har + CarpentersLanding }, { 5, har + AttohwaChasm } };
        internal Dic EmiHarvestingAhturhganArea { get; } = new( 6 ) { { 0, har + BhaflauThickets }, { 1, har + Mamook },
            { 2, har + WajaomWoodlands }, { 3, har + Halvung }, { 4, har + MountZhayolm }, { 5, har + CaedarvaMire } };
        internal Dic EmiHarvestingGoddessArea { get; } = new( 6 ) { { 0, har + EastRonfaureS }, { 1, har + JugnerForestS },
            { 2, har + NorthGustabergS }, { 3, har + GraubergS }, { 4, har + WestSarutabarutaS }, { 5, har + FortKarugoNarugoS } };
        internal Dic EmiHarvestingAbysseaArea { get; } = new( 5 ) { { 0, har + AbysseaLaTheine }, { 1, har + AbysseaTahrongi }, { 2, har + AbysseaAttohwa }, { 3, har + AbysseaMisareaux }, { 4, har + AbysseaGrauberg } };
        #endregion
        #region コンテンツ
        internal Dic EmiContentLairReive { get; } = new( 10 ) { { 0, lare + CeizakBattlegrounds }, { 1, lare + YahseHuntingGrounds },
            { 2, lare + ForetDeHennetiel }, { 3, lare + MorimarBasaltFields }, { 4, lare + YorciaWeald }, { 5, lare + MarjamiRavine },
            { 6, lare + KamihrDrifts }, { 7, lare + CirdasCaverns }, { 8, lare + OuterRaKaznar }, { 9, lare + RaKaznarInnerCourt } };
        internal Dic EmiContentColonizationReive { get; } = new( 14 ) { { 0, core + CeizakBattlegrounds }, { 1, core + YahseHuntingGrounds },
            { 2, core + ForetDeHennetiel }, { 3, core + MorimarBasaltFields }, { 4, core + YorciaWeald }, { 5, core + MarjamiRavine }, { 6, core + KamihrDrifts }, { 7, core + SihGates },
            { 8, core + MohGates }, { 9, core + CirdasCaverns }, { 10, core + DhoGates }, { 11, core + WohGates }, { 12, core + OuterRaKaznar }, { 13, core + RaKaznarInnerCourt } };
        internal Dic EmiContentWildskeeperReive { get; } = new( 6 ) { { 0, $"{to}蟲妃公コルカブ" }, { 1, $"{to}水刃公チャッカ" },
            { 2, $"{to}炎竜公アチュカ" }, { 3, $"{to}古樹公ユムカクス" }, { 4, $"{to}轟雷公フルカン" }, { 5, $"{to}絶零公クムハウ" } };
        internal Dic EmiContentOther { get; } = new( 17 ) { { 0, "チョコボ掘り成功回数合計" }, { 1, "モンプレ：モンスター討伐数合計" },
            { 02, "Treasure Chest、Coffer開錠" }, { 3, "印章バトルフィールド" }, { 4, $"{to}Kirin" }, { 5, $"{to}Genbu" }, { 6, $"{to}Suzaku" },
            { 07, $"{to}Seiryu" }, { 8, $"{to}Byakko" }, { 9, $"{to}Jailer of Justice" }, { 10, $"{to}Jailer of Hope" }, { 11, $"{to}Jailer of Prudence" },
            { 12, $"{to}Jailer of Love" }, { 13, $"{to}Battleclad Chariot" }, { 14, $"{to}Armored CHariot" }, { 15, $"{to}Long-Bowed Chariot" }, { 16, $"{to}Long-Armed Chariot" } };
        internal Dic EmiContentDynamis { get; } = new( 30 ) {
            { 00, $"{to}Overlord's Tombstone" }, { 1, $"{to}Bladeburner Rokgevok" }, { 2, $"{to}Steelshank Kratzvatz" }, { 3, $"{to}Bloodfist Voshgrosh" }, { 4, $"{to}Spellspear Djokvukk" },
            { 05, $"{to}Gu'Dha Effigy" }, { 6, $"{to}Zo'Pha Forgesoul" }, { 7, $"{to}Ra'Gho Darkfound" }, { 8, $"{to}Va'Zhe Pummelsong" }, { 9, $"{to}Bu'Bho Truesteel" },
            { 10, $"{to}Tzee Xicu Idol" }, { 11, $"{to}Xuu Bhoqa the Enigma" }, { 12, $"{to}Fuu Tzapo the Blessed" }, { 13, $"{to}Naa Yixo the Stillrage" }, { 14, $"{to}Tee Zaksa the Ceaseless" },
            { 15, $"{to}Goblin Golem" }, { 16, $"{to}Quicktrix Hexhands" }, { 17, $"{to}Feralox Honeylips" }, { 18, $"{to}Scourquix Scaleskin" }, { 19, $"{to}Wilywox Tenderpalm" },
            { 20, $"{to}Angra Mainyu" }, { 21, $"{to}Taquede" }, { 22, $"{to}Pignonpausard" }, { 23, $"{to}Hitaume" }, { 24, $"{to}Cavanneche" },
            { 25, $"{to}Dynamis Lord" }, { 26, $"{to}Duke Haures" }, { 27, $"{to}Marquis Caim" }, { 28, $"{to}Baron Avnas" }, { 29, $"{to}Count Haagenti" } };
        internal Dic EmiContentLimbus { get; } = new( 12 ) { { 0, $"{spil}(アイボリーチップ)" }, { 1, $"{spil}(スカーレットチップ)" }, { 2, $"{spil}(エメラルドチップ)" }, { 3, $"{spil}(オーキッドチップ)" },
            { 4, $"{spil}(セルリアンチップ)" }, { 5, $"{spil}(シルバーチップ)" }, { 6, $"{spil}(スモーキーチップ)" }, { 7, $"{spil}(マゼンタチップ)" },
            { 8, $"{spil}(チャコールチップ)" }, { 9, $"{spil}(スマルトチップ)" }, { 10, $"{to}Proto-Ultima" }, { 11, $"{to}Proto-Omega" } };
        internal Dic EmiContentZNM { get; } = new( 27 ) { { 0, $"{to}Vulpangue" }, { 1, $"{to}Chamrosh" },
            { 02, $"{to}Cheese Hoarder Gigiroon" }, { 3, $"{to}Brass Borer" }, { 4, $"{to}Claret" }, { 5, $"{to}Ob" }, { 6, $"{to}Velionis" },
            { 07, $"{to}Lil' Apkallu" }, { 8, $"{to}Chigre" }, { 9, $"{to}Iriz Ima" }, { 10, $"{to}Lividroot Amooshah" }, { 11, $"{to}Iriri Samariri" },
            { 12, $"{to}Anantaboga" }, { 13, $"{to}Reacton" }, { 14, $"{to}Dextrose" }, { 15, $"{to}Wulgaru" }, { 16, $"{to}Zareehkl the Jubilant" },
            { 17, $"{to}Verdelet" }, { 18, $"{to}Armed Gears" }, { 19, $"{to}Gotoh Zha the Redolent" }, { 20, $"{to}Dea" }, { 21, $"{to}Nosferatu" },
            { 22, $"{to}Khromasoul Bhurborlor" }, { 23, $"{to}Achamoth" }, { 24, $"{to}Mahjleaf the Paintorn" }, { 25, $"{to}Experimental Lamia" }, { 26, $"{to}Nuhn" } };
        internal Dic EmiContentVagary { get; } = new( 5 ) { { 0, $"{to}Putraxia" }, { 1, $"{to}Rancibus" }, { 2, $"{to}Palloritus" }, { 3, $"{to}Perfidien" }, { 4, $"{to}Plouton" } };
        internal Dic EmiContentOmen { get; } = new( 5 ) { { 0, $"{to}Fu" }, { 1, $"{to}Kyou" }, { 2, $"{to}Kei" }, { 3, $"{to}Gin" }, { 4, $"{to}Kin" } };
        internal Dic EmiContentOdyssey { get; } = new( 3 ) { { 0, "シェオル Aの出口に到達する" }, { 1, "シェオル Bの出口に到達する" }, { 2, "シェオル Cの出口に到達する" } };
        internal Dic EmiContentSortie { get; } = new( 9 ) { { 0, $"{to}Ghatjot" }, { 1, $"{to}Leshonn" }, { 2, $"{to}Skomora" },
            { 3, $"{to}Degei" }, { 4, $"{to}Dhartok" }, { 5, $"{to}Gartell" }, { 6, $"{to}Triboulex" }, { 7, $"{to}Aita" }, { 8, $"{to}Aminon" } };
        #endregion
        #region アチーブメント
        internal Dic EmiAchievementsJobLevels { get; } = new( 88 ) { { 0, WAR + lv30 }, { 1, WAR + lv50 }, { 2, WAR + lv75 }, { 3, WAR + lv99 }, { 4, MNK + lv30 }, { 5, MNK + lv50 }, { 6, MNK + lv75 }, { 7, MNK + lv99 },
            { 08, WHM + lv30 }, { 09, WHM + lv50 }, { 10, WHM + lv75 }, { 11, WHM + lv99 }, { 12, BLM + lv30 }, { 13, BLM + lv50 }, { 14, BLM + lv75 }, { 15, BLM + lv99 },
            { 16, RDM + lv30 }, { 17, RDM + lv50 }, { 18, RDM + lv75 }, { 19, RDM + lv99 }, { 20, THF + lv30 }, { 21, THF + lv50 }, { 22, THF + lv75 }, { 23, THF + lv99 },
            { 24, PLD + lv30 }, { 25, PLD + lv50 }, { 26, PLD + lv75 }, { 27, PLD + lv99 }, { 28, DRK + lv30 }, { 29, DRK + lv50 }, { 30, DRK + lv75 }, { 31, DRK + lv99 },
            { 32, BST + lv30 }, { 33, BST + lv50 }, { 34, BST + lv75 }, { 35, BST + lv99 }, { 36, BRD + lv30 }, { 37, BRD + lv50 }, { 38, BRD + lv75 }, { 39, BRD + lv99 },
            { 40, RNG + lv30 }, { 41, RNG + lv50 }, { 42, RNG + lv75 }, { 43, RNG + lv99 }, { 44, SAM + lv30 }, { 45, SAM + lv50 }, { 46, SAM + lv75 }, { 47, SAM + lv99 },
            { 48, NIN + lv30 }, { 49, NIN + lv50 }, { 50, NIN + lv75 }, { 51, NIN + lv99 }, { 52, DRG + lv30 }, { 53, DRG + lv50 }, { 54, DRG + lv75 }, { 55, DRG + lv99 },
            { 56, SMN + lv30 }, { 57, SMN + lv50 }, { 58, SMN + lv75 }, { 59, SMN + lv99 }, { 60, BLU + lv30 }, { 61, BLU + lv50 }, { 62, BLU + lv75 }, { 63, BLU + lv99 },
            { 64, COR + lv30 }, { 65, COR + lv50 }, { 66, COR + lv75 }, { 67, COR + lv99 }, { 68, PUP + lv30 }, { 69, PUP + lv50 }, { 70, PUP + lv75 }, { 71, PUP + lv99 },
            { 72, DNC + lv30 }, { 73, DNC + lv50 }, { 74, DNC + lv75 }, { 75, DNC + lv99 }, { 76, SCH + lv30 }, { 77, SCH + lv50 }, { 78, SCH + lv75 }, { 79, SCH + lv99 },
            { 80, GEO + lv30 }, { 81, GEO + lv50 }, { 82, GEO + lv75 }, { 83, GEO + lv99 }, { 84, RUN + lv30 }, { 85, RUN + lv50 }, { 86, RUN + lv75 }, { 87, RUN + lv99 } };
        internal Dic EmiAchievementsFame { get; } = new( 14 ) { { 0, $"{fame}サンドリア" }, { 1, $"{fame}バストゥーク" },
            { 2, $"{fame}ウィンダス" }, { 3, $"{fame}{Norg}" }, { 4, $"{fame}{AbysseaLaTheine}" }, { 5, $"{fame}{AbysseaKonschtat}" },
            { 6, $"{fame}{AbysseaTahrongi}" }, { 7, $"{fame}{AbysseaAttohwa}" }, { 8, $"{fame}{AbysseaMisareaux}" }, { 9, $"{fame}{AbysseaVunkerl}" },
            { 10, $"{fame}{AbysseaAltepa}" }, { 11, $"{fame}{AbysseaUleguerand}" }, { 12, $"{fame}{AbysseaGrauberg}" }, { 13, $"{fame}アドゥリン" } };
        #endregion
        #region ユニティ
        internal Dic EmiUnityWanted { get; } = new( 56 ) { { 0, $"{tb}Hugemaw Harold(UC)" },
            { 01, $"{tb}Bounding Belinda(UC)" }, { 2, $"{tb}Prickly Pitriv(UC)" }, { 3, $"{tb}Ironhorn Baldurno(UC)" }, { 4, $"{tb}Sleepy Mabel(UC)" }, { 5, $"{tb}Valkurm Imperator(UC)" },
            { 06, $"{tb}Serpopard Ninlil(UC)" }, { 7, $"{tb}Abyssdiver(UC)" }, { 8, $"{tb}Intuila(UC)" }, { 9, $"{tb}Emperor Arthro(UC)" }, { 10, $"{tb}Orcfeltrap(UC)" },
            { 11, $"{tb}Lumber Jill(UC)" }, { 12, $"{tb}Joyous Green(UC)" }, { 13, $"{tb}Strix(UC)" }, { 14, $"{tb}Warblade Beak(UC)" }, { 15, $"{tb}Arke(UC)" },
            { 16, $"{tb}Largantua(UC)" }, { 17, $"{tb}Beist(UC)" }, { 18, $"{tb}Jester Malatrix(UC)" }, { 19, $"{tb}Cactror Veloz(UC)" }, { 20, $"{tb}Woodland Mender(UC)" },
            { 21, $"{tb}Sybaritic Samantha(UC)" }, { 22, $"{tb}Keeper of Heiligtum(UC)" }, { 23, $"{tb}Douma Weapon(UC)" }, { 24, $"{tb}King Uropygid(UC)" }, { 25, $"{tb}Vedrfolnir(UC)" },
            { 26, $"{tb}Immanibugard(UC)" }, { 27, $"{tb}Tiyanak(UC)" }, { 28, $"{tb}Muut(UC)" }, { 29, $"{tb}Camahueto(UC)" }, { 30, $"{tb}Voso(UC)" },
            { 31, $"{tb}Mephitas(UC)" }, { 32, $"{tb}Coca(UC)" }, { 33, $"{tb}Ayapec(UC)" }, { 34, $"{tb}Specter Worm(UC)" },
            { 35, $"{tb}Azrael(UC)" }, { 36, $"{tb}Borealis Shadow(UC)" }, { 37, $"{tb}Garbage Gel(UC)" }, { 38, $"{tb}Bakunawa(UC)" }, { 39, $"{tb}Azure-toothed Clawberry(UC)" },
            { 40, $"{tb}Centurio XX-I(UC)" }, { 41, $"{tb}Kubool Ja's Mhuufya(UC)" }, { 42, $"{tb}Vidmapire(UC)" }, { 43, $"{tb}Vermillion Fishfly(UC)" }, { 44, $"{tb}Volatile Cluster(UC)" },
            { 45, $"{tb}Grand Grenade(UC)" }, { 46, $"{tb}Sovereign Behemoth(UC)" }, { 47, $"{tb}Hidhaegg(UC)" }, { 48, $"{tb}Tolba(UC)" }, { 49, $"{tb}Carousing Celine(UC)" },
            { 50, $"{tb}Glazemane(UC)" }, { 51, $"{tb}Wyvernhunter Bambrox(UC)" }, { 52, $"{tb}Thu'ban(UC)" }, { 53, $"{tb}Sarama(UC)" }, { 54, $"{tb}Shede(UC)" }, { 55, $"{tb}Tumult Curator(UC)" } };
        #endregion
        #region アニバーサリー
        internal Dic EmiVanaversary15 { get; } = new( 5 ) { { 0, "ミスリルマラソン" }, { 1, "セルビナ派" }, { 2, "パピ取り" }, { 3, "ミラテテ01" }, { 4, "ハイ、チーズ" } };
        #endregion
        #region その他
        internal Dic EmiOtherRoeQuests1 { get; } = new( 15 ) { { 0, "テレポイント巡り" }, { 1, "闇狩り" }, { 2, "思い出の地に花びらを" }, { 3, "不倶戴天" }, { 4, "忘己利他" },
            { 05, "夢幻泡影" }, { 6, "万物流転" }, { 7, "獅子雷閃" }, { 8, "兎死狗烹" }, { 9, "行雲流水" },
            { 10, "天下無双" }, { 11, "滄海一粟" }, { 12, "諸行無常" }, { 13, "子虚烏有" }, { 14, "銘心鏤骨" } };
        internal Dic EmiOtherRoeQuests2 { get; } = new( 7 ) { { 0, $"{yug}1" }, { 1, $"{yug}2" }, { 2, $"{yug}3" }, { 3, $"{yug}4" }, { 4, $"{yug}5" }, { 5, $"{yug}6" }, { 6, "アシェラ激励指令" } };
        internal Dic EmiOtherRoeQuests3 { get; } = new( 8 ) { { 0, "「憎悪」で焼きこがせ" }, { 1, "「驕慢」で腐らせろ" },
            { 2, "「嫉妬」でかじりとれ" }, { 3, "「怯懦」で押しつぶせ" }, { 4, "「無知」でうつろにしろ" },
            { 5, "絆パワーですわ！" }, { 6, "もっと絆パワーですわ！" }, { 7, "もっともっと絆パワーですわ！" } };
        #endregion
        #region 移動
        internal string[] MovOutpost { get; } = [$"{Ronfaure}地方", $"{Zulkheim}地方",
            $"{Norvallen}地方", $"{Gustaberg}地方", $"{Derfland}地方", $"{Sarutabaruta}地方", $"{Kolshushu}地方",
            $"{Aragoneu}地方", $"{Fauregandi}地方", $"{Valdeaunia}地方", $"{Qufim}地方", $"{LiTelor}地方",
            $"{Kuzotz}地方", $"{Vollbow}地方", $"{ElshimoLowlands}地方", $"{ElshimoUplands}地方", $"{TavnazianArchipelago}地方"];
        internal string[] MovRunicPortal { get; } = [$"アズーフ島{stag}", $"ドゥブッカ島{stag}", $"マムージャ{stag}", $"{Halvung}{stag}", $"{IlrusiAtoll}{stag}", $"{NyzulIsle}{stag}"];
        internal string[] MovSurvivalGuide { get; } = [$"l{SandOria}", $"{NorthernSandOria}",
            $"l{Bastok}", $"{BastokMines}",
            $"l{Windurst}", $"{PortWindurst}",
            $"l{Jeuno}", $"{RuLudeGardens}",
            $"l{TavnazianMarquisate}", $"{TavnazianSafehold}",
            $"l{WestAhtUrhgan}", $"{AhtUrhganWhitegate}",
            $"l{AdoulinIslands}", $"{EasternAdoulin}",
            $"l{Ronfaure}", $"{WestRonfaure}", $"{FortGhelsba}", $"{BostaunieuxOubliette}", $"{KingRanperresTomb}",
            $"l{Zulkheim}", $"{LaTheinePlateau}", $"{ValkurmDunes}", $"{KonschtatHighlands}", $"{OrdellesCaves}", $"{GusgenMines}",
            $"l{Norvallen}", $"{CarpentersLanding}", $"{JugnerForest}", $"{BatalliaDowns}", $"{Davoi}", $"{EldiemeNecropolis}",
            $"l{Gustaberg}", $"{NorthGustaberg}", $"{ZeruhnMines}", $"{KorrolokaTunnel}", $"{DangrufWadi}",
            $"l{Derfland}", $"{PashhowMarshlands}", $"{RolanberryFields}", $"{Beadeaux}", $"{CrawlersNest}",
            $"l{Sarutabaruta}", $"{WestSarutabaruta}", $"{ToraimaraiCanal}", $"{InnerHorutotoRuins}",
            $"l{Kolshushu}", $"{BibikiBay}", $"{TahrongiCanyon}", $"{BuburimuPeninsula}", $"{MazeOfShakhrami}", $"{LabyrinthOfOnzozo}",
            $"l{Aragoneu}", $"{MeriphataudMountains}", $"{SauromugueChampaign}", $"{CastleOztroja}", $"{GarlaigeCitadel}",
            $"l{Fauregandi}", $"{BeaucedineGlacier}", $"{RanguemontPass}",
            $"l{Valdeaunia}", $"{Xarcabard}", $"{CastleZvahlBaileys}",
            $"l{Qufim}", $"{QufimIsland}", $"{BehemothsDominion}", $"{LowerDelkfuttsTower}",
            $"l{LiTelor}", $"{SanctuaryOfZiTah}", $"{RoMaeve}", $"{DragonsAery}",
            $"l{Kuzotz}", $"{EasternAltepaDesert}", $"{WesternAltepaDesert}", $"{Rabao}",
            $"l{Vollbow}", $"{CapeTeriggan}", $"{ValleyOfSorrows}", $"{KuftalTunnel}", $"{GustavTunnel}",
            $"l{ElshimoLowlands}", $"{YuhtungaJungle}", $"{SeaSerpentGrotto}", $"{Kazham}", $"{Norg}",
            $"l{ElshimoUplands}", $"{YhoatorJungle}", $"{TempleOfUggalepih}", $"{IfritsCauldron}",
            $"l{TuLia}", $"{RuAunGardens}",
            $"l{Movalpolos}", $"{OldtonMovalpolos}",
            $"l{TavnazianArchipelago}", $"{LufaiseMeadows}", $"{MisareauxCoast}", $"{PhomiunaAqueducts}", $"{Sacrarium}",
            $"l{MamoolJaSavagelands}", $"{WajaomWoodlands}", $"{Mamook}", $"{AydeewaSubterrane}",
            $"l{HalvungTerritory}", $"{Halvung}",
            $"l{ArrapagoIslands}", $"{Nashmau}", $"{ArrapagoReef}", $"{CaedarvaMire}",
            $"l{RonfaureFront}", $"{SouthernSandOriaS}", $"{EastRonfaureS}",
            $"l{NorvallenFront}", $"{JugnerForestS}", $"{BatalliaDownsS}", $"{EldiemeNecropolisS}",
            $"l{GustabergFront}", $"{BastokMarketsS}", $"{NorthGustabergS}", $"{GraubergS}",
            $"l{DerflandFront}", $"{VunkerlInletS}", $"{PashhowMarshlandsS}", $"{RolanberryFieldsS}", $"{CrawlersNestS}",
            $"l{SarutabarutaFront}", $"{WindurstWatersS}", $"{WestSarutabarutaS}", $"{FortKarugoNarugoS}",
            $"l{AragoneuFront}", $"{MeriphataudMountainsS}", $"{SauromugueChampaignS}", $"{GarlaigeCitadelS}",
            $"l{FauregandiFront}", $"{BeaucedineGlacierS}", $"l{ValdeauniaFront}", $"{CastleZvahlBaileysS}"];
        internal string[] MovHomePoint { get; } = [$"l{SandOria}", $"l{SouthernSandOria}", "#1 (E)", "#2 (A)", "#3 (M)", "#4", $"l{NorthernSandOria}", "#1 (E)", "#2", "#3 (M)", "#4", $"l{PortSandOria}", "#1", "#2 (M)", "#3 (A)",
            $"l{Bastok}", $"l{BastokMines}", "#1 (A)", "#2 (M)", "#3", $"l{BastokMarkets}", "#1 (E)", "#2 (A)", "#3 (M)", "#4", $"l{PortBastok}", "#1 (E)", "#2 (M)", "#3", $"l{Metalworks}", "#1", "#2",
            $"l{Windurst}", $"l{WindurstWaters}", "#1 (E)", "#2 (M)", "#3", "#4", $"l{WindurstWalls}", "#1", "#2 (M)", "#3 (A)", $"l{PortWindurst}", "#1", "#2 (E)", "#3 (M)", $"l{WindurstWoods}", "#1", "#2 (E)", "#3 (M)", "#4 (A)", "#5",
            $"l{Jeuno}", $"l{RuLudeGardens}", "#1", "#2 (M)", "#3 (A)", $"l{UpperJeuno}", "#1 (E)", "#2 (M)", "#3 (A)", $"l{LowerJeuno}", "#1 (E)", "#2 (M)", $"l{PortJeuno}", "#1 (E)", "#2 (M)",
            $"l{TavnazianMarquisate}", $"l{TavnazianSafehold}", "#1", "#2", "#3",
            $"l{WestAhtUrhgan}", $"l{AhtUrhganWhitegate}", "#1", "#2", "#3 (A)", "#4 (M)", $"l{BhaflauThickets}", "#1",
            $"l{AdoulinIslands}", $"l{WesternAdoulin}", "#1 (A)", "#2 (M)", $"l{EasternAdoulin}", "#1", "#2 (M)",
            $"l{Ronfaure}", $"l{YughottGrotto}", "#1",
            $"l{Zulkheim}", $"l{Selbina}", "#1",
            $"l{Gustaberg}", $"l{PalboroughMines}", "#1",
            $"l{Sarutabaruta}", $"l{Giddeus}", "#1", $"l{ToraimaraiCanal}", "#1",
            $"l{Kolshushu}", $"l{Mhaura}", "#1",
            $"l{Aragoneu}", $"l{AttohwaChasm}", "#1",
            $"l{Fauregandi}", $"l{PsoXja}", "#1", $"l{FeiYin}", "#1", "#2",
            $"l{Valdeaunia}", $"l{UleguerandRange}", "#1", "#2", "#3", "#4", "#5", $"l{CastleZvahlKeep}", "#1",
            $"l{Qufim}", $"l{QufimIsland}", "#1", $"l{UpperDelkfuttsTower}", "#1",
            $"l{LiTelor}", $"l{BoyahdaTree}", "#1",
            $"l{Kuzotz}", $"l{QuicksandCaves}", "#1", "#2", $"l{Rabao}", "#1", "#2",
            $"l{Vollbow}", $"l{CapeTeriggan}", "#1",
            $"l{ElshimoLowlands}", $"l{Kazham}", "#1", $"l{Norg}", "#1", "#2 (A)",
            $"l{ElshimoUplands}", $"l{DenOfRancor}", "#1", "#2", $"l{IfritsCauldron}", "#1",
            $"l{TuLia}", $"l{RuAunGardens}", "#1", "#2", "#3", "#4", "#5", $"l{ShrineOfRuAvitau}", "#1",
            $"l{Movalpolos}", $"l{NewtonMovalpolos}", "#1",
            $"l{TavnazianArchipelago}", $"l{MisareauxCoast}", "#1", $"l{RiverneSiteB01}", "#1", $"l{RiverneSiteA01}", "#1",
            $"l{Lumoria}", $"l{AlTaieu}", "#1", "#2", "#3", $"l{GrandPalaceOfHuXzoi}", "#1", $"l{GardenOfRuHmet}", "#1",
            $"l{HalvungTerritory}", $"l{MountZhayolm}", "#1",
            $"l{ArrapagoIslands}", $"l{Nashmau}", "#1", $"l{CaedarvaMire}", "#1",
            $"l{RonfaureFront}", $"l{SouthernSandOriaS}", "#1",
            $"l{GustabergFront}", $"l{BastokMarketsS}", "#1",
            $"l{SarutabarutaFront}", $"l{WindurstWatersS}", "#1",
            $"l{ValdeauniaFront}", $"l{XarcabardS}", "#1", $"l{CastleZvahlKeepS}", "#1",
            $"l{EastUlbukaTerritory}", $"l{CeizakBattlegrounds}", "#1", $"l{ForetDeHennetiel}", "#1", $"l{YorciaWeald}", "#1", $"l{MorimarBasaltFields}", "#1", $"l{MarjamiRavine}", "#1", $"l{KamihrDrifts}", "#1", $"l{Leafallia}", "#1",
            $"l{RaKaznar}", $"l{RaKaznarInnerCourt}", "#1"];
        internal string[] MovMount { get; } = ["マイチョコボ", "ラプトル", "剣虎", "クラブ", "赤クラブ", "ボム",
            "大羊", "モルボル", "クロウラー", "フェンリル", "甲虫", "モーグリ",
            "マジックポット", "トゥルフェイア", "ウォーマシン", "ゾミト", "ヒポグリフ", "悪霊の椅子",
            "スフィアロイド", "オメガ", "クァール", "グゥーブー", "ラズ", "レヴィデイス",
            "アダマンタス", "ダルメル", "ドール", "ゴールデンボム", "バッファロー", "ウィヴル",
            "赤ラプトル", "鉄巨人", "白虎", "ノーブルチョコボ", "イクシオン", "フワボ",
            "クラックロー", "アリコーン", "バブルクラブ"];
        #endregion

        static Dic Caa()
        {
            byte i = 0;
            string[] s = [RalaWaterways, CeizakBattlegrounds, YahseHuntingGrounds, ForetDeHennetiel, MorimarBasaltFields,
                YorciaWeald, MarjamiRavine, KamihrDrifts, SihGates, MohGates,
                CirdasCaverns, DhoGates, WohGates, OuterRaKaznar, RaKaznarInnerCourt];
            Dic ret = new( 45 );

            foreach( string t in s ) {
                foreach( int j in Enumerable.Range( 1, 3 ) ) {
                    ret.Add( i, $"{se}{t}{j}" );
                    i++;
                }
            }
            return ret;
        }

        static Dic Cea()
        {
            byte i = 0;
            Dic ret = new( 28 );

            foreach( int j in Enumerable.Range( 1, 7 ) ) {
                ret.Add( i, $"{se}{EschaZiTah}{j}" );
                i++;
            }
            foreach( int j in Enumerable.Range( 1, 10 ) ) {
                ret.Add( i, $"{se}{EschaRuAun}{j}" );
                i++;
            }
            foreach( int j in Enumerable.Range( 1, 11 ) ) {
                ret.Add( i, $"{se}{Reisenjima}{j}" );
                i++;
            }
            return ret;
        }
    }
}
