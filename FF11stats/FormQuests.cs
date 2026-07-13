using System.Collections.ObjectModel;
using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormQuests : Form
    {
        static int com = 0;
        static int num = 0;
        static string name = string.Empty;

        public FormQuests( ToolStripMenuItem menu )
        {
            InitializeComponent();

            sbyte[] dat = [];
            int i = 0;
            int p = 0;
            CheckBox[] c = new CheckBox[1];
            DisplayStrings ds = new();
            ReadOnlyDictionary<byte, string> rd = new( new Dictionary<byte, string>() );

            name = menu.Name!;
            switch( name ) {
            case "toolStripMenuItem80":
                dat = cd.QuestBastok;
                rd = new( ds.QuestBs );
                Text = $"クエスト/{menu.Text![..^4]}";
                break;
            case "toolStripMenuItem81":
                dat = cd.QuestWindurst;
                rd = new( ds.QuestWs );
                Text = $"クエスト/{menu.Text![..^4]}";
                break;
            case "toolStripMenuItem82":
                dat = cd.QuestJeuno;
                rd = new( ds.QuestJn );
                Text = $"クエスト/{menu.Text![..^4]}";
                break;
            case "toolStripMenuItem84":
                dat = cd.QuestOutlands;
                rd = new( ds.QuestFr );
                Text = $"クエスト/{menu.Text![..^4]}";
                break;
            case "toolStripMenuItem85":
                dat = cd.QuestAhturhgan;
                rd = new( ds.QuestAt );
                Text = $"クエスト/{menu.Text![..^4]}";
                break;
            case "toolStripMenuItem86":
                dat = cd.QuestPast;
                rd = new( ds.QuestWg );
                Text = $"クエスト/{menu.Text![..^4]}";
                break;
            case "toolStripMenuItem87":
                dat = cd.QuestAbyssea;
                rd = new( ds.QuestAb );
                Text = $"クエスト/{menu.Text![..^4]}";
                break;
            case "toolStripMenuItem88":
                dat = cd.QuestAdoulin;
                rd = new( ds.QuestAd );
                Text = $"クエスト/{menu.Text![..^4]}";
                break;
            case "toolStripMenuItem89":
                dat = cd.QuestCoalitions;
                rd = new( ds.QuestWk );
                Text = $"クエスト/{menu.Text![..^4]}";
                break;
            case "toolStripMenuItem101":
                dat = cd.EmiTutorialBasics;
                rd = new( ds.EmiTutorialBasics );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem102":
                dat = cd.EmiTutorialIntermediate;
                rd = new( ds.EmiTutorialIntermediate );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem194":
                dat = cd.EmiTutorialIntermediate2;
                rd = new( ds.EmiTutorialIntermediate2 );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem103":
                dat = cd.EmiTutorialSynthesis;
                rd = new( ds.EmiTutorialSynthesis );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem104":
                dat = cd.EmiTutorialQuests1;
                rd = new( ds.EmiTutorialQuests1 );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem105":
                dat = cd.EmiTutorialArtifact;
                rd = new( ds.EmiTutorialArtifact );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem106":
                dat = cd.EmiTutorialLvlcap;
                rd = new( ds.EmiTutorialLvlcap );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem195":
                dat = cd.EmiTutorialGrowth;
                rd = new( ds.EmiTutorialGrowth );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem107":
                dat = cd.EmiTutorialStorage;
                rd = new( ds.EmiTutorialStorage );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem108":
                dat = cd.EmiTutorialWS;
                rd = new( ds.EmiTutorialWS );
                Text = $"目標/チュートリアル/{menu.Text}";
                break;
            case "toolStripMenuItem118":
                dat = cd.EmiCombatGeneral;
                rd = new( ds.EmiCombatGeneral );
                Text = $"目標/戦闘：広域/{menu.Text}";
                break;
            case "toolStripMenuItem119":
                dat = cd.EmiCombatSpoils;
                rd = new( ds.EmiCombatSpoils );
                Text = $"目標/戦闘：広域/{menu.Text}";
                break;
            case "toolStripMenuItem120":
                dat = cd.EmiCombatOriginalArea;
                rd = new( ds.EmiCombatOriginalArea );
                Text = $"目標/戦闘：エリア別/{menu.Text}";
                break;
            case "toolStripMenuItem121":
                dat = cd.EmiCombatAdoulinArea;
                rd = new( ds.EmiCombatAdoulinArea );
                Text = $"目標/戦闘：エリア別/{menu.Text}";
                break;
            case "toolStripMenuItem122":
                dat = cd.EmiCombatZilartArea;
                rd = new( ds.EmiCombatZilartArea );
                Text = $"目標/戦闘：エリア別/{menu.Text}";
                break;
            case "toolStripMenuItem123":
                dat = cd.EmiCombatPromathiaArea;
                rd = new( ds.EmiCombatPromathiaArea );
                Text = $"目標/戦闘：エリア別/{menu.Text}";
                break;
            case "toolStripMenuItem124":
                dat = cd.EmiCombatAhturhganArea;
                rd = new( ds.EmiCombatAhturhganArea );
                Text = $"目標/戦闘：エリア別/{menu.Text}";
                break;
            case "toolStripMenuItem125":
                dat = cd.EmiCombatGoddessArea;
                rd = new( ds.EmiCombatGoddessArea );
                Text = $"目標/戦闘：エリア別/{menu.Text}";
                break;
            case "toolStripMenuItem126":
                dat = cd.EmiCombatAbysseaArea;
                rd = new( ds.EmiCombatAbysseaArea );
                Text = $"目標/戦闘：エリア別/{menu.Text}";
                break;
            case "toolStripMenuItem127":
                dat = cd.EmiCombatEschaArea;
                rd = new( ds.EmiCombatEschaArea );
                Text = $"目標/戦闘：エリア別/{menu.Text}";
                break;
            case "toolStripMenuItem128":
                dat = cd.EmiFishingGeneral;
                rd = new( ds.EmiFishingGeneral );
                Text = $"目標/釣り/{menu.Text}";
                break;
            case "toolStripMenuItem129":
                dat = cd.EmiFishingTenacity;
                rd = new( ds.EmiFishingTenacity );
                Text = $"目標/釣り/{menu.Text}";
                break;
            case "toolStripMenuItem130":
                dat = cd.EmiCraftingGeneral;
                rd = new( ds.EmiCraftingGeneral );
                Text = $"目標/合成/{menu.Text}";
                break;
            case "toolStripMenuItem131":
                dat = cd.EmiCraftingEscutcheonsWoodworking;
                rd = new( ds.EmiCraftingEscutcheons );
                Text = $"目標/合成/{menu.Text}";
                break;
            case "toolStripMenuItem132":
                dat = cd.EmiCraftingEscutcheonsSmithing;
                rd = new( ds.EmiCraftingEscutcheons );
                Text = $"目標/合成/{menu.Text}";
                break;
            case "toolStripMenuItem133":
                dat = cd.EmiCraftingEscutcheonsGoldsmithing;
                rd = new( ds.EmiCraftingEscutcheons );
                Text = $"目標/合成/{menu.Text}";
                break;
            case "toolStripMenuItem134":
                dat = cd.EmiCraftingEscutcheonsClothcraft;
                rd = new( ds.EmiCraftingEscutcheons );
                Text = $"目標/合成/{menu.Text}";
                break;
            case "toolStripMenuItem135":
                dat = cd.EmiCraftingEscutcheonsLeathercraft;
                rd = new( ds.EmiCraftingEscutcheons );
                Text = $"目標/合成/{menu.Text}";
                break;
            case "toolStripMenuItem136":
                dat = cd.EmiCraftingEscutcheonsBonecraft;
                rd = new( ds.EmiCraftingEscutcheons );
                Text = $"目標/合成/{menu.Text}";
                break;
            case "toolStripMenuItem137":
                dat = cd.EmiCraftingEscutcheonsAlchemy;
                rd = new( ds.EmiCraftingEscutcheons );
                Text = $"目標/合成/{menu.Text}";
                break;
            case "toolStripMenuItem138":
                dat = cd.EmiCraftingEscutcheonsCooking;
                rd = new( ds.EmiCraftingEscutcheons );
                Text = $"目標/合成/{menu.Text}";
                break;
            case "toolStripMenuItem139":
                dat = cd.EmiHarvestingGeneral;
                rd = new( ds.EmiHarvestingGeneral );
                Text = $"目標/採集/{menu.Text}";
                break;
            case "toolStripMenuItem140":
                dat = cd.EmiHarvestingOriginalArea;
                rd = new( ds.EmiHarvestingOriginalArea );
                Text = $"目標/採集/{menu.Text}";
                break;
            case "toolStripMenuItem141":
                dat = cd.EmiHarvestingAdoulinArea;
                rd = new( ds.EmiHarvestingAdoulinArea );
                Text = $"目標/採集/{menu.Text}";
                break;
            case "toolStripMenuItem142":
                dat = cd.EmiHarvestingZilartArea;
                rd = new( ds.EmiHarvestingZilartArea );
                Text = $"目標/採集/{menu.Text}";
                break;
            case "toolStripMenuItem143":
                dat = cd.EmiHarvestingPromathiaArea;
                rd = new( ds.EmiHarvestingPromathiaArea );
                Text = $"目標/採集/{menu.Text}";
                break;
            case "toolStripMenuItem144":
                dat = cd.EmiHarvestingAhturhganArea;
                rd = new( ds.EmiHarvestingAhturhganArea );
                Text = $"目標/採集/{menu.Text}";
                break;
            case "toolStripMenuItem145":
                dat = cd.EmiHarvestingGoddessArea;
                rd = new( ds.EmiHarvestingGoddessArea );
                Text = $"目標/採集/{menu.Text}";
                break;
            case "toolStripMenuItem146":
                dat = cd.EmiHarvestingAbysseaArea;
                rd = new( ds.EmiHarvestingAbysseaArea );
                Text = $"目標/採集/{menu.Text}";
                break;
            case "toolStripMenuItem147":
                dat = cd.EmiContentLairReive;
                rd = new( ds.EmiContentLairReive );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem148":
                dat = cd.EmiContentColonizationReive;
                rd = new( ds.EmiContentColonizationReive );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem149":
                dat = cd.EmiContentWildskeeperReive;
                rd = new( ds.EmiContentWildskeeperReive );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem150":
                dat = cd.EmiContentOther;
                rd = new( ds.EmiContentOther );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem151":
                dat = cd.EmiContentDynamis;
                rd = new( ds.EmiContentDynamis );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem152":
                dat = cd.EmiContentLimbus;
                rd = new( ds.EmiContentLimbus );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem153":
                dat = cd.EmiContentZNM;
                rd = new( ds.EmiContentZNM );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem154":
                dat = cd.EmiContentVagary;
                rd = new( ds.EmiContentVagary );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem155":
                dat = cd.EmiContentOmen;
                rd = new( ds.EmiContentOmen );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem156":
                dat = cd.EmiContentOdyssey;
                rd = new( ds.EmiContentOdyssey );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem157":
                dat = cd.EmiContentSortie;
                rd = new( ds.EmiContentSortie );
                Text = $"目標/コンテンツ/{menu.Text}";
                break;
            case "toolStripMenuItem158":
                dat = cd.EmiAchievementsJobLevels;
                rd = new( ds.EmiAchievementsJobLevels );
                Text = $"目標/アチーブメント/{menu.Text}";
                break;
            case "toolStripMenuItem159":
                dat = cd.EmiAchievementsFame;
                rd = new( ds.EmiAchievementsFame );
                Text = $"目標/アチーブメント/{menu.Text}";
                break;
            case "toolStripMenuItem160":
                dat = cd.EmiUnityWanted;
                rd = new( ds.EmiUnityWanted );
                Text = $"目標/ユニティ/{menu.Text}";
                break;
            case "toolStripMenuItem161":
                dat = cd.EmiVanaversary15;
                rd = new( ds.EmiVanaversary15 );
                Text = $"目標/アニバーサリー/{menu.Text}";
                break;
            case "toolStripMenuItem162":
                dat = cd.EmiOtherRoeQuests1;
                rd = new( ds.EmiOtherRoeQuests1 );
                Text = $"目標/その他/{menu.Text}";
                break;
            case "toolStripMenuItem163":
                dat = cd.EmiOtherRoeQuests2;
                rd = new( ds.EmiOtherRoeQuests2 );
                Text = $"目標/その他/{menu.Text}";
                break;
            case "toolStripMenuItem164":
                dat = cd.EmiOtherRoeQuests3;
                rd = new( ds.EmiOtherRoeQuests3 );
                Text = $"目標/その他/{menu.Text}";
                break;
            }
            num = Math.Max( dat.Length, rd.Count );
            Array.Resize( ref c, rd.Count );
            AcceptButton = userControl11.ButtonAccept;
            CancelButton = userControl11.ButtonCancel;
            userControl11.ButtonClick += Button_Click;
            userControl11.Flp.SuspendLayout();
            foreach( KeyValuePair<byte, string> kvp in rd ) {
                CheckBox cb = new() {
                    AutoSize = true,
                    Name = $"c{kvp.Key}",
                    Size = new( 1, 19 ),
                    TabIndex = kvp.Key,
                    Text = kvp.Value,
                    UseVisualStyleBackColor = true
                };
                int idx = int.Parse( cb.Name.Substring( 1 ) );

                if( idx < dat.Length && dat[idx] != 0 ) {
                    p++;
                    cb.Checked = true;
                }
                c[i] = cb;
                i++;
            }
            com = p;
            userControl11.Flp.Controls.AddRange( c );
            userControl11.Flp.ResumeLayout();
            userControl11.NumComp = $"{NumComp}{p}";
        }

#pragma warning disable IDE0305
        private void Button_Click( UserControl1.ButtonEventArgs e )
        {
            if( e.apply is true ) {
                int p = 0;
                List<sbyte> l = new( Enumerable.Repeat<sbyte>( 0, num ) );

                foreach( Control c in userControl11.Flp.Controls ) {
                    if( c is CheckBox b ) {
                        sbyte ch = Convert.ToSByte( b.Checked );

                        if( ch != 0 ) {
                            p++;
                        }
                        l[int.Parse( b.Name.Substring( 1 ) )] = ch;
                    }
                }
                cd.EmiCompleted = cd.EmiCompleted - com + p;
                switch( name ) {
                case "toolStripMenuItem80":
                    cd.QuestBastok = l.ToArray();
                    break;
                case "toolStripMenuItem81":
                    cd.QuestWindurst = l.ToArray();
                    break;
                case "toolStripMenuItem82":
                    cd.QuestJeuno = l.ToArray();
                    break;
                case "toolStripMenuItem84":
                    cd.QuestOutlands = l.ToArray();
                    break;
                case "toolStripMenuItem85":
                    cd.QuestAhturhgan = l.ToArray();
                    break;
                case "toolStripMenuItem86":
                    cd.QuestPast = l.ToArray();
                    break;
                case "toolStripMenuItem87":
                    cd.QuestAbyssea = l.ToArray();
                    break;
                case "toolStripMenuItem88":
                    cd.QuestAdoulin = l.ToArray();
                    break;
                case "toolStripMenuItem89":
                    cd.QuestCoalitions = l.ToArray();
                    break;
                case "toolStripMenuItem101":
                    cd.EmiTutorialBasics = l.ToArray();
                    break;
                case "toolStripMenuItem102":
                    cd.EmiTutorialIntermediate = l.ToArray();
                    break;
                case "toolStripMenuItem194":
                    cd.EmiTutorialIntermediate2 = l.ToArray();
                    break;
                case "toolStripMenuItem103":
                    cd.EmiTutorialSynthesis = l.ToArray();
                    break;
                case "toolStripMenuItem104":
                    cd.EmiTutorialQuests1 = l.ToArray();
                    break;
                case "toolStripMenuItem105":
                    cd.EmiTutorialArtifact = l.ToArray();
                    break;
                case "toolStripMenuItem106":
                    cd.EmiTutorialLvlcap = l.ToArray();
                    break;
                case "toolStripMenuItem195":
                    cd.EmiTutorialGrowth = l.ToArray();
                    break;
                case "toolStripMenuItem107":
                    cd.EmiTutorialStorage = l.ToArray();
                    break;
                case "toolStripMenuItem108":
                    cd.EmiTutorialWS = l.ToArray();
                    break;
                case "toolStripMenuItem118":
                    cd.EmiCombatGeneral = l.ToArray();
                    break;
                case "toolStripMenuItem119":
                    cd.EmiCombatSpoils = l.ToArray();
                    break;
                case "toolStripMenuItem120":
                    cd.EmiCombatOriginalArea = l.ToArray();
                    break;
                case "toolStripMenuItem121":
                    cd.EmiCombatAdoulinArea = l.ToArray();
                    break;
                case "toolStripMenuItem122":
                    cd.EmiCombatZilartArea = l.ToArray();
                    break;
                case "toolStripMenuItem123":
                    cd.EmiCombatPromathiaArea = l.ToArray();
                    break;
                case "toolStripMenuItem124":
                    cd.EmiCombatAhturhganArea = l.ToArray();
                    break;
                case "toolStripMenuItem125":
                    cd.EmiCombatGoddessArea = l.ToArray();
                    break;
                case "toolStripMenuItem126":
                    cd.EmiCombatAbysseaArea = l.ToArray();
                    break;
                case "toolStripMenuItem127":
                    cd.EmiCombatEschaArea = l.ToArray();
                    break;
                case "toolStripMenuItem128":
                    cd.EmiFishingGeneral = l.ToArray();
                    break;
                case "toolStripMenuItem129":
                    cd.EmiFishingTenacity = l.ToArray();
                    break;
                case "toolStripMenuItem130":
                    cd.EmiCraftingGeneral = l.ToArray();
                    break;
                case "toolStripMenuItem131":
                    cd.EmiCraftingEscutcheonsWoodworking = l.ToArray();
                    break;
                case "toolStripMenuItem132":
                    cd.EmiCraftingEscutcheonsSmithing = l.ToArray();
                    break;
                case "toolStripMenuItem133":
                    cd.EmiCraftingEscutcheonsGoldsmithing = l.ToArray();
                    break;
                case "toolStripMenuItem134":
                    cd.EmiCraftingEscutcheonsClothcraft = l.ToArray();
                    break;
                case "toolStripMenuItem135":
                    cd.EmiCraftingEscutcheonsLeathercraft = l.ToArray();
                    break;
                case "toolStripMenuItem136":
                    cd.EmiCraftingEscutcheonsBonecraft = l.ToArray();
                    break;
                case "toolStripMenuItem137":
                    cd.EmiCraftingEscutcheonsAlchemy = l.ToArray();
                    break;
                case "toolStripMenuItem138":
                    cd.EmiCraftingEscutcheonsCooking = l.ToArray();
                    break;
                case "toolStripMenuItem139":
                    cd.EmiHarvestingGeneral = l.ToArray();
                    break;
                case "toolStripMenuItem140":
                    cd.EmiHarvestingOriginalArea = l.ToArray();
                    break;
                case "toolStripMenuItem141":
                    cd.EmiHarvestingAdoulinArea = l.ToArray();
                    break;
                case "toolStripMenuItem142":
                    cd.EmiHarvestingZilartArea = l.ToArray();
                    break;
                case "toolStripMenuItem143":
                    cd.EmiHarvestingPromathiaArea = l.ToArray();
                    break;
                case "toolStripMenuItem144":
                    cd.EmiHarvestingAhturhganArea = l.ToArray();
                    break;
                case "toolStripMenuItem145":
                    cd.EmiHarvestingGoddessArea = l.ToArray();
                    break;
                case "toolStripMenuItem146":
                    cd.EmiHarvestingAbysseaArea = l.ToArray();
                    break;
                case "toolStripMenuItem147":
                    cd.EmiContentLairReive = l.ToArray();
                    break;
                case "toolStripMenuItem148":
                    cd.EmiContentColonizationReive = l.ToArray();
                    break;
                case "toolStripMenuItem149":
                    cd.EmiContentWildskeeperReive = l.ToArray();
                    break;
                case "toolStripMenuItem150":
                    cd.EmiContentOther = l.ToArray();
                    break;
                case "toolStripMenuItem151":
                    cd.EmiContentDynamis = l.ToArray();
                    break;
                case "toolStripMenuItem152":
                    cd.EmiContentLimbus = l.ToArray();
                    break;
                case "toolStripMenuItem153":
                    cd.EmiContentZNM = l.ToArray();
                    break;
                case "toolStripMenuItem154":
                    cd.EmiContentVagary = l.ToArray();
                    break;
                case "toolStripMenuItem155":
                    cd.EmiContentOmen = l.ToArray();
                    break;
                case "toolStripMenuItem156":
                    cd.EmiContentOdyssey = l.ToArray();
                    break;
                case "toolStripMenuItem157":
                    cd.EmiContentSortie = l.ToArray();
                    break;
                case "toolStripMenuItem158":
                    cd.EmiAchievementsJobLevels = l.ToArray();
                    break;
                case "toolStripMenuItem159":
                    cd.EmiAchievementsFame = l.ToArray();
                    break;
                case "toolStripMenuItem160":
                    cd.EmiUnityWanted = l.ToArray();
                    break;
                case "toolStripMenuItem161":
                    cd.EmiVanaversary15 = l.ToArray();
                    break;
                case "toolStripMenuItem162":
                    cd.EmiOtherRoeQuests1 = l.ToArray();
                    break;
                case "toolStripMenuItem163":
                    cd.EmiOtherRoeQuests2 = l.ToArray();
                    break;
                case "toolStripMenuItem164":
                    cd.EmiOtherRoeQuests3 = l.ToArray();
                    break;
                }
            }
            Close();
            return;
        }
    }
}
