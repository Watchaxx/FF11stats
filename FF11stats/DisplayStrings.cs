using Dic = System.Collections.Generic.Dictionary<byte, string>;
using Itm = System.Collections.Generic.Dictionary<ushort, string>;

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
        const string Ambs = "アンバスケード";
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

        #region フェイスポイント
        internal string[] FaithPtHpMp { get; } = ["HP上限", "MP上限"];
        internal string[] FaithPtStatus { get; } = ["STR", "DEX", "VIT", "AGI", "INT", "MND", "CHR"];
        internal string[] FaithPtSkill { get; } = ["戦闘スキル", "魔法スキル"];
        #endregion
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
        internal Dic EmiTutorialBasics { get; } = new( 16 ) { { 0, "始まりの軌跡" }, { 1, "繋がりの軌跡" }, { 4, "モンスターを1匹倒す" }, { 2, "FoVの自主訓練を受ける" },
            { 3, "ヒーリングで回復する" }, { 5, "GoVの自主訓練を受ける" }, { 15, "ディードってすごいおトク！" }, { 7, "フェイスを呼び出す" },
            { 8, "フェイス：ヴァレンラール" }, { 9, "フェイス：ミリ・アリアポー" }, { 10, "フェイス：テンゼン" }, { 11, "フェイス：アーデルハイト" },
            { 12, "フェイス：ヨアヒム" }, { 6, $"はじめての{Ambs}" }, { 13, "A.M.A.N. トローブってなぁに？" }, { 14, "アシストチャンネル" } };
        internal Dic EmiTutorialIntermediate { get; } = new( 18 ) { { 0, "メインジョブのレベルを99にする" }, { 1, "エミネンスポイントを貯める" }, { 2, "エミネンスポイントを貯める2" },
            { 3, "エミネンスポイントを貯める3" }, { 4, "アイテムレベルを117にする" }, { 05, "ワイルドキーパー・レイヴ" },
            { 6, $"戦闘:スカーム-{RalaWaterwaysU}" }, { 7, $"戦闘:スカーム-{CirdasCavernsU}" }, { 8, $"戦闘:スカーム-{YorciaWealdU}" },
            { 9, $"{Ambs}をクリアする" }, { 10, $"{af}を強化" }, { 11, $"{af}を強化2" },
            { 16, "レリック装束を強化" }, { 17, "レリック装束を強化2" }, { 12, $"戦闘:A・スカーム-{RalaWaterwaysU}" },
            { 13, $"戦闘:A・スカーム-{CirdasCavernsU}" }, { 14, $"A・スカーム-{YorciaWealdU}" }, { 15, "メンターライセンス" } };
        internal Dic EmiTutorialIntermediate2 { get; } = new( 18 ) { { 0, $"{Ambs}の防具を入手" }, { 1, $"{Ambs}の防具を強化" }, { 2, $"{Ambs}の防具を強化2" },
            { 3, $"{Ambs}の武器を入手" }, { 4, $"{Ambs}の武器を強化" }, { 5, $"{Ambs}の武器を強化2" }, { 6, $"{Ambs}の武器を強化3" }, { 7, "オーメンの詰みルートに進入する" },
            { 8, $"{af}ILv119+2" }, { 9, $"{af}ILv119+3" }, { 10, "デュナミス〔Ｄ〕・共有に進入する" }, { 11, "レリック装束ILv119+2" }, { 12, "レリック装束ILv119+3" },
            { 13, "ベガリーインスペクターに進入する" }, { 14, "エンピリアン装束ILv119" }, { 15, "ソーティに進入する" }, { 16, "エンピリアン装束ILv119+2" }, { 17, "エンピリアン装束ILv119+3" } };
        internal Dic EmiTutorialSynthesis { get; } = new( 16 ) { { 0, $"木工{gimt}" }, { 1, $"鍛冶{gimt}" }, { 2, $"彫金{gimt}" }, { 3, $"織工{gimt}" }, { 4, $"革工{gimt}" },
            { 5, $"骨工{gimt}" }, { 6, $"錬金術{gimt}" }, { 7, $"調理{gimt}" }, { 8, "木工：化粧箱" }, { 9, "鍛冶：ブロンズナイフ" }, { 10, "彫金：カッパーリング" },
            { 11, "裁縫：ヘッドギア" }, { 12, "革細工：レザーバンダナ" }, { 13, "骨細工：胡粉" }, { 14, "錬金術：黒インク" }, { 15, "調理：石のスープ" } };
        internal Dic EmiTutorialQuests1 { get; } = new( 26 ) { { 0, $"{mogh}サンドリア" }, { 1, $"{mogh}バストゥーク" }, { 2, $"{mogh}ウィンダス" }, { 3, $"{mogh}ジュノ" }, { 4, $"{mogh}アトルガン" },
            { 05, $"サポート{jobg}" }, { 6, "フェイス取得：サンドリア" }, { 7, "フェイス取得：バストゥーク" }, { 8, "フェイス取得：ウィンダス" }, { 9, "チョコボ乗り免許証取得" },
            { 10, $"{PLD}{jobg}" }, { 11, $"{DRK}{jobg}" }, { 12, $"{BST}{jobg}" }, { 13, $"{BRD}{jobg}" }, { 14, $"{RNG}{jobg}" },
            { 15, $"{SAM}{jobg}" }, { 16, $"{NIN}{jobg}" }, { 17, $"{DRG}{jobg}" }, { 18, $"{SMN}{jobg}" }, { 19, $"{BLU}{jobg}" },
            { 20, $"{COR}{jobg}" }, { 21, $"{PUP}{jobg}" }, { 22, $"{DNC}{jobg}" }, { 23, $"{SCH}{jobg}" }, { 24, $"{GEO}{jobg}" }, { 25, $"{RUN}{jobg}" } };
        internal Dic EmiTutorialArtifact { get; } = new( 66 ) { { 0, $"{WAR}{af}1" }, { 1, $"{WAR}{af}2" }, { 2, $"{WAR}{af}3" }, { 3, $"{MNK}{af}1" }, { 4, $"{MNK}{af}2" }, { 5, $"{MNK}{af}3" },
            { 06, $"{WHM}{af}1" }, { 07, $"{WHM}{af}2" }, { 08, $"{WHM}{af}3" }, { 09, $"{BLM}{af}1" }, { 10, $"{BLM}{af}2" }, { 11, $"{BLM}{af}3" },
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
        internal Dic EmiTutorialGrowth { get; } = new( 5 ) { { 0, "メリットポイント解放" }, { 1, "武神流秘奥義解放" }, { 2, "ジョブポイント解放" }, { 3, "フェイスポイント解放" }, { 4, "マスターレベル解放" } };
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
        internal Dic EmiContentDynamis { get; } = new( 36 ) { { 30, $"{DynamisSandOria}に進入する" }, { 0, $"{to}Overlord's Tombstone" }, { 1, $"{to}Bladeburner Rokgevok" },
            { 02, $"{to}Steelshank Kratzvatz" }, { 3, $"{to}Bloodfist Voshgrosh" }, { 4, $"{to}Spellspear Djokvukk" },
            { 31, $"{DynamisBastok}に進入する" }, { 5, $"{to}Gu'Dha Effigy" }, { 6, $"{to}Zo'Pha Forgesoul" },
            { 07, $"{to}Ra'Gho Darkfound" }, { 8, $"{to}Va'Zhe Pummelsong" }, { 9, $"{to}Bu'Bho Truesteel" },
            { 32, $"{DynamisWindurst}に進入する" }, { 10, $"{to}Tzee Xicu Idol" }, { 11, $"{to}Xuu Bhoqa the Enigma" },
            { 12, $"{to}Fuu Tzapo the Blessed" }, { 13, $"{to}Naa Yixo the Stillrage" }, { 14, $"{to}Tee Zaksa the Ceaseless" },
            { 33, $"{DynamisJeuno}に進入する" }, { 15, $"{to}Goblin Golem" }, { 16, $"{to}Quicktrix Hexhands" },
            { 17, $"{to}Feralox Honeylips" }, { 18, $"{to}Scourquix Scaleskin" }, { 19, $"{to}Wilywox Tenderpalm" },
            { 34, $"{DynamisBeaucedine}に進入する" }, { 20, $"{to}Angra Mainyu" }, { 21, $"{to}Taquede" },
            { 22, $"{to}Pignonpausard" }, { 23, $"{to}Hitaume" }, { 24, $"{to}Cavanneche" },
            { 35, $"{DynamisXarcabard}に進入する" }, { 25, $"{to}Dynamis Lord" }, { 26, $"{to}Duke Haures" },
            { 27, $"{to}Marquis Caim" }, { 28, $"{to}Baron Avnas" }, { 29, $"{to}Count Haagenti" }, };
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
        #region アイテム
        internal Itm StorageSlip01 { get; } = new( 168 ) {   // 11-8
            { 16084, "アレスマスク" }, { 14546, "アレスキュイラス" }, { 14961, "アレスガントレット" }, { 15625, "アレスフランチャー" }, { 15711, "アレスソルレット" },
            { 16085, "エニュオマスク" }, { 14547, "エニュオプレート" }, { 14962, "エニュオガントレ" }, { 15626, "エニュオクウィス" }, { 15712, "エニュオレギンス" },
            { 16086, "フォボスマスク" }, { 14548, "フォボスキュイラス" }, { 14963, "フォボスガントレ" }, { 15627, "フォボスクウィス" }, { 15713, "フォボスサバトン" },
            { 16087, "ダイモスマスク" }, { 14549, "ダイモスキュイラス" }, { 14964, "ダイモスガントレ" }, { 15628, "ダイモスクウィス" }, { 15714, "ダイモスレギンス" },
            { 16088, "スカディバイザー" }, { 14550, "スカディクウィリ" }, { 14965, "スカディバズバンド" }, { 15629, "スカディショウス" }, { 15715, "スカディジャンボー" },
            { 16089, "ニョルドマスク" }, { 14551, "ニョルドジャーキン" }, { 14966, "ニョルドグローブ" }, { 15630, "ニョルドトラウザ" }, { 15716, "ニョルドレデルセン" },
            { 16090, "フレイマスク" }, { 14552, "フレイジャーキン" }, { 14967, "フレイグローブ" }, { 15631, "フレイトラウザ" }, { 15717, "フレイレデルセン" },
            { 16091, "フレイヤマスク" }, { 14553, "フレイヤジャーキン" }, { 14968, "フレイヤグローブ" }, { 15632, "フレイヤトラウザ" }, { 15718, "フレイヤレデルセン" },
            { 16092, "薄金総面" }, { 14554, "薄金腹巻" }, { 14969, "薄金篭手" }, { 15633, "薄金膝甲" }, { 15719, "薄金脛当" },
            { 16093, "星数鉢巻" }, { 14555, "星数の衣" }, { 14970, "星数の手甲" }, { 15634, "星数の袴" }, { 15720, "星数の脚絆" },
            { 16094, "月数陣鉢" }, { 14556, "月数闘着" }, { 14971, "月数篭手" }, { 15635, "月数佩楯" }, { 15721, "月数脛当" },
            { 16095, "日数兜" }, { 14557, "日数腹当" }, { 14972, "日数篭手" }, { 15636, "日数の袴" }, { 15722, "日数脛当" },
            { 16096, "マルドゥクティアラ" }, { 14558, "マルドゥクジュバ" }, { 14973, "マルドゥクダスタナ" }, { 15637, "マルドゥクシャルワ" }, { 15723, "マルドゥククラッコ" },
            { 16097, "アヌティアラ" }, { 14559, "アヌダブレット" }, { 14974, "アヌゲージ" }, { 15638, "アヌブレー" }, { 15724, "アヌゲートル" },
            { 16098, "エアティアラ" }, { 14560, "エアダブレット" }, { 14975, "エアダスタナ" }, { 15639, "エアブレー" }, { 15725, "エアクラッコー" },
            { 16099, "エンリルティアラ" }, { 14561, "エンリルガンビスン" }, { 14976, "エンリルコッルク" }, { 15640, "エンリルブレエット" }, { 15726, "エンリルガンビエラ" },
            { 16100, "モリガンコロナル" }, { 14562, "モリガンローブ" }, { 14977, "モリガンカフス" }, { 15641, "モリガンスロップス" }, { 15727, "モリガンピガッシュ" },
            { 16101, "ネヴァンクラウン" }, { 14563, "ネヴァンローブ" }, { 14978, "ネヴァンカフス" }, { 15642, "ネヴァンスロップス" }, { 15728, "ネヴァンサボ" },
            { 16102, "バーブクラウン" }, { 14564, "バーブローブ" }, { 14979, "バーブカフス" }, { 15643, "バーブスロップス" }, { 15729, "バーブピガッシュ" },
            { 16103, "マッハクラウン" }, { 14565, "マッハコート" }, { 14980, "マッハカフス" }, { 15644, "マッハスロップス" }, { 15730, "マッハピガッシュ" },
            { 16106, "アスカルツッケット" }, { 14568, "アスカルコラジン" }, { 14983, "アスカルマノポラ" }, { 15647, "アスカルディル" }, { 15733, "アスカルガンビエラ" },
            { 16107, "デナリボンネット" }, { 14569, "デナリジャケット" }, { 14984, "デナリリスト" }, { 15648, "デナリケックス" }, { 15734, "デナリゲマッシュ" },
            { 16108, "ゴリアードシャポー" }, { 14570, "ゴリアードサイオ" }, { 14985, "ゴリアードカフス" }, { 15649, "ゴリアードトルーズ" }, { 15735, "ゴリアードクロッグ" },
            { 16602, "ペルデュソード" }, { 17741, "ペルデュハンガー" }, { 18425, "ペルデュブレード" },
            { 18491, "ペルデュヴォウジェ" }, { 18588, "ペルデュスタッフ" }, { 18717, "ペルデュボウ" },
            { 18718, "ペルデュクロスボウ" }, { 18850, "ペルデュワンド" }, { 18943, "ペルデュシックル" },
            { 16069, "ペルワンカランスワ" }, { 14530, "ペルワンカザガンド" }, { 14940, "ペルワンダスタナ" }, { 15609, "ペルワンサラウィル" }, { 15695, "ペルワンクラッコー" },
            { 16062, "アミールバグリー" }, { 14525, "アミールコラジン" }, { 14933, "アミールコッルク" }, { 15604, "アミールディル" }, { 15688, "アミールブーツ" },
            { 16064, "イギトターバン" }, { 14527, "イギトゴムレフ" }, { 14935, "イギトゲージ" }, { 15606, "イギトサラウィル" }, { 15690, "イギトクラッコー" },
            { 18685, "インペリアルカマン" }, { 18065, "ストームザグナル" }, { 17851, "ストームファイフ" }, { 18686, "インペリアルガン" }, { 18025, "クファンジャル" },
            { 18435, "蛍丸" }, { 18113, "インペリアルネザ" }, { 17951, "ストームタバール" }, { 17715, "ストームタルワール" }, { 18485, "インペリアルブージ" },
            { 18408, "イギトブラワ" }, { 18365, "ペルワンパタ" }, { 18583, "インペリアルポール" }, { 18417, "小夜左文字" }, { 18388, "ドゥームブリンガー" },
            { 16267, "リッターゴルゲット" }, { 16268, "倶毘羅の数珠" }, { 16269, "モルガナチョーカー" },
            { 16228, "アスランケープ" }, { 16229, "グリーマンケープ" }, { 15911, "バッカニアベルト" },
            { 15799, "イオタリング" }, { 15800, "オメガリング" }, { 15990, "デルタピアス" },
            { 17745, "ホフド" }, { 18121, "バルキリーフォーク" }, { 16117, "ヴァルハラヘルム" }, { 14577, "ヴァルハラブレスト" }, { 17857, "ストリンガー+" } };
        internal Itm StorageSlip02 { get; } = new( 155 ) {   // 10-11
            { 12421, "ケーニヒシャレル" }, { 12549, "ケーニヒキューラス" }, { 12677, "ケーニヒハントシュ" }, { 12805, "ケーニヒディヒリン" }, { 12933, "ケーニヒシュー" },
            { 13911, "カイザーシャレル" }, { 14370, "カイザーキューラス" }, { 14061, "カイザーハントシュ" }, { 14283, "カイザーディヒリン" }, { 14163, "カイザーシュー" },
            { 12429, "アダマンチェラータ" }, { 12557, "アダマンホーバーク" }, { 12685, "アダマンマフラ" }, { 12813, "アダマンブリーチズ" }, { 12941, "アダマンソルレット" },
            { 13924, "アルマダチェラータ" }, { 14371, "アルマダホーバーク" }, { 14816, "アルマダマフラ" }, { 14296, "アルマダブリーチズ" }, { 14175, "アルマダソルレット" },
            { 13934, "修羅頭成兜" }, { 14387, "修羅闘着" }, { 14821, "修羅篠篭手" }, { 14303, "修羅板佩楯" }, { 14184, "修羅篠脛当" },
            { 13935, "修羅頭成兜改" }, { 14388, "修羅闘着改" }, { 14822, "修羅篠篭手改" }, { 14304, "修羅板佩楯改" }, { 14185, "修羅篠脛当改" },
            { 13876, "ゼニスクラウン" }, { 13787, "ダルマティカ" }, { 14006, "ゼニスミトン" }, { 14247, "ゼニスズボン" }, { 14123, "ゼニスパンプス" },
            { 13877, "ゼニスクラウン+1" }, { 13788, "ダルマティカ+1" }, { 14007, "ゼニスミトン+1" }, { 14248, "ゼニスズボン+1" }, { 14124, "ゼニスパンプス+1" },
            { 13908, "クリムゾンマスク" }, { 14367, "クリムゾンスケイル" }, { 14058, "クリムゾンフィンガ" }, { 14280, "クリムゾンクウィス" }, { 14160, "クリムゾングリーヴ" },
            { 13909, "ブラッドマスク" }, { 14368, "ブラッドスケイル" }, { 14059, "ブラッドフィンガー" }, { 14281, "ブラッドクウィス" }, { 14161, "ブラッドグリーヴ" },
            { 16113, "シャドウヘルム" }, { 14573, "シャドウプレート" }, { 14995, "シャドウガントレ" }, { 15655, "シャドウクイシュ" }, { 15740, "シャドウサバトン" },
            { 16115, "シャドウハット" }, { 14575, "シャドウコート" }, { 14997, "シャドウカフス" }, { 15657, "シャドウトルーズ" }, { 15742, "シャドウクロッグ" },
            { 16114, "バルキリーヘルム" }, { 14574, "バルキリープレート" }, { 14996, "バルキリーガントレ" }, { 15656, "バルキリークイシュ" }, { 15741, "バルキリーサバトン" },
            { 16116, "バルキリーハット" }, { 14576, "バルキリーコート" }, { 14998, "バルキリーカフス" }, { 15658, "バルキリートルーズ" }, { 15743, "バルキリークロッグ" },
            { 12818, "白虎佩楯" }, { 18198, "白虎斧" }, { 12946, "朱雀脛当" }, { 18043, "朱雀戈" }, { 12690, "青龍篭手" }, { 17659, "青龍刀" }, { 12296, "玄武盾" }, { 12434, "玄武兜" },
            { 15471, "慈悲の羽衣" }, { 15472, "施療の羽衣" }, { 15473, "慧敏の羽衣" },
            { 15508, "ジャスティストルク" }, { 15509, "ホープトルク" }, { 15510, "プルーデンストルク" }, { 15511, "フォーテテュトルク" }, { 15512, "フェイストルク" }, { 15513, "テンペランストルク" }, { 15514, "ラヴトルク" },
            { 17710, "ジャスティスソード" }, { 17595, "ホープスタッフ" }, { 18397, "プルーデンスロッド" }, { 18360, "フェイスバグナウ" }, { 18222, "フォーテテュアクス" }, { 17948, "テンペランスアクス" }, { 18100, "ラヴハルバード" },
            { 15475, "チャージャーマント" }, { 15476, "イェーガーマント" }, { 15477, "ボクサーマント" }, { 15488, "ガンナーマント" },
            { 15961, "ミュージックピアス" }, { 14815, "ステルスピアス" }, { 14812, "ロケイシャスピアス" }, { 14813, "ブルタルピアス" }, { 15244, "フラーレスリボン" },
            { 15240, "ホマムツッケット" }, { 14488, "ホマムコラッツァ" }, { 14905, "ホマムマノポラ" }, { 15576, "ホマムコッシャレ" }, { 15661, "ホマムガンビエラ" },
            { 15241, "ナシラターバン" }, { 14489, "ナシラマンティル" }, { 14906, "ナシラゲージ" }, { 15577, "ナシラサラウィル" }, { 15662, "ナシラクラッコー" },
            { 13927, "ヘカトンキャップ" }, { 14378, "ヘカトンハーネス" }, { 14076, "ヘカトンミトン" }, { 14308, "ヘカトンサブリガ" }, { 14180, "ヘカトンレギンス" },
            { 13928, "ヘカトンキャップ+1" }, { 14379, "ヘカトンハーネス+1" }, { 14077, "ヘカトンミトン+1" }, { 14309, "ヘカトンサブリガ+1" }, { 14181, "ヘカトンレギンス+1" },
            { 10438, "エニフツッケット" }, { 10276, "エニフコラッツァ" }, { 10320, "エニフマノポラ" }, { 10326, "エニフコッシャレ" }, { 10367, "エニフガンビエラ" },
            { 10439, "アダーラターバン" }, { 10277, "アダーラマンティル" }, { 10321, "アダーラゲージ" }, { 10327, "アダーラサラウィル" }, { 10368, "アダーラクラッコー" },
            { 10440, "ムルジムツッケット" }, { 10278, "ムルジムコラッツァ" }, { 10322, "ムルジムマノポラ" }, { 10328, "ムルジムコッシャレ" }, { 10369, "ムルジムガンビエラ" },
            { 10441, "シェダルターバン" }, { 10279, "シェダルマンティル" }, { 10323, "シェダルゲージ" }, { 10329, "シェダルサラウィル" }, { 10370, "シェダルクラッコー" },
            { 25734, "ピエージェシャツ" }, { 25735, "アヤメシャツ" }, { 25736, "I.シールドシャツ" }, { 25737, "アプルルシャツ" }, { 25738, "マートシャツ" },
            { 25739, "アルドシャツ" }, { 25740, "ジャコシャツ" }, { 25741, "ナジャシャツ" }, { 25742, "フラヴィリアシャツ" }, { 25743, "ヨランオランシャツ" }, { 25744, "シルヴィシャツ" } };
        internal Itm StorageSlip03 { get; } = new( 152 ) {   // 10-8
            { 16155, "オーラムアーメット" }, { 11282, "オーラムキュイラス" }, { 15021, "オーラムガントレ" }, { 16341, "オーラムクウィス" }, { 11376, "オーラムサバトン" },
            { 16156, "オラクルキャップ" }, { 11283, "オラクルローブ" }, { 15022, "オラクルグローブ" }, { 16342, "オラクルブラコーニ" }, { 11377, "オラクルピガッシュ" },
            { 16157, "エンキドゥキャップ" }, { 11284, "エンキドゥハーネス" }, { 15023, "エンキドゥミトン" }, { 16343, "エンキドゥサブリガ" }, { 11378, "エンキドゥレギンス" },
            { 16148, "コブラキャップ" }, { 14590, "コブラハーネス" }, { 15011, "コブラミトン" }, { 16317, "コブラサブリガ" }, { 15757, "コブラレギンス" },
            { 16143, "コブラハット" }, { 14591, "コブラローブ" }, { 15012, "コブラグローブ" }, { 16318, "コブラトルーズ" }, { 15758, "コブラクラッコー" },
            { 16146, "ラムサリット" }, { 14588, "ラムホーバーク" }, { 15009, "ラムダスタナ" }, { 16315, "ラムホーズ" }, { 15755, "ラムグリーヴ" },
            { 16147, "フォースハウベ" }, { 14589, "フォースブリュネ" }, { 15010, "フォースヘンツェ" }, { 16316, "フォースショース" }, { 15756, "フォースシュー" },
            { 15966, "フォックスピアス" }, { 15967, "テンプルピアス" }, { 19041, "ローズストラップ" }, { 17684, "グリフィンの爪" }, { 17685, "レクスタリオニス" },
            { 11636, "王立騎士団認印指輪" }, { 15844, "パトローナスリング" }, { 15934, "クリムゾンベルト" }, { 16258, "アレスターマント" }, { 18735, "ソニアプレクトラム" },
            { 18734, "シュトルムリポート" }, { 16291, "シールドカラー" }, { 16292, "ブルネックレス" }, { 19042, "エアリーズグリップ" }, { 15935, "カプリコンロープ" },
            { 16293, "クーガーペンダント" }, { 16294, "クロコダイルカラー" }, { 15936, "アーシーベルト" }, { 18618, "サムドラ" }, { 11588, "連邦傭兵団長の護符" },
            { 11545, "第四共和軍団マント" }, { 16158, "ジャナッドヘルム" }, { 16159, "ジャ・ゴ・バルバト" }, { 16160, "ハバロヘッドギア" },
            { 16149, "コブラクロシュ" }, { 14583, "コブラコート" }, { 15007, "コブラカフス" }, { 16314, "コブラスロップス" }, { 15751, "コブラピガッシュ" },
            { 16141, "ラムヘルム" }, { 14581, "ラムチェーンメイル" }, { 15005, "ラムマフラ" }, { 16312, "ラムブリーチズ" }, { 15749, "ラムソルレット" },
            { 16142, "フォースアーメット" }, { 14582, "フォースキュイラス" }, { 15006, "フォースガントレ" }, { 16313, "フォースクウィス" }, { 15750, "フォースサバトン" },
            { 10876, "オジエヘルム" }, { 10450, "オジエサーコート" }, { 10500, "オジエガントレット" }, { 11969, "オジエブリーチズ" }, { 10600, "オジエレギンス" },
            { 10877, "アトスシャポー" }, { 10451, "アトスタバード" }, { 10501, "アトスグローブ" }, { 11970, "アトスタイツ" }, { 10601, "アトスブーツ" },
            { 10878, "ルベウスバンド" }, { 10452, "ルベウスジャケット" }, { 10502, "ルベウスグローブ" }, { 11971, "ルベウススパッツ" }, { 10602, "ルベウスブーツ" },
            { 19132, "トワイライトナイフ" }, { 18551, "トワイライトサイズ" }, { 11798, "トワイライトヘルム" }, { 11362, "トワイライトメイル" }, { 11363, "トワイライトプリス" },
            { 11625, "黄昏の光輪" }, { 15959, "黄昏の帯" }, { 16259, "黄昏の羽衣" }, { 22299, "完璧な幸運の卵" }, { 26414, "ペアリシールド" },
            { 21623, "ペアリソード" }, { 26219, "ナジの包帯" }, { 21886, "エーペトス" }, { 23792, "ザイアメクード" },
            { 23793, "ザイアメペティ" }, { 23794, "ザイアメバズバンド" }, { 23795, "ザイアメシャルバル" }, { 23796, "ザイアメネール" },
            { 22032, "雷槌" }, { 22043, "アプカルセプター" }, { 21530, "独鈷杵" }, { 22044, "天狗の葉団扇" }, { 26273, "天狗の隠れ蓑" },
            { 25415, "共和プラチナ章" }, { 25416, "シビルスカーフ" }, { 25414, "上級近衛騎士カラー" },
            { 22050, "チャックチャック" }, { 22302, "オシャシャの原論文" }, { 26365, "コーネリアの黒帯" }, { 26366, "プラチナモグベルト" },
            { 23862, "ブードックスマスク" }, { 23863, "ブードックススーツ" }, { 23864, "マッグビフマスク" }, { 23865, "マッグビフスーツ" }, { 21536, "ダッツボグナックル" },
            { 24276, "CSチュニック+1" }, { 24283, "CSMグローブ+1" }, { 24290, "CSズボン+1" }, { 24297, "CSMブーツ+1" },
            { 24277, "CSベスト+1" }, { 24284, "CSFグローブ+1" }, { 24291, "CSパンツ+1" }, { 24298, "CSFブーツ+1" },
            { 24278, "MGジャーキン+1" }, { 24285, "MGガントレット+1" }, { 24292, "MGMショウス+1" }, { 24299, "MGMレデルセン+1" },
            { 24279, "MGボディス+1" }, { 24286, "MGグローブ+1" }, { 24293, "MGFショウス+1" }, { 24300, "MGFレデルセン+1" },
            { 24280, "WNカフタン+1" }, { 24287, "WNミトン+1" }, { 24294, "WNブラッカエ+1" }, { 24301, "WNクロンプ+1" },
            { 24281, "SVセパレーツ+1" }, { 24288, "SVガントレット+1" }, { 24295, "SVロインクロス+1" }, { 24302, "SVゲートル+1" },
            { 24282, "ELサーコート+1" }, { 24289, "ELブレーサー+1" }, { 24296, "ELブラケット+1" }, { 24303, "ELサンダル+1" } };
        internal Itm StorageSlip04 { get; } = new( 138 ) {   // 9-10
            { 12511, "ファイターマスク" }, { 12638, "ファイターロリカ" }, { 13961, "ファイターマフラ" }, { 14214, "ファイタークウィス" }, { 14089, "ファイターカリガ" },
            { 12512, "テンプルクラウン" }, { 12639, "テンプルシクラス" }, { 13962, "テンプルグローブ" }, { 14215, "テンプルホーズ" }, { 14090, "テンプルゲートル" },
            { 13855, "ヒーラーキャップ" }, { 12640, "ヒーラーブリオー" }, { 13963, "ヒーラーミトン" }, { 14216, "ヒーラーパンタロン" }, { 14091, "ヒーラーダックビル" },
            { 13856, "ウィザードペタソス" }, { 12641, "ウィザードコート" }, { 13964, "ウィザードグローブ" }, { 14217, "ウィザードトンバン" }, { 14092, "ウィザードサボ" },
            { 12513, "ワーロックシャポー" }, { 12642, "ワーロックタバード" }, { 13965, "ワーロックグローブ" }, { 14218, "ワーロックタイツ" }, { 14093, "ワーロックブーツ" },
            { 12514, "ローグボンネット" }, { 12643, "ローグベスト" }, { 13966, "ローグアームレット" }, { 14219, "ローグキュロット" }, { 14094, "ローグプーレーヌ" },
            { 12515, "ガラントコロネット" }, { 12644, "ガラントサーコート" }, { 13967, "ガラントガントレ" }, { 14220, "ガラントブリーチズ" }, { 14095, "ガラントレギンス" },
            { 12516, "カオスバーゴネット" }, { 12645, "カオスキュイラス" }, { 13968, "カオスガントレット" }, { 14221, "カオスフランチャー" }, { 14096, "カオスソルレット" },
            { 12517, "ビーストヘルム" }, { 12646, "ビーストジャック" }, { 13969, "ビーストグローブ" }, { 14222, "ビーストトラウザ" }, { 14097, "ビーストゲートル" },
            { 13857, "コラルラウンドリト" }, { 12647, "コラルジュストコル" }, { 13970, "コラルカフス" }, { 14223, "コラルキャニオンズ" }, { 14098, "コラルスリッパー" },
            { 12518, "ハンターベレー" }, { 12648, "ハンタージャーキン" }, { 13971, "ハンターブレーサー" }, { 14224, "ハンターブラッカエ" }, { 14099, "ハンターソックス" },
            { 13868, "明珍桃形兜" }, { 13781, "明珍胴丸" }, { 13972, "明珍筒篭手" }, { 14225, "明珍板佩楯" }, { 14100, "明珍筒脛当" },
            { 13869, "乱波半首" }, { 13782, "乱波鎖帷子" }, { 13973, "乱波手甲" }, { 14226, "乱波袴" }, { 14101, "乱波脚絆" },
            { 12519, "ドラケンアーメット" }, { 12649, "ドラケンメイル" }, { 13974, "ドラケンフィンガー" }, { 14227, "ドラケンブレー" }, { 14102, "ドラケングリーヴ" },
            { 12520, "エボカーホーン" }, { 12650, "エボカーダブレット" }, { 13975, "エボカーブレーサー" }, { 14228, "エボカースパッツ" }, { 14103, "エボカーピガッシュ" },
            { 15265, "メガスケフィエ" }, { 14521, "メガスジュバ" }, { 14928, "メガスバズバンド" }, { 15600, "メガスシャルワー" }, { 15684, "メガスチャルク" },
            { 15266, "コルセアトリコルヌ" }, { 14522, "コルセアフラック" }, { 14929, "コルセアガントリー" }, { 15601, "コルセアトルーズ" }, { 15685, "コルセアブーツ" },
            { 15267, "パペトリタージ" }, { 14523, "パペトリトベ" }, { 14930, "パペトリダスタナ" }, { 15602, "パペトリチュリダル" }, { 15686, "パペトリバブーシュ" },
            { 16138, "ダンサーティアラ" }, { 14578, "ダンサーカザク" }, { 15002, "ダンサーバングル" }, { 15659, "ダンサータイツ" }, { 15746, "ダンサートーシュー" },
            { 16139, "ダンサーティアラ" }, { 14579, "ダンサーカザク" }, { 15003, "ダンサーバングル" }, { 15660, "ダンサータイツ" }, { 15747, "ダンサートーシュー" },
            { 16140, "スカラーボード" }, { 14580, "スカラーガウン" }, { 15004, "スカラーブレーサー" }, { 16311, "スカラーパンツ" }, { 15748, "スカラーローファー" },
            { 16678, "レイザーアクス" }, { 17478, "ビートセスタス" }, { 17422, "ブレスドハンマー" }, { 17423, "キャストワンド" }, { 16829, "フェンスデーゲン" },
            { 16764, "マローダーナイフ" }, { 17643, "オナーソード" }, { 16798, "レイヴンサイズ" }, { 16680, "バルバロイアクス" }, { 16766, "ペーパーナイフ" },
            { 17188, "スナイプボウ" }, { 17812, "孫六兼元" }, { 17771, "安寿" }, { 17772, "厨子王" }, { 16887, "ペレグリン" },
            { 17532, "ククルカンスタッフ" }, { 17717, "イモータルシミター" }, { 18702, "トランプガン" }, { 17858, "ターボストリンガー" }, { 19203, "ウォーフープ" },
            { 21461, "フィリエベル" }, { 21124, "ダウザーワンド" }, { 20776, "ベオルクソード" },
            { 27786, "ジオガレーロ" }, { 27926, "ジオチュニック" }, { 28066, "ジオミテーヌ" }, { 28206, "ジオパンツ" }, { 28346, "ジオサンダル" },
            { 27787, "ルーニストバンド" }, { 27927, "ルーニストコート" }, { 28067, "ルーニストミトン" }, { 28207, "ルーニストトラウザ" }, { 28347, "ルーニストブーツ" } };
        internal Itm StorageSlip05 { get; } = new( 105 ) {   // 7-9
            { 15225, "FTマスク+1" }, { 14473, "FTロリカ+1" }, { 14890, "FTマフラ+1" }, { 15561, "FTクウィス+1" }, { 15352, "FTカリガ+1" },
            { 15226, "TPクラウン+1" }, { 14474, "TPシクラス+1" }, { 14891, "TPグローブ+1" }, { 15562, "TPホーズ+1" }, { 15353, "TPゲートル+1" },
            { 15227, "HLキャップ+1" }, { 14475, "HLブリオー+1" }, { 14892, "HLミトン+1" }, { 15563, "HLパンタロン+1" }, { 15354, "HLダックビル+1" },
            { 15228, "WZペタソス+1" }, { 14476, "WZコート+1" }, { 14893, "WZグローブ+1" }, { 15564, "WZトンバン+1" }, { 15355, "WZサボ+1" },
            { 15229, "WLシャポー+1" }, { 14477, "WLタバード+1" }, { 14894, "WLグローブ+1" }, { 15565, "WLタイツ+1" }, { 15356, "WLブーツ+1" },
            { 15230, "ROボンネット+1" }, { 14478, "ROベスト+1" }, { 14895, "ROアームレット+1" }, { 15566, "ROキュロット+1" }, { 15357, "ROプーレーヌ+1" },
            { 15231, "GLコロネット+1" }, { 14479, "GLサーコート+1" }, { 14896, "GLガントレ+1" }, { 15567, "GLブリーチズ+1" }, { 15358, "GLレギンス+1" },
            { 15232, "CSバーゴネット+1" }, { 14480, "CSキュイラス+1" }, { 14897, "CSガントレット+1" }, { 15568, "CSフランチャー+1" }, { 15359, "CSソルレット+1" },
            { 15233, "BTヘルム+1" }, { 14481, "BTジャック+1" }, { 14898, "BTグローブ+1" }, { 15569, "BTトラウザ+1" }, { 15360, "BTゲートル+1" },
            { 15234, "CHラウンドリト+1" }, { 14482, "CHジュストコル+1" }, { 14899, "CHカフス+1" }, { 15570, "CHキャニオンズ+1" }, { 15361, "CHスリッパー+1" },
            { 15235, "HTベレー+1" }, { 14483, "HTジャーキン+1" }, { 14900, "HTブレーサー+1" }, { 15571, "HTブラッカエ+1" }, { 15362, "HTソックス+1" },
            { 15236, "明珍桃形兜改" }, { 14484, "明珍胴丸改" }, { 14901, "明珍筒篭手改" }, { 15572, "明珍板佩楯改" }, { 15363, "明珍筒脛当改" },
            { 15237, "乱波半首改" }, { 14485, "乱波鎖帷子改" }, { 14902, "乱波手甲改" }, { 15573, "乱波袴改" }, { 15364, "乱波脚絆改" },
            { 15238, "DCアーメット+1" }, { 14486, "DCメイル+1" }, { 14903, "DCフィンガー+1" }, { 15574, "DCブレー+1" }, { 15365, "DCグリーヴ+1" },
            { 15239, "EKホーン+1" }, { 14487, "EKダブレット+1" }, { 14904, "EKブレーサー+1" }, { 15575, "EKスパッツ+1" }, { 15366, "EKピガッシュ+1" },
            { 11464, "MGケフィエ+1" }, { 11291, "MGジュバ+1" }, { 15024, "MGバズバンド+1" }, { 16345, "MGシャルワー+1" }, { 11381, "MGチャルク+1" },
            { 11467, "COトリコルヌ+1" }, { 11294, "COフラック+1" }, { 15027, "COガントリー+1" }, { 16348, "COブーツ+1" }, { 11384, "COトルーズ+1" },
            { 11470, "PTタージ+1" }, { 11297, "PTトベ+1" }, { 15030, "PTダスタナ+1" }, { 16351, "PTチュリダル+1" }, { 11387, "PTバブーシュ+1" },
            { 11475, "DRティアラ+1" }, { 11302, "DRカザク+1" }, { 15035, "DRバングル+1" }, { 16357, "DRタイツ+1" }, { 11393, "DRトーシュー+1" },
            { 11476, "DRティアラ+1" }, { 11303, "DRカザク+1" }, { 15036, "DRバングル+1" }, { 16358, "DRタイツ+1" }, { 11394, "DRトーシュー+1" },
            { 11477, "SLボード+1" }, { 11304, "SLガウン+1" }, { 15037, "SLブレーサー+1" }, { 16359, "SLパンツ+1" }, { 11395, "SLローファー+1" } };
        internal Itm StorageSlip06 { get; } = new( 120 ) {   // 8-8
            { 15072, "ウォリアーマスク" }, { 15087, "ウォリアーロリカ" }, { 15102, "ウォリアーマフラ" }, { 15117, "ウォリアークウィス" }, { 15132, "ウォリアーカリガ" }, { 15871, "ウォリアーストーン" },
            { 15073, "メレークラウン" }, { 15088, "メレーシクラス" }, { 15103, "メレーグローブ" }, { 15118, "メレーホーズ" }, { 15133, "メレーゲートル" }, { 15478, "メレーケープ" },
            { 15074, "クレリクキャップ" }, { 15089, "クレリクブリオー" }, { 15104, "クレリクミトン" }, { 15119, "クレリクパンタロン" }, { 15134, "クレリクダックビル" }, { 15872, "クレリクベルト" },
            { 15075, "ソーサラーペタソス" }, { 15090, "ソーサラーコート" }, { 15105, "ソーサラーグローブ" }, { 15120, "ソーサラートンバン" }, { 15135, "ソーサラーサボ" }, { 15874, "ソーサラーベルト" },
            { 15076, "デュエルシャポー" }, { 15091, "デュエルタバード" }, { 15106, "デュエルグローブ" }, { 15121, "デュエルタイツ" }, { 15136, "デュエルブーツ" }, { 15873, "デュエルベルト" },
            { 15077, "アサシンボンネット" }, { 15092, "アサシンベスト" }, { 15107, "アサシンアムレット" }, { 15122, "アサシンキュロット" }, { 15137, "アサシンプーレーヌ" }, { 15480, "アサシンケープ" },
            { 15078, "ヴァラーコロネット" }, { 15093, "ヴァラーサーコート" }, { 15108, "ヴァラーガントレ" }, { 15123, "ヴァラーブリーチズ" }, { 15138, "ヴァラーレギンス" }, { 15481, "ヴァラーケープ" },
            { 15079, "アビスバーゴネット" }, { 15094, "アビスキュイラス" }, { 15109, "アビスガントレット" }, { 15124, "アビスフランチャー" }, { 15139, "アビスソルレット" }, { 15479, "アビスケープ" },
            { 15080, "モンスターヘルム" }, { 15095, "モンスタージャック" }, { 15110, "モンスターグローブ" }, { 15125, "モンスタートラウザ" }, { 15140, "モンスターゲートル" }, { 15875, "モンスターベルト" },
            { 15081, "バードラウンドリト" }, { 15096, "バードジュストコル" }, { 15111, "バードカフス" }, { 15126, "バードキャニオンズ" }, { 15141, "バードスリッパー" }, { 15482, "バードケープ" },
            { 15082, "スカウトベレー" }, { 15097, "スカウトジャーキン" }, { 15112, "スカウトブレーサー" }, { 15127, "スカウトブラッカエ" }, { 15142, "スカウトソックス" }, { 15876, "スカウトベルト" },
            { 15083, "早乙女桃形兜" }, { 15098, "早乙女胴丸" }, { 15113, "早乙女筒篭手" }, { 15128, "早乙女板佩楯" }, { 15143, "早乙女筒脛当" }, { 15879, "早乙女腰当" },
            { 15084, "甲賀半首" }, { 15099, "甲賀鎖帷子" }, { 15114, "甲賀手甲" }, { 15129, "甲賀袴" }, { 15144, "甲賀脚絆" }, { 15877, "甲賀さらし" },
            { 15085, "ウィルムアーメット" }, { 15100, "ウィルムメイル" }, { 15115, "ウィルムフィンガー" }, { 15130, "ウィルムブレー" }, { 15145, "ウィルムグリーヴ" }, { 15878, "ウィルムベルト" },
            { 15086, "サマナーホーン" }, { 15101, "サマナーダブレット" }, { 15116, "サマナーブレーサー" }, { 15131, "サマナースパッツ" }, { 15146, "サマナーピガッシュ" }, { 15484, "サマナーケープ" },
            { 11465, "ミラージケフィエ" }, { 11292, "ミラージジュバ" }, { 15025, "ミラージバズバンド" }, { 16346, "ミラージシャルワー" }, { 11382, "ミラージチャルク" }, { 16244, "ミラージマント" },
            { 11468, "コモドアトリコルヌ" }, { 11295, "コモドアフラック" }, { 15028, "コモドアガントリー" }, { 16349, "コモドアトルーズ" }, { 11385, "コモドアブーツ" }, { 15920, "コモドアベルト" },
            { 11471, "パンタンタージ" }, { 11298, "パンタントベ" }, { 15031, "パンタンダスタナ" }, { 16352, "パンタンチュリダル" }, { 11388, "パンタンバブーシュ" }, { 16245, "パンタンケープ" },
            { 11478, "エトワールティアラ" }, { 11305, "エトワールカザク" }, { 15038, "エトワールバングル" }, { 16360, "エトワールタイツ" }, { 11396, "エトワールシュー" }, { 16248, "エトワールケープ" },
            { 11480, "アギュトボード" }, { 11307, "アギュトガウン" }, { 15040, "アギュトブレーサー" }, { 16362, "アギュトパンツ" }, { 11398, "アギュトローファー" }, { 15925, "アギュトベルト" } };
        internal Itm StorageSlip07 { get; } = new( 100 ) {   // 7-4
            { 15245, "WRマスク+1" }, { 14500, "WRロリカ+1" }, { 14909, "WRマフラ+1" }, { 15580, "WRクウィス+1" }, { 15665, "WRカリガ+1" },
            { 15246, "MLクラウン+1" }, { 14501, "MLシクラス+1" }, { 14910, "MLグローブ+1" }, { 15581, "MLホーズ+1" }, { 15666, "MLゲートル+1" },
            { 15247, "CRキャップ+1" }, { 14502, "CRブリオー+1" }, { 14911, "CRミトン+1" }, { 15582, "CRパンタロン+1" }, { 15667, "CRダックビル+1" },
            { 15248, "SRペタソス+1" }, { 14503, "SRコート+1" }, { 14912, "SRグローブ+1" }, { 15583, "SRトンバン+1" }, { 15668, "SRサボ+1" },
            { 15249, "DLシャポー+1" }, { 14504, "DLタバード+1" }, { 14913, "DLグローブ+1" }, { 15584, "DLタイツ+1" }, { 15669, "DLブーツ+1" },
            { 15250, "ASボンネット+1" }, { 14505, "ASベスト+1" }, { 14914, "ASアムレット+1" }, { 15585, "ASキュロット+1" }, { 15670, "ASプーレーヌ+1" },
            { 15251, "VLコロネット+1" }, { 14506, "VLサーコート+1" }, { 14915, "VLガントレ+1" }, { 15586, "VLブリーチズ+1" }, { 15671, "VLレギンス+1" },
            { 15252, "ABバーゴネット+1" }, { 14507, "ABキュイラス+1" }, { 14916, "ABガントレット+1" }, { 15587, "ABフランチャー+1" }, { 15672, "ABソルレット+1" },
            { 15253, "MSヘルム+1" }, { 14508, "MSジャック+1" }, { 14917, "MSグローブ+1" }, { 15588, "MSトラウザ+1" }, { 15673, "MSゲートル+1" },
            { 15254, "BDラウンドリト+1" }, { 14509, "BDジュストコル+1" }, { 14918, "BDカフス+1" }, { 15589, "BDキャニオンズ+1" }, { 15674, "BDスリッパー+1" },
            { 15255, "SCベレー+1" }, { 14510, "SCジャーキン+1" }, { 14919, "SCブレーサー+1" }, { 15590, "SCブラッカエ+1" }, { 15675, "SCソックス+1" },
            { 15256, "早乙女桃形兜改" }, { 14511, "早乙女胴丸改" }, { 14920, "早乙女筒篭手改" }, { 15591, "早乙女板佩楯改" }, { 15676, "早乙女筒脛当改" },
            { 15257, "甲賀半首改" }, { 14512, "甲賀鎖帷子改" }, { 14921, "甲賀手甲改" }, { 15592, "甲賀袴改" }, { 15677, "甲賀脚絆改" },
            { 15258, "WMアーメット+1" }, { 14513, "WMメイル+1" }, { 14922, "WMフィンガー+1" }, { 15593, "WMブレー+1" }, { 15678, "WMグリーヴ+1" },
            { 15259, "SMホーン+1" }, { 14514, "SMダブレット+1" }, { 14923, "SMブレーサー+1" }, { 15594, "SMスパッツ+1" }, { 15679, "SMピガッシュ+1" },
            { 11466, "MIケフィエ+1" }, { 11293, "MIジュバ+1" }, { 15026, "MIバズバンド+1" }, { 16347, "MIシャルワー+1" }, { 11383, "MIチャルク+1" },
            { 11469, "CMトリコルヌ+1" }, { 11296, "CMフラック+1" }, { 15029, "CMガントリー+1" }, { 16350, "CMトルーズ+1" }, { 11386, "CMブーツ+1" },
            { 11472, "PNタージ+1" }, { 11299, "PNトベ+1" }, { 15032, "PNダスタナ+1" }, { 16353, "PNチュリダル+1" }, { 11389, "PNバブーシュ+1" },
            { 11479, "ETティアラ+1" }, { 11306, "ETカザク+1" }, { 15039, "ETバングル+1" }, { 16361, "ETタイツ+1" }, { 11397, "ETトーシュー+1" },
            { 11481, "AGボード+1" }, { 11308, "AGガウン+1" }, { 15041, "AGブレーサー+1" }, { 16363, "AGパンツ+1" }, { 11399, "AGローファー+1" } };
        internal Itm StorageSlip08 { get; } = new( 160 ) {   // 10-16
            { 12008, "ラベジャーマスク" }, { 12028, "ラベジャーロリカ" }, { 12048, "ラベジャーマフラ" }, { 12068, "ラベジャークウィス" }, { 12088, "ラベジャーカリガ" }, { 11591, "ラベジャーゴルジェ" }, { 19253, "ラベジャーオーブ" },
            { 12009, "タントラクラウン" }, { 12029, "タントラシクラス" }, { 12049, "タントラグローブ" }, { 12069, "タントラホーズ" }, { 12089, "タントラゲートル" }, { 11592, "タントラネックレス" }, { 19254, "タントラタスラム" },
            { 12010, "オリゾンキャップ" }, { 12030, "オリゾンブリオー" }, { 12050, "オリゾンミトン" }, { 12070, "オリゾンパンタロン" }, { 12090, "オリゾンダックビル" }, { 11615, "オリゾンロケット" }, { 11554, "オリゾンケープ" },
            { 12011, "ゴエティアペタソス" }, { 12031, "ゴエティアコート" }, { 12051, "ゴエティアグローブ" }, { 12071, "ゴエティアショウス" }, { 12091, "ゴエティアサボ" }, { 11593, "ゴエティアチェーン" }, { 16203, "ゴエティアマント" },
            { 12012, "エストクルシャペル" }, { 12032, "エストクルサヨン" }, { 12052, "エストクルガントロ" }, { 12072, "エストクルフュゾー" }, { 12092, "エストクルウゾー" }, { 11594, "エストクルカラー" }, { 16204, "エストクルケープ" },
            { 12013, "レイダーボンネット" }, { 12033, "レイダーベスト" }, { 12053, "レイダーアムレット" }, { 12073, "レイダーキュロット" }, { 12093, "レイダープーレーヌ" }, { 11736, "レイダーベルト" }, { 19260, "レイダーブーメラン" },
            { 12014, "クリードアーメット" }, { 12034, "クリードキュイラス" }, { 12054, "クリードガントレ" }, { 12074, "クリードクウィス" }, { 12094, "クリードサバトン" }, { 11595, "クリードカラー" }, { 11750, "クリードボードリエ" },
            { 12015, "ベイルバーゴネット" }, { 12035, "ベイルキュイラス" }, { 12055, "ベイルガントレット" }, { 12075, "ベイルフランチャー" }, { 12095, "ベイルソルレット" }, { 11616, "ベイルチョーカー" }, { 11737, "ベイルベルト" },
            { 12016, "フェリンカバセ" }, { 12036, "フェリンゴーザプ" }, { 12056, "フェリンマノプラス" }, { 12076, "フェリンキホーテ" }, { 12096, "フェリンオクレア" }, { 11617, "フェリンネックレス" }, { 11555, "フェリンマント" },
            { 12017, "アエドキャロ" }, { 12037, "アエドオングルリヌ" }, { 12057, "アエドマンシェト" }, { 12077, "アエドラングラヴ" }, { 12097, "アエドコテュルヌ" }, { 11618, "アエドマティネ" }, { 11738, "アエドベルト" },
            { 12018, "シルバンガペット" }, { 12038, "シルバンカバン" }, { 12058, "シルバングロブレト" }, { 12078, "シルバンブラーグ" }, { 12098, "シルバンボティヨン" }, { 11596, "シルバンスカーフ" }, { 16205, "シルバンクラミュス" },
            { 12019, "雲海烏帽子形兜" }, { 12039, "雲海胴丸" }, { 12059, "雲海筒篭手" }, { 12079, "雲海板佩楯" }, { 12099, "雲海筒脛当" }, { 11597, "雲海喉輪" }, { 16206, "雲海菅蓑" },
            { 12020, "伊賀頭巾" }, { 12040, "伊賀忍着" }, { 12060, "伊賀手甲" }, { 12080, "伊賀袴" }, { 12100, "伊賀脚絆" }, { 11598, "伊賀襟巻" }, { 16207, "伊賀道中合羽" },
            { 12021, "ランサーメザイユ" }, { 12041, "ランサープラカート" }, { 12061, "ランサーバンブレス" }, { 12081, "ランサーキュイソー" }, { 12101, "ランサーシンバルド" }, { 11599, "ランサートルク" }, { 16208, "ランサーペルリーヌ" },
            { 12022, "コーラーホーン" }, { 12042, "コーラーダブレット" }, { 12062, "コーラーブレーサー" }, { 12082, "コーラースパッツ" }, { 12102, "コーラーピガッシュ" }, { 11619, "コーラーペンダント" }, { 11739, "コーラーサッシュ" },
            { 12023, "マーヴィカヴク" }, { 12043, "マーヴィミンタン" }, { 12063, "マーヴィバズバンド" }, { 12083, "マーヴィタイト" }, { 12103, "マーヴィバシュマク" }, { 11600, "マーヴィスカーフ" }, { 19255, "マーヴィタスラム" },
            { 12024, "ナバーチトリコルヌ" }, { 12044, "ナバーチフラック" }, { 12064, "ナバーチガントリー" }, { 12084, "ナバーチトルーズ" }, { 12104, "ナバーチブーツ" }, { 11601, "ナバーチチョーカー" }, { 16209, "ナバーチマント" },
            { 12025, "チルコカペッロ" }, { 12045, "チルコファルセット" }, { 12065, "チルコグアンティ" }, { 12085, "チルコパンタローニ" }, { 12105, "チルコスカルペ" }, { 11602, "チルコネックレス" }, { 11751, "チルコサッシュ" },
            { 12026, "カリスティアラ" }, { 12046, "カリスカザク" }, { 12066, "カリスバングル" }, { 12086, "カリスタイツ" }, { 12106, "カリストーシュー" }, { 11603, "カリスネックレス" }, { 19256, "カリスフェザー" },
            { 12027, "サバントボネット" }, { 12047, "サバントガウン" }, { 12067, "サバントブレーサー" }, { 12087, "サバントパンツ" }, { 12107, "サバントローファー" }, { 11620, "サバントチェーン" }, { 19247, "インカントストーン" },
            { 11703, "ラベジャーピアス" }, { 11704, "タントラピアス" }, { 11705, "オリゾンピアス" }, { 11706, "ゴエティアピアス" }, { 11707, "エストクルピアス" },
            { 11708, "レイダーピアス" }, { 11709, "クリードピアス" }, { 11710, "ベイルピアス" }, { 11711, "フェリンピアス" }, { 11712, "アエドピアス" },
            { 11713, "シルバンピアス" }, { 11714, "雲海耳飾" }, { 11715, "伊賀耳飾" }, { 11716, "ランサーピアス" }, { 11717, "コーラーピアス" },
            { 11718, "マーヴィピアス" }, { 11719, "ナバーチピアス" }, { 11720, "チルコピアス" }, { 11721, "カリスピアス" }, { 11722, "サバントピアス" } };
        internal Itm StorageSlip09 { get; } = new( 100 ) {  // 7-4
            { 11164, "RVマスク+1" }, { 11184, "RVロリカ+1" }, { 11204, "RVマフラ+1" }, { 11224, "RVクウィス+1" }, { 11244, "RVカリガ+1" },
            { 11165, "TTクラウン+1" }, { 11185, "TTシクラス+1" }, { 11205, "TTグローブ+1" }, { 11225, "TTホーズ+1" }, { 11245, "TTゲートル+1" },
            { 11166, "ORキャップ+1" }, { 11186, "ORブリオー+1" }, { 11206, "ORミトン+1" }, { 11226, "ORパンタロン+1" }, { 11246, "ORダックビル+1" },
            { 11167, "GTペタソス+1" }, { 11187, "GTコート+1" }, { 11207, "GTグローブ+1" }, { 11227, "GTショウス+1" }, { 11247, "GTサボ+1" },
            { 11168, "EQシャペル+1" }, { 11188, "EQサヨン+1" }, { 11208, "EQガントロ+1" }, { 11228, "EQフュゾー+1" }, { 11248, "EQウゾー+1" },
            { 11169, "RDボンネット+1" }, { 11189, "RDベスト+1" }, { 11209, "RDアムレット+1" }, { 11229, "RDキュロット+1" }, { 11249, "RDプーレーヌ+1" },
            { 11170, "CDアーメット+1" }, { 11190, "CDキュイラス+1" }, { 11210, "CDガントレ+1" }, { 11230, "CDクウィス+1" }, { 11250, "CDサバトン+1" },
            { 11171, "BLバーゴネット+1" }, { 11191, "BLキュイラス+1" }, { 11211, "BLガントレット+1" }, { 11231, "BLフランチャー+1" }, { 11251, "BLソルレット+1" },
            { 11172, "FRカバセ+1" }, { 11192, "FRゴーザプ+1" }, { 11212, "FRマノプラス+1" }, { 11232, "FRキホーテ+1" }, { 11252, "FRオクレア+1" },
            { 11173, "ADキャロ+1" }, { 11193, "ADオングルリヌ+1" }, { 11213, "ADマンシェト+1" }, { 11233, "ADラングラヴ+1" }, { 11253, "ADコテュルヌ+1" },
            { 11174, "SYガペット+1" }, { 11194, "SYカバン+1" }, { 11214, "SYグロブレト+1" }, { 11234, "SYブラーグ+1" }, { 11254, "SYボティヨン+1" },
            { 11175, "雲海烏帽子形兜改" }, { 11195, "雲海胴丸改" }, { 11215, "雲海筒篭手改" }, { 11235, "雲海板佩楯改" }, { 11255, "雲海筒脛当改" },
            { 11176, "伊賀頭巾改" }, { 11196, "伊賀忍着改" }, { 11216, "伊賀手甲改" }, { 11236, "伊賀袴改" }, { 11256, "伊賀脚絆改" },
            { 11177, "LCメザイユ+1" }, { 11197, "LCプラカート+1" }, { 11217, "LCバンブレス+1" }, { 11237, "LCキュイソー+1" }, { 11257, "LCシンバルド+1" },
            { 11178, "CLホーン+1" }, { 11198, "CLダブレット+1" }, { 11218, "CLブレーサー+1" }, { 11238, "CLスパッツ+1" }, { 11258, "CLピガッシュ+1" },
            { 11179, "MVカヴク+1" }, { 11199, "MVミンタン+1" }, { 11219, "MVバズバンド+1" }, { 11239, "MVタイト+1" }, { 11259, "MVバシュマク+1" },
            { 11180, "NAトリコルヌ+1" }, { 11200, "NAフラック+1" }, { 11220, "NAガントリー+1" }, { 11240, "NAトルーズ+1" }, { 11260, "NAブーツ+1" },
            { 11181, "CCカペッロ+1" }, { 11201, "CCファルセット+1" }, { 11221, "CCグアンティ+1" }, { 11241, "CCパンタローニ+1" }, { 11261, "CCスカルペ+1" },
            { 11182, "CAティアラ+1" }, { 11202, "CAカザク+1" }, { 11222, "CAバングル+1" }, { 11242, "CAタイツ+1" }, { 11262, "CAトーシュー+1" },
            { 11183, "SVボネット+1" }, { 11203, "SVガウン+1" }, { 11223, "SVブレーサー+1" }, { 11243, "SVパンツ+1" }, { 11263, "SVローファー+1" } };
        internal Itm StorageSlip10 { get; } = new( 100 ) {  // 7-4
            { 11064, "RVマスク+2" }, { 11084, "RVロリカ+2" }, { 11104, "RVマフラ+2" }, { 11124, "RVクウィス+2" }, { 11144, "RVカリガ+2" },
            { 11065, "TTクラウン+2" }, { 11085, "TTシクラス+2" }, { 11105, "TTグローブ+2" }, { 11125, "TTホーズ+2" }, { 11145, "TTゲートル+2" },
            { 11066, "ORキャップ+2" }, { 11086, "ORブリオー+2" }, { 11106, "ORミトン+2" }, { 11126, "ORパンタロン+2" }, { 11146, "ORダックビル+2" },
            { 11067, "GTペタソス+2" }, { 11087, "GTコート+2" }, { 11107, "GTグローブ+2" }, { 11127, "GTショウス+2" }, { 11147, "GTサボ+2" },
            { 11068, "EQシャペル+2" }, { 11088, "EQサヨン+2" }, { 11108, "EQガントロ+2" }, { 11128, "EQフュゾー+2" }, { 11148, "EQウゾー+2" },
            { 11069, "RDボンネット+2" }, { 11089, "RDベスト+2" }, { 11109, "RDアムレット+2" }, { 11129, "RDキュロット+2" }, { 11149, "RDプーレーヌ+2" },
            { 11070, "CDアーメット+2" }, { 11090, "CDキュイラス+2" }, { 11110, "CDガントレ+2" }, { 11130, "CDクウィス+2" }, { 11150, "CDサバトン+2" },
            { 11071, "BLバーゴネット+2" }, { 11091, "BLキュイラス+2" }, { 11111, "BLガントレット+2" }, { 11131, "BLフランチャー+2" }, { 11151, "BLソルレット+2" },
            { 11072, "FRカバセ+2" }, { 11092, "FRゴーザプ+2" }, { 11112, "FRマノプラス+2" }, { 11132, "FRキホーテ+2" }, { 11152, "FRオクレア+2" },
            { 11073, "ADキャロ+2" }, { 11093, "ADオングルリヌ+2" }, { 11113, "ADマンシェト+2" }, { 11133, "ADラングラヴ+2" }, { 11153, "ADコテュルヌ+2" },
            { 11074, "SYガペット+2" }, { 11094, "SYカバン+2" }, { 11114, "SYグロブレト+2" }, { 11134, "SYブラーグ+2" }, { 11154, "SYボティヨン+2" },
            { 11075, "真雲海烏帽子形兜" }, { 11095, "真雲海胴丸" }, { 11115, "真雲海筒篭手" }, { 11135, "真雲海板佩楯" }, { 11155, "真雲海筒脛当" },
            { 11076, "真伊賀頭巾" }, { 11096, "真伊賀忍着" }, { 11116, "真伊賀手甲" }, { 11136, "真伊賀袴" }, { 11156, "真伊賀脚絆" },
            { 11077, "LCメザイユ+2" }, { 11097, "LCプラカート+2" }, { 11117, "LCバンブレス+2" }, { 11137, "LCキュイソー+2" }, { 11157, "LCシンバルド+2" },
            { 11078, "CLホーン+2" }, { 11098, "CLダブレット+2" }, { 11118, "CLブレーサー+2" }, { 11138, "CLスパッツ+2" }, { 11158, "CLピガッシュ+2" },
            { 11079, "MVカヴク+2" }, { 11099, "MVミンタン+2" }, { 11119, "MVバズバンド+2" }, { 11139, "MVタイト+2" }, { 11159, "MVバシュマク+2" },
            { 11080, "NAトリコルヌ+2" }, { 11100, "NAフラック+2" }, { 11120, "NAガントリー+2" }, { 11140, "NAトルーズ+2" }, { 11160, "NAブーツ+2" },
            { 11081, "CCカペッロ+2" }, { 11101, "CCファルセット+2" }, { 11121, "CCグアンティ+2" }, { 11141, "CCパンタローニ+2" }, { 11161, "CCスカルペ+2" },
            { 11082, "CAティアラ+2" }, { 11102, "CAカザク+2" }, { 11122, "CAバングル+2" }, { 11142, "CAタイツ+2" }, { 11162, "CAトーシュー+2" },
            { 11083, "SVボネット+2" }, { 11103, "SVガウン+2" }, { 11123, "SVブレーサー+2" }, { 11143, "SVパンツ+2" }, { 11163, "SVローファー+2" } };
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
