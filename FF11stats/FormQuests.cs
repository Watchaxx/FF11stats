using System.Collections.ObjectModel;
using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormQuests : Form
    {
#pragma warning disable CS8618
        static sbyte[] dat;
        static int com = 0;

        public FormQuests( ToolStripMenuItem menu )
        {
            InitializeComponent();

            int i = 0;
            int p = 0;
            CheckBox[] c = new CheckBox[1];
            DisplayStrings ds = new();
            ReadOnlyDictionary<byte, string> rd = new( new Dictionary<byte, string>() );

            switch( menu.Name ) {
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

                if( dat[int.Parse( cb.Name.Substring( 1 ) )] != 0 ) {
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

        private void Button_Click( UserControl1.ButtonEventArgs e )
        {
            if( e.apply is true ) {
                int p = 0;

                foreach( Control c in userControl11.Flp.Controls ) {
                    if( c is CheckBox b ) {
                        sbyte ch = Convert.ToSByte( b.Checked );

                        if( ch != 0 ) {
                            p++;
                        }
                        dat[int.Parse( b.Name.Substring( 1 ) )] = ch;
                    }
                }
                cd.EmiCompleted += p - com;
            }
            Close();
            return;
        }
    }
}
