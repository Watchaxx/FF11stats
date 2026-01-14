using System.Text.Json;
using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            Icon = Resource1.logo1;
            if( string.IsNullOrWhiteSpace( edit ) == true ) {
                SetTitle();
            } else {
                SetTitle( edit.Split( '\\' )[^1] );
            }
            label1.Text = cd.Name;
        }

        public static void LoadJson( string file )
        {
            Utf8JsonReader jr = new( File.ReadAllBytes( file ) );

            cd = JsonSerializer.Deserialize<ChrDat>( ref jr )!;
            return;
        }

        private void SetTitle( string s = "Newcharacter" )
        {
            Text = $"{s} - FF11stats";
            return;
        }

        private void ShowForm( Form form, bool wait = false )
        {
            Cursor = wait ? Cursors.AppStarting : Cursors.Default;
            form.ShowDialog();
            form?.Dispose();
            Cursor = Cursors.Default;
            return;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            Button b = (Button)sender;

            switch( b.Name ) {
            case "button1":
                contextMenuStrip1.Show( b, new Point( 0, b.Height ) );
                break;
            case "button2":
                toolStripMenuItem23.Checked = 75 <= cd.JoblvlWar;
                toolStripMenuItem24.Checked = 75 <= cd.JoblvlMnk;
                toolStripMenuItem25.Checked = 75 <= cd.JoblvlWhm;
                toolStripMenuItem26.Checked = 75 <= cd.JoblvlBlm;
                toolStripMenuItem27.Checked = 75 <= cd.JoblvlRdm;
                toolStripMenuItem28.Checked = 75 <= cd.JoblvlThf;
                toolStripMenuItem29.Checked = 75 <= cd.JoblvlPld;
                toolStripMenuItem30.Checked = 75 <= cd.JoblvlDrk;
                toolStripMenuItem31.Checked = 75 <= cd.JoblvlBst;
                toolStripMenuItem32.Checked = 75 <= cd.JoblvlBrd;
                toolStripMenuItem33.Checked = 75 <= cd.JoblvlRng;
                toolStripMenuItem34.Checked = 75 <= cd.JoblvlSam;
                toolStripMenuItem35.Checked = 75 <= cd.JoblvlNin;
                toolStripMenuItem36.Checked = 75 <= cd.JoblvlDrg;
                toolStripMenuItem37.Checked = 75 <= cd.JoblvlSmn;
                toolStripMenuItem38.Checked = 75 <= cd.JoblvlBlu;
                toolStripMenuItem39.Checked = 75 <= cd.JoblvlCor;
                toolStripMenuItem40.Checked = 75 <= cd.JoblvlPup;
                toolStripMenuItem41.Checked = 75 <= cd.JoblvlDnc;
                toolStripMenuItem42.Checked = 75 <= cd.JoblvlSch;
                toolStripMenuItem43.Checked = 75 <= cd.JoblvlGeo;
                toolStripMenuItem44.Checked = 75 <= cd.JoblvlRun;
                contextMenuStrip2.Show( b, new Point( 0, b.Height ) );
                break;
            case "button3":
                toolStripMenuItem45.Checked = 99 <= cd.JoblvlWar;
                toolStripMenuItem46.Checked = 99 <= cd.JoblvlMnk;
                toolStripMenuItem47.Checked = 99 <= cd.JoblvlWhm;
                toolStripMenuItem48.Checked = 99 <= cd.JoblvlBlm;
                toolStripMenuItem49.Checked = 99 <= cd.JoblvlRdm;
                toolStripMenuItem50.Checked = 99 <= cd.JoblvlThf;
                toolStripMenuItem51.Checked = 99 <= cd.JoblvlPld;
                toolStripMenuItem52.Checked = 99 <= cd.JoblvlDrk;
                toolStripMenuItem53.Checked = 99 <= cd.JoblvlBst;
                toolStripMenuItem54.Checked = 99 <= cd.JoblvlBrd;
                toolStripMenuItem55.Checked = 99 <= cd.JoblvlRng;
                toolStripMenuItem56.Checked = 99 <= cd.JoblvlSam;
                toolStripMenuItem57.Checked = 99 <= cd.JoblvlNin;
                toolStripMenuItem58.Checked = 99 <= cd.JoblvlDrg;
                toolStripMenuItem59.Checked = 99 <= cd.JoblvlSmn;
                toolStripMenuItem60.Checked = 99 <= cd.JoblvlBlu;
                toolStripMenuItem61.Checked = 99 <= cd.JoblvlCor;
                toolStripMenuItem62.Checked = 99 <= cd.JoblvlPup;
                toolStripMenuItem63.Checked = 99 <= cd.JoblvlDnc;
                toolStripMenuItem64.Checked = 99 <= cd.JoblvlSch;
                toolStripMenuItem65.Checked = 99 <= cd.JoblvlGeo;
                toolStripMenuItem66.Checked = 99 <= cd.JoblvlRun;
                contextMenuStrip3.Show( b, new Point( 0, b.Height ) );
                break;
            case "button4":
                contextMenuStrip4.Show( b, new Point( 0, b.Height ) );
                break;
            case "button5":
                contextMenuStrip5.Show( b, new Point( 0, b.Height ) );
                break;
            case "button6":
                contextMenuStrip6.Show( b, new Point( 0, b.Height ) );
                break;
            case "button7":
                toolStripMenuItem165.Text = $"コンプリート数：{cd.EmiCompleted}";
                contextMenuStrip7.Show( b, new Point( 0, b.Height ) );
                break;
            case "button8":
                contextMenuStrip8.Show( b, new Point( 0, b.Height ) );
                break;
            }
            return;
        }

        private void Timer1_Tick( object sender, EventArgs e )
        {
            const uint vanaSec = 3600 * 24 / 25;
            DateTime now = DateTime.Now.ToLocalTime();
            ulong earthSec = (ulong)( now - new DateTimeOffset( 2002, 1, 1, 0, 0, 0, TimeSpan.FromHours( 9d ) ) ).TotalSeconds;
            ulong vanaDays = earthSec / vanaSec;
            ulong year = vanaDays / 360 + 886;
            ulong month = vanaDays / 30 % 12 + 1;
            ulong day = vanaDays % 30 + 1;
            string week = ( vanaDays % 8 ) switch {
                0 => "火",
                1 => "土",
                2 => "水",
                3 => "風",
                4 => "氷",
                5 => "雷",
                6 => "光",
                7 => "闇",
                _ => throw new InvalidOperationException( "曜日" )
            };
            ulong hour = earthSec % vanaSec * 25 / 3600 % 24;
            ulong min = earthSec % vanaSec * 25 / 60 % 60;
            string moon = ( vanaDays / 7 % 12 ) switch {
                0 => "新月",
                1 => "三日月",
                2 => "七日月",
                3 => "上弦の月",
                4 => "十日月",
                5 => "十三夜",
                6 => "満月",
                7 => "十六夜",
                8 => "居待月",
                9 => "下弦の月",
                10 => "二十日余",
                11 => "二十六夜",
                _ => throw new InvalidOperationException( "月齢" )
            };

            label2.Text = $"Vana'diel [{year}/{month}/{day}({week}) {hour}:{min:00} <{moon}>]";
            label3.Text = $"    Earth [{now:yyyy/M/d}({now:ddd}) {now.ToLongTimeString()}]";
            return;
        }

        private void ToolStripMenuItem2_Click( object sender, EventArgs e )
        {
            using FormNewChr f = new();

            if( f.ShowDialog() == DialogResult.OK ) {
                SetTitle();
                label1.Text = cd.Name;
            }
            return;
        }

        private void ToolStripMenuItem3_Click( object sender, EventArgs e )
        {
            using OpenFileDialog ofd = new();

            ofd.Filter = "キャラクタ ファイル|*.chr";
            if( ofd.ShowDialog() == DialogResult.OK ) {
                LoadJson( ofd.FileName );
                edit = ofd.FileName;
                SetTitle( ofd.SafeFileName );
                label1.Text = cd.Name;
            }
            return;
        }

        private void ToolStripMenuItem4_Click( object sender, EventArgs e )
        {
            if( string.IsNullOrWhiteSpace( edit ) is false ) {
                File.WriteAllBytes( edit, JsonSerializer.SerializeToUtf8Bytes( cd ) );
            } else {
                ToolStripMenuItem5_Click( sender, e );
            }
            return;
        }

        private void ToolStripMenuItem5_Click( object sender, EventArgs e )
        {
            using SaveFileDialog sfd = new();

            sfd.FileName = cd.Name;
            sfd.Filter = "キャラクタ ファイル|*.chr";
            if( sfd.ShowDialog() is DialogResult.OK ) {
                File.WriteAllBytes( sfd.FileName, JsonSerializer.SerializeToUtf8Bytes( cd ) );
                edit = sfd.FileName;
                SetTitle( sfd.FileName.Split( '\\' )[^1] );
            }
            return;
        }

        private void ToolStripMenuItem6_Click( object sender, EventArgs e )
        {
            Application.Exit();
            return;
        }

        private void ToolStripMenuItem10_Click( object sender, EventArgs e )
        {
            using( AboutBox1 a = new() ) {
                a.ShowDialog();
            }
            return;
        }

        private void ToolStripMenuItem11_Click( object sender, EventArgs e )
        {
            Cursor = Cursors.AppStarting;
            using( FormProfile f = new() ) {
                if( f.ShowDialog() == DialogResult.OK ) {
                    label1.Text = cd.Name;
                }
            }
            Cursor = Cursors.Default;
            return;
        }

        private void ToolStripMenuItem12_Click( object sender, EventArgs e )
        {
            ToolStripMenuItem i = (ToolStripMenuItem)sender;

            switch( i.Name ) {
            case "toolStripMenuItem12":
                ShowForm( new FormJoblvl() );
                break;
            case "toolStripMenuItem13":
                ShowForm( new FormMstlvl() );
                break;
            case "toolStripMenuItem14":
                ShowForm( new FormCombatSkills() );
                break;
            case "toolStripMenuItem15":
                ShowForm( new FormMagicSkills() );
                break;
            case "toolStripMenuItem16":
                ShowForm( new FormSynthSkills(), true );
                break;
            //メリポ
            case "toolStripMenuItem17":
                ShowForm( new FormMeritHpmp() );
                break;
            case "toolStripMenuItem18":
                ShowForm( new FormMeritStatus() );
                break;
            case "toolStripMenuItem19":
                ShowForm( new FormMeritCombatSkills() );
                break;
            case "toolStripMenuItem20":
                ShowForm( new FormMeritMagicSkills() );
                break;
            case "toolStripMenuItem21":
                ShowForm( new FormMeritOthers() );
                break;
            case "toolStripMenuItem22":
                ShowForm( new FormMeritWS() );
                break;
            case "toolStripMenuItem23":
                ShowForm( new FormMerit54( Jobs.War ) );
                break;
            case "toolStripMenuItem24":
                ShowForm( new FormMerit54( Jobs.Mnk ) );
                break;
            case "toolStripMenuItem25":
                ShowForm( new FormMerit54( Jobs.Whm ) );
                break;
            case "toolStripMenuItem26":
                ShowForm( new FormMerit76( Jobs.Blm ) );
                break;
            case "toolStripMenuItem27":
                ShowForm( new FormMerit76( Jobs.Rdm ) );
                break;
            case "toolStripMenuItem28":
                ShowForm( new FormMerit54( Jobs.Thf ) );
                break;
            case "toolStripMenuItem29":
                ShowForm( new FormMerit54( Jobs.Pld ) );
                break;
            case "toolStripMenuItem30":
                ShowForm( new FormMerit54( Jobs.Drk ) );
                break;
            case "toolStripMenuItem31":
                ShowForm( new FormMerit54( Jobs.Bst ) );
                break;
            case "toolStripMenuItem32":
                ShowForm( new FormMerit54( Jobs.Brd ) );
                break;
            case "toolStripMenuItem33":
                ShowForm( new FormMerit54( Jobs.Rng ) );
                break;
            case "toolStripMenuItem34":
                ShowForm( new FormMerit54( Jobs.Sam ) );
                break;
            case "toolStripMenuItem35":
                ShowForm( new FormMerit76( Jobs.Nin ) );
                break;
            case "toolStripMenuItem36":
                ShowForm( new FormMerit54( Jobs.Drg ) );
                break;
            case "toolStripMenuItem37":
                ShowForm( new FormMeritSmn() );
                break;
            case "toolStripMenuItem38":
                ShowForm( new FormMerit54( Jobs.Blu ) );
                break;
            case "toolStripMenuItem39":
                ShowForm( new FormMerit54( Jobs.Cor ) );
                break;
            case "toolStripMenuItem40":
                ShowForm( new FormMerit54( Jobs.Pup ) );
                break;
            case "toolStripMenuItem41":
                ShowForm( new FormMeritDnc() );
                break;
            case "toolStripMenuItem42":
                ShowForm( new FormMeritSch() );
                break;
            case "toolStripMenuItem43":
                ShowForm( new FormMerit54( Jobs.Geo ) );
                break;
            case "toolStripMenuItem44":
                ShowForm( new FormMerit54( Jobs.Run ) );
                break;
            //ジョブポ
            case "toolStripMenuItem45":
                ShowForm( new FormJobPoints( Jobs.War ) );
                break;
            case "toolStripMenuItem46":
                ShowForm( new FormJobPoints( Jobs.Mnk ) );
                break;
            case "toolStripMenuItem47":
                ShowForm( new FormJobPoints( Jobs.Whm ) );
                break;
            case "toolStripMenuItem48":
                ShowForm( new FormJobPoints( Jobs.Blm ) );
                break;
            case "toolStripMenuItem49":
                ShowForm( new FormJobPoints( Jobs.Rdm ) );
                break;
            case "toolStripMenuItem50":
                ShowForm( new FormJobPoints( Jobs.Thf ) );
                break;
            case "toolStripMenuItem51":
                ShowForm( new FormJobPoints( Jobs.Pld ) );
                break;
            case "toolStripMenuItem52":
                ShowForm( new FormJobPoints( Jobs.Drk ) );
                break;
            case "toolStripMenuItem53":
                ShowForm( new FormJobPoints( Jobs.Bst ) );
                break;
            case "toolStripMenuItem54":
                ShowForm( new FormJobPoints( Jobs.Brd ) );
                break;
            case "toolStripMenuItem55":
                ShowForm( new FormJobPoints( Jobs.Rng ) );
                break;
            case "toolStripMenuItem56":
                ShowForm( new FormJobPoints( Jobs.Sam ) );
                break;
            case "toolStripMenuItem57":
                ShowForm( new FormJobPoints( Jobs.Nin ) );
                break;
            case "toolStripMenuItem58":
                ShowForm( new FormJobPoints( Jobs.Drg ) );
                break;
            case "toolStripMenuItem59":
                ShowForm( new FormJobPoints( Jobs.Smn ) );
                break;
            case "toolStripMenuItem60":
                ShowForm( new FormJobPoints( Jobs.Blu ) );
                break;
            case "toolStripMenuItem61":
                ShowForm( new FormJobPoints( Jobs.Cor ) );
                break;
            case "toolStripMenuItem62":
                ShowForm( new FormJobPoints( Jobs.Pup ) );
                break;
            case "toolStripMenuItem63":
                ShowForm( new FormJobPoints( Jobs.Dnc ) );
                break;
            case "toolStripMenuItem64":
                ShowForm( new FormJobPoints( Jobs.Sch ) );
                break;
            case "toolStripMenuItem65":
                ShowForm( new FormJobPoints( Jobs.Geo ) );
                break;
            case "toolStripMenuItem66":
                ShowForm( new FormJobPoints( Jobs.Run ) );
                break;
            //魔法
            case "toolStripMenuItem67":
                ShowForm( new FormMagicWhite() );
                break;
            case "toolStripMenuItem68":
                ShowForm( new FormMagicBlack() );
                break;
            case "toolStripMenuItem69":
                ShowForm( new FormMagicSongs() );
                break;
            case "toolStripMenuItem70":
                ShowForm( new FormMagicNinjutsu() );
                break;
            case "toolStripMenuItem71":
                ShowForm( new FormMagicSummon() );
                break;
            case "toolStripMenuItem72":
                ShowForm( new FormMagicBlue() );
                break;
            case "toolStripMenuItem73":
                ShowForm( new FormPhantomRoll() );
                break;
            case "toolStripMenuItem74":
                ShowForm( new FormMagicGeomancy() );
                break;
            case "toolStripMenuItem75":
                ShowForm( new FormMagicTrust() );
                break;
            //ミッション
            case "toolStripMenuItem76":
                ShowForm( new FormMissionMi(), true );
                break;
            case "toolStripMenuItem77":
                ShowForm( new FormMissionAs() );
                break;
            case "toolStripMenuItem78":
                ShowForm( new FormMissionCa() );
                break;
            //クエスト
            case "toolStripMenuItem79":
                ShowForm( new FormQuestSd() );
                break;
            case "toolStripMenuItem80":
            case "toolStripMenuItem81":
            case "toolStripMenuItem82":
                ShowForm( new FormQuests( i ) );
                break;
            case "toolStripMenuItem83":
                ShowForm( new FormQuestOt() );
                break;
            case "toolStripMenuItem84":
            case "toolStripMenuItem85":
            case "toolStripMenuItem86":
            case "toolStripMenuItem87":
            case "toolStripMenuItem88":
            case "toolStripMenuItem89":
                ShowForm( new FormQuests( i ) );
                break;
            //エミネンス・レコード
            case "toolStripMenuItem101":
            case "toolStripMenuItem102":
            case "toolStripMenuItem103":
            case "toolStripMenuItem104":
            case "toolStripMenuItem105":
            case "toolStripMenuItem106":
            case "toolStripMenuItem107":
            case "toolStripMenuItem108":
                ShowForm( new FormQuests( i ) );
                break;
            case "toolStripMenuItem109":
                ShowForm( new FormEmiTutorialRhapsodies() );
                break;
            case "toolStripMenuItem110":
                ShowForm( new FormEmiTutorialSandoria( Mission.Sandoria ) );
                break;
            case "toolStripMenuItem111":
                ShowForm( new FormEmiTutorialSandoria( Mission.Bastok ) );
                break;
            case "toolStripMenuItem112":
                ShowForm( new FormEmiTutorialSandoria( Mission.Windurst ) );
                break;
            case "toolStripMenuItem113":
                ShowForm( new FormEmiTutorialZilart( Mission.Zilart ) );
                break;
            case "toolStripMenuItem114":
                ShowForm( new FormEmiTutorialZilart( Mission.Promathia ) );
                break;
            case "toolStripMenuItem115":
                ShowForm( new FormEmiTutorialZilart( Mission.Ahturhgan ) );
                break;
            case "toolStripMenuItem116":
                ShowForm( new FormEmiTutorialZilart( Mission.Altana ) );
                break;
            case "toolStripMenuItem117":
                ShowForm( new FormEmiTutorialZilart( Mission.Adoulin ) );
                break;
            case "toolStripMenuItem118":
            case "toolStripMenuItem119":
            case "toolStripMenuItem120":
            case "toolStripMenuItem121":
            case "toolStripMenuItem122":
            case "toolStripMenuItem123":
            case "toolStripMenuItem124":
            case "toolStripMenuItem125":
            case "toolStripMenuItem126":
            case "toolStripMenuItem127":
            case "toolStripMenuItem128":
            case "toolStripMenuItem129":
            case "toolStripMenuItem130":
            case "toolStripMenuItem131":
            case "toolStripMenuItem132":
            case "toolStripMenuItem133":
            case "toolStripMenuItem134":
            case "toolStripMenuItem135":
            case "toolStripMenuItem136":
            case "toolStripMenuItem137":
            case "toolStripMenuItem138":
            case "toolStripMenuItem139":
            case "toolStripMenuItem140":
            case "toolStripMenuItem141":
            case "toolStripMenuItem142":
            case "toolStripMenuItem143":
            case "toolStripMenuItem144":
            case "toolStripMenuItem145":
            case "toolStripMenuItem146":
            case "toolStripMenuItem147":
            case "toolStripMenuItem148":
            case "toolStripMenuItem149":
            case "toolStripMenuItem150":
            case "toolStripMenuItem151":
            case "toolStripMenuItem152":
            case "toolStripMenuItem153":
            case "toolStripMenuItem154":
            case "toolStripMenuItem155":
            case "toolStripMenuItem156":
            case "toolStripMenuItem157":
            case "toolStripMenuItem158":
            case "toolStripMenuItem159":
            case "toolStripMenuItem160":
            case "toolStripMenuItem161":
            case "toolStripMenuItem162":
            case "toolStripMenuItem163":
            case "toolStripMenuItem164":
                ShowForm( new FormQuests( i ) );
                break;
            //移動
            case "toolStripMenuItem167":
            case "toolStripMenuItem168":
            case "toolStripMenuItem169":
            case "toolStripMenuItem170":
            case "toolStripMenuItem171":
                ShowForm( new FormMoveSGHP( i ) );
                break;
            }
            return;
        }

        private void ToolStripMenuItem165_Click( object sender, EventArgs e )
        {
            const string caption = "コンプリート数チェッカー";

            if( MessageBox.Show( $"正しく入力してもコンプリート数がゲーム内の表示と一致しない場合に実行してください。{Environment.NewLine}コンプリート数の整合性チェックと修復をしますか？",
                caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2 ) is DialogResult.Yes ) {
                int c = 0;

                c += cd.EmiTutorialBasics.Count( x => x != 0 );
                c += cd.EmiTutorialIntermediate.Count( x => x != 0 );
                c += cd.EmiTutorialSynthesis.Count( x => x != 0 );
                c += cd.EmiTutorialQuests1.Count( x => x != 0 );
                c += cd.EmiTutorialArtifact.Count( x => x != 0 );
                c += cd.EmiTutorialLvlcap.Count( x => x != 0 );
                c += cd.EmiTutorialStorage.Count( x => x != 0 );
                c += cd.EmiTutorialWS.Count( x => x != 0 );
                c += cd.EmiTutorialRhapsodies.Count( x => x != 0 );
                c += cd.EmiTutorialSandoria.Count( x => x != 0 );
                c += cd.EmiTutorialBastok.Count( x => x != 0 );
                c += cd.EmiTutorialWindurst.Count( x => x != 0 );
                c += cd.EmiTutorialZilart.Count( x => x != 0 );
                c += cd.EmiTutorialPromathia.Count( x => x != 0 );
                c += cd.EmiTutorialAhturhgan.Count( x => x != 0 );
                c += cd.EmiTutorialAltana.Count( x => x != 0 );
                c += cd.EmiTutorialAdoulin.Count( x => x != 0 );
                c += cd.EmiCombatGeneral.Count( x => x != 0 );
                c += cd.EmiCombatSpoils.Count( x => x != 0 );
                c += cd.EmiCombatOriginalArea.Count( x => x != 0 );
                c += cd.EmiCombatAdoulinArea.Count( x => x != 0 );
                c += cd.EmiCombatZilartArea.Count( x => x != 0 );
                c += cd.EmiCombatPromathiaArea.Count( x => x != 0 );
                c += cd.EmiCombatAhturhganArea.Count( x => x != 0 );
                c += cd.EmiCombatGoddessArea.Count( x => x != 0 );
                c += cd.EmiCombatAbysseaArea.Count( x => x != 0 );
                c += cd.EmiCombatEschaArea.Count( x => x != 0 );
                c += cd.EmiFishingGeneral.Count( x => x != 0 );
                c += cd.EmiFishingTenacity.Count( x => x != 0 );
                c += cd.EmiCraftingGeneral.Count( x => x != 0 );
                c += cd.EmiCraftingEscutcheonsWoodworking.Count( x => x != 0 );
                c += cd.EmiCraftingEscutcheonsClothcraft.Count( x => x != 0 );
                c += cd.EmiCraftingEscutcheonsAlchemy.Count( x => x != 0 );
                c += cd.EmiCraftingEscutcheonsBonecraft.Count( x => x != 0 );
                c += cd.EmiCraftingEscutcheonsCooking.Count( x => x != 0 );
                c += cd.EmiCraftingEscutcheonsGoldsmithing.Count( x => x != 0 );
                c += cd.EmiCraftingEscutcheonsLeathercraft.Count( x => x != 0 );
                c += cd.EmiCraftingEscutcheonsSmithing.Count( x => x != 0 );
                c += cd.EmiHarvestingGeneral.Count( x => x != 0 );
                c += cd.EmiHarvestingOriginalArea.Count( x => x != 0 );
                c += cd.EmiHarvestingAdoulinArea.Count( x => x != 0 );
                c += cd.EmiHarvestingZilartArea.Count( x => x != 0 );
                c += cd.EmiHarvestingPromathiaArea.Count( x => x != 0 );
                c += cd.EmiHarvestingAhturhganArea.Count( x => x != 0 );
                c += cd.EmiHarvestingGoddessArea.Count( x => x != 0 );
                c += cd.EmiHarvestingAbysseaArea.Count( x => x != 0 );
                c += cd.EmiContentLairReive.Count( x => x != 0 );
                c += cd.EmiContentColonizationReive.Count( x => x != 0 );
                c += cd.EmiContentWildskeeperReive.Count( x => x != 0 );
                c += cd.EmiContentOther.Count( x => x != 0 );
                c += cd.EmiContentDynamis.Count( x => x != 0 );
                c += cd.EmiContentLimbus.Count( x => x != 0 );
                c += cd.EmiContentZNM.Count( x => x != 0 );
                c += cd.EmiContentVagary.Count( x => x != 0 );
                c += cd.EmiContentOmen.Count( x => x != 0 );
                c += cd.EmiContentOdyssey.Count( x => x != 0 );
                c += cd.EmiContentSortie.Count( x => x != 0 );
                c += cd.EmiAchievementsJobLevels.Count( x => x != 0 );
                c += cd.EmiAchievementsFame.Count( x => x != 0 );
                c += cd.EmiUnityWanted.Count( x => x != 0 );
                c += cd.EmiVanaversary15.Count( x => x != 0 );
                c += cd.EmiOtherRoeQuests1.Count( x => x != 0 );
                c += cd.EmiOtherRoeQuests2.Count( x => x != 0 );
                c += cd.EmiOtherRoeQuests3.Count( x => x != 0 );
                cd.EmiCompleted = c;
                MessageBox.Show( "完了しました。", caption, MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            return;
        }

        private void ToolStripMenuItem166_Click( object sender, EventArgs e )
        {
            System.Text.StringBuilder sb = new();

            sb.AppendLine( "・スキルはログに表示される素の値を入力してください。" );
            sb.AppendLine( "・ファントムロールはアビリティですが，習得方法が似ているため魔法に分類しています。" );
            sb.AppendLine( "・エミネンス・レコードはコンプリート数に入る目標のみ掲載しています。" );
            sb.AppendLine( "・エミネンス・レコードの『コンテンツ：リンバス』について，リンバスのリニューアルに伴いゲーム内の目標から削除されましたが，コンプリート数には加算されるため残しています。" );
            MessageBox.Show( $"{sb}", "ヒント", MessageBoxButtons.OK, MessageBoxIcon.Information );
            return;
        }

        private void ToolStripMenuItem173_Click( object sender, EventArgs e )
        {
            ToolStripMenuItem i = (ToolStripMenuItem)sender;
            using( System.Diagnostics.Process p = new() ) {
                p.StartInfo.FileName = SetUrl( i.Name! );
                p.StartInfo.UseShellExecute = true;
                p.Start();
            }
            return;

            static string SetUrl( string s )
            {
                return s switch {
                    "toolStripMenuItem173" => "https://github.com/Watchaxx/FF11stats",
                    "toolStripMenuItem174" => "http://www.playonline.com/ff11/index.shtml",
                    "toolStripMenuItem175" => "https://wiki.ffo.jp/",
                    _ => throw new ArgumentException( "外部 URL" ),
                };
            }
        }

        private void FormMain_FormClosing( object sender, FormClosingEventArgs e )
        {
            string s = "ファイルに保存しますか？";

            if( string.IsNullOrWhiteSpace( edit ) is false ) {
                s += $"{Environment.NewLine}{Environment.NewLine}{edit}";
            }
            switch( MessageBox.Show( s, "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3 ) ) {
            case DialogResult.Yes:
                string p = edit;

                if( string.IsNullOrWhiteSpace( edit ) is true ) {
                    using SaveFileDialog sfd = new();

                    sfd.FileName = cd.Name;
                    sfd.Filter = "キャラクタ ファイル|*.chr";
                    if( sfd.ShowDialog() is DialogResult.OK ) {
                        p = sfd.FileName;
                    } else {
                        e.Cancel = true;
                        break;
                    }
                }
                File.WriteAllBytes( p, JsonSerializer.SerializeToUtf8Bytes( cd ) );
                break;
            case DialogResult.Cancel:
                e.Cancel = true;
                break;
            }
            return;
        }
    }
}
