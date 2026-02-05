using static FF11stats.Program;

namespace FF11Stats
{
    public partial class FormVanaClock : Form
    {
        const int vDaySec = 3600 * 24 / 25;
        static string[] Moon = [];
        static (string, Color)[] Week = [];

        private struct VanaTime
        {
            public int Year;
            public int Month;
            public int Day;
            public int Week;
            public int Hour;
            public int Minute;
            public int Moon;
            public int Today;
            public int TotalSec;

            public VanaTime( DateTime dt )
            {
                TotalSec = (int)( dt - new DateTimeOffset( 2002, 1, 1, 0, 0, 0, TimeSpan.FromHours( 9d ) ) ).TotalSeconds;
                int vDays = TotalSec / vDaySec;
                Year = vDays / 360 + 886;
                Month = vDays / 30 % 12 + 1;
                Day = vDays % 30 + 1;
                Week = vDays % 8;
                Hour = TotalSec % vDaySec * 25 / 3600 % 24;
                Minute = TotalSec % vDaySec * 25 / 60 % 60;
                Moon = vDays / 7 % 12;
                Today = vDays * vDaySec;
            }
        }

        public FormVanaClock()
        {
            InitializeComponent();

            Moon = [label15.Text, label16.Text, label17.Text, label18.Text, label19.Text, label20.Text,
                label21.Text, label22.Text, label23.Text, label24.Text, label25.Text, label26.Text];
            Week = [(label6.Text, Color.Red), (label7.Text, Color.Yellow),
                (label8.Text, Color.SlateBlue), (label9.Text, Color.LimeGreen),
                (label10.Text, Color.SkyBlue), (label11.Text, Color.Plum),
                (label12.Text, Color.FromArgb( 205, 211, 188 )), (label13.Text, Color.DarkMagenta)];
            SuspendLayout();
            foreach( Control c in tableLayoutPanel4.Controls ) {
                c.Anchor = AnchorStyles.Top;
            }
            label27.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            label100.Text = $"ジュノ→サンドリア{Environment.NewLine}バストゥーク→ジュノ";
            label102.Text = $"ジュノ→ウィンダス{Environment.NewLine}カザム→ジュノ";
            label104.Text = $"ジュノ→バストゥーク{Environment.NewLine}サンドリア→ジュノ";
            label106.Text = $"ジュノ→カザム{Environment.NewLine}ウィンダス→ジュノ";
            label124.Text = cd.Unity switch {
                0 => "ユニティに所属すると表示されます。",
                1 => "ユニティ：ピエージェ",
                2 => "ユニティ：}アヤメ",
                3 => "ユニティ：インビンシブルシールド",
                4 => "ユニティ：アプルル",
                5 => "ユニティ：マート",
                6 => "ユニティ：アルド",
                7 => "ユニティ：ジャコ・ワーコンダロ",
                8 => "ユニティ：ナジャ・サラヒム",
                9 => "ユニティ：フラヴィリア",
                10 => "ユニティ：ヨランオラン",
                11 => "ユニティ：シルヴィ",
                _ => throw new InvalidOperationException( "ユニティ" )
            };
            ResumeLayout();
        }

        private void Timer1_Tick( object sender, EventArgs e )
        {
            Color cDef = Color.FromKnownColor( KnownColor.Control );
            Color cGre = Color.FromKnownColor( KnownColor.LightGreen );
            DateTime now = DateTime.Now.ToLocalTime();
            VanaTime vt = new( now );
            Label[] lWeek = [label6, label7, label8, label9, label10, label11, label12, label13];
            Label[] lMoon = [label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label26];
            bool isOpen = vt.Hour is >= 3 and < 18;

            SuspendLayout();
            label2.Text = $"[{vt.Year}/{vt.Month}/{vt.Day}({Week[vt.Week].Item1}) {vt.Hour}:{vt.Minute:00} <{Moon[vt.Moon]}>]";
            label4.Text = $"[{now:yyyy/M/d}({now:ddd}) {now.ToLongTimeString()}]";
            foreach( Label l in lWeek ) {
                l.BackColor = cDef;
            }
            foreach( Label l in lMoon ) {
                l.BackColor = cDef;
            }
            lWeek[vt.Week].BackColor = Week[vt.Week].Item2;
            lMoon[vt.Moon].BackColor = Color.Yellow;
            label29.BackColor = isOpen ? cGre : cDef;
            label30.Text = isOpen ? Shop( 18 ) : Shop( 3, isOpen );
            label31.BackColor = isOpen ? cGre : cDef;
            label32.Text = isOpen ? Shop( 18 ) : Shop( 3, isOpen );
            isOpen = vt.Hour is >= 3 and < 23;
            label33.BackColor = isOpen ? cGre : cDef;
            label34.Text = isOpen ? Shop( 23 ) : Shop( 3, isOpen );
            isOpen = vt.Hour is >= 1 and < 18;
            label35.BackColor = isOpen ? cGre : cDef;
            label36.Text = isOpen ? Shop( 18 ) : Shop( 1, isOpen );
            label37.BackColor = isOpen ? cGre : cDef;
            label38.Text = isOpen ? Shop( 18 ) : Shop( 1, isOpen );
            isOpen = vt.Hour is >= 6 and < 21;
            label40.BackColor = isOpen ? cGre : cDef;
            label41.Text = isOpen ? Shop( 21 ) : Shop( 6, isOpen );
            isOpen = vt.Hour is >= 5 and < 22;
            label42.BackColor = isOpen ? cGre : cDef;
            label43.Text = isOpen ? Shop( 22 ) : Shop( 5, isOpen );
            isOpen = vt.Hour is >= 6 and < 21;
            label44.BackColor = isOpen ? cGre : cDef;
            label45.Text = isOpen ? Shop( 21 ) : Shop( 6, isOpen );
            isOpen = vt.Hour is >= 8 and < 23;
            label47.BackColor = isOpen ? cGre : cDef;
            label48.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            label49.BackColor = isOpen ? cGre : cDef;
            label50.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            label51.BackColor = isOpen ? cGre : cDef;
            label52.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            label53.BackColor = isOpen ? cGre : cDef;
            label54.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            label56.BackColor = isOpen ? cGre : cDef;
            label57.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            label58.BackColor = isOpen ? cGre : cDef;
            label59.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            label60.BackColor = isOpen ? cGre : cDef;
            label61.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            isOpen = vt.Hour is >= 6 and < 21;
            label63.BackColor = isOpen ? cGre : cDef;
            label64.Text = isOpen ? Shop( 21 ) : Shop( 6, isOpen );
            label65.BackColor = isOpen ? cGre : cDef;
            label66.Text = isOpen ? Shop( 21 ) : Shop( 6, isOpen );
            label67.BackColor = isOpen ? cGre : cDef;
            label68.Text = isOpen ? Shop( 21 ) : Shop( 6, isOpen );
            isOpen = vt.Hour is >= 3 and < 18;
            label70.BackColor = isOpen ? cGre : cDef;
            label71.Text = isOpen ? Shop( 18 ) : Shop( 3, isOpen );
            isOpen = vt.Hour is >= 8 and < 23;
            label73.BackColor = isOpen ? cGre : cDef;
            label74.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            label76.BackColor = isOpen ? cGre : cDef;
            label77.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            label78.BackColor = isOpen ? cGre : cDef;
            label79.Text = isOpen ? Shop( 23 ) : Shop( 8, isOpen );
            isOpen = vt.Hour is >= 5 and < 20;
            label81.BackColor = isOpen ? cGre : cDef;
            label82.Text = isOpen ? Shop( 20 ) : Shop( 5, isOpen );
            label86.Text = TimeTable( [(8, 0), (16, 0), (24, 0)] );
            label89.Text = TimeTable( [(4, 0), (12, 0), (20, 0)] );
            label92.Text = TimeTable( [(8, 0), (16, 0), (24, 0)] );

            string[] bm = BargeManaclipper( 'b' );

            label94.Text = bm[0];
            label95.Text = bm[1];
            bm = BargeManaclipper( 'm' );
            label97.Text = bm[0];
            label98.Text = bm[1];
            label101.Text = TimeTable( [(1, 15), (7, 15), (13, 15), (19, 15)] );
            label103.Text = TimeTable( [(2, 45), (8, 45), (14, 45), (20, 45)] );
            label105.Text = TimeTable( [(4, 15), (10, 15), (16, 15), (22, 15)] );
            label107.Text = TimeTable( [(5, 45), (11, 45), (17, 45), (23, 45)] );
            switch( vt.Day % 3 ) {
            case 0:
                label109.Text = "サンドリア→ジュノ上層";
                label110.Text = "バストゥーク→サンドリア";
                label111.Text = "ウィンダス→バストゥーク";
                label112.Text = ".";
                break;
            case 1:
                label109.Text = "サンドリア→バストゥーク";
                label110.Text = "バストゥーク→ウィンダス";
                label111.Text = "ウィンダス→ジュノ港";
                label112.Text = "カザム→ノーグ";
                break;
            case 2:
                label109.Text = "サンドリア→ウィンダス";
                label110.Text = "バストゥーク→ジュノ下層";
                label111.Text = "ウィンダス→サンドリア";
                label112.Text = ".";
                break;
            }

            const string uni = "ユニティ：";
            const string obj0 = "ユニティチャットで発言する";
            const string obj1 = "ユニティメンバーとパーティを組む";
            const string obj2 = "モンスター討伐数合計";
            const string obj3 = "類を倒す";
            const string obj4 = "類を物理ダメージで倒す";
            const string obj5 = "類を魔法ダメージで倒す";
            const string obj6 = "成功回数合計";
            const string obj9 = "ユニティリーダーフェイスと討伐";
            const string db = "状態異常回復(UC)";
            const string hp = "HP回復(UC)";
            const string mb = "マジックバースト(UC)";
            const string ws = "ウェポンスキル使用回数(UC)";
            int uday = (int)( now - new DateTime( 2026, 1, 19 ) ).TotalDays;

            switch( uday % 6 ) {
            case 0:
                label113.Text = $"{uni}共通A";
                label114.Text = $"{obj0}A(UC)";
                label115.Text = $"{obj1}A(UC)";
                label116.Text = $"{obj2}A(UC)";
                label117.Text = $"アクアン{obj3}A(UC)";
                label118.Text = $"アモルフ{obj4}A(UC)";
                label119.Text = $"ビースト{obj5}A(UC)";
                label120.Text = $"木工{obj6}A(UC)";
                label121.Text = $"革細工{obj6}A(UC)";
                label122.Text = $"採掘{obj6}A(UC)";
                label123.Text = $"{obj9}A(UC)";
                break;
            case 1:
                label113.Text = $"{uni}共通B";
                label114.Text = $"{obj0}B(UC)";
                label115.Text = $"チョコボ掘り{obj6}B(UC)";
                label116.Text = $"{obj2}B(UC)";
                label117.Text = $"アルカナ{obj3}B(UC)";
                label118.Text = $"アンデッド{obj4}B(UC)";
                label119.Text = $"プラントイド{obj5}B(UC)";
                label120.Text = $"鍛冶{obj6}B(UC)";
                label121.Text = $"小型の獲物合計N(UC)";
                label122.Text = $"伐採{obj6}B(UC)";
                label123.Text = $"{obj9}B(UC)";
                break;
            case 2:
                label113.Text = $"{uni}共通C";
                label114.Text = $"{obj0}C(UC)";
                label115.Text = $"{obj1}C(UC)";
                label116.Text = $"{obj2}C(UC)";
                label117.Text = $"ヴァーミン{obj3}C(UC)";
                label118.Text = $"バード{obj4}C(UC)";
                label119.Text = $"リザード{obj5}C(UC)";
                label120.Text = $"彫金{obj6}C(UC)";
                label121.Text = $"大型の獲物合計C(UC)";
                label122.Text = $"収穫{obj6}C(UC)";
                label123.Text = $"{obj9}C(UC)";
                break;
            case 3:
                label113.Text = $"{uni}共通D";
                label114.Text = $"{obj0}D(UC)";
                label115.Text = $"モンプレ：{obj2}D(UC)";
                label116.Text = $"{obj2}D(UC)";
                label117.Text = $"ビースト{obj3}D(UC)";
                label118.Text = $"アクアン{obj4}D(UC)";
                label119.Text = $"アモルフ{obj5}D(UC)";
                label120.Text = $"裁縫{obj6}D(UC)";
                label121.Text = $"骨細工{obj6}D(UC)";
                label122.Text = $"採掘{obj6}D(UC)";
                label123.Text = $"{obj9}D(UC)";
                break;
            case 4:
                label113.Text = $"{uni}共通E";
                label114.Text = $"{obj0}E(UC)";
                label115.Text = $"{obj1}E(UC)";
                label116.Text = $"{obj2}E(UC)";
                label117.Text = $"プラントイド{obj3}E(UC)";
                label118.Text = $"アルカナ{obj4}E(UC)";
                label119.Text = $"アンデッド{obj5}E(UC)";
                label120.Text = $"調理{obj6}E(UC)";
                label121.Text = $"獲物合計(海水)E(UC)";
                label122.Text = $"伐採{obj6}E(UC)";
                label123.Text = $"{obj9}E(UC)";
                break;
            case 5:
                label113.Text = $"{uni}共通F";
                label114.Text = $"{obj0}F(UC)";
                label115.Text = $"レベルシンク中討伐数F(UC)";
                label116.Text = $"{obj2}F(UC)";
                label117.Text = $"リザード{obj3}F(UC)";
                label118.Text = $"ヴァーミン{obj4}F(UC)";
                label119.Text = $"バード{obj5}F(UC)";
                label120.Text = $"錬金術{obj6}F(UC)";
                label121.Text = $"獲物合計(淡水)F(UC)";
                label122.Text = $"収穫{obj6}F(UC)";
                label123.Text = $"{obj9}F(UC)";
                break;
            }
            if( cd.Unity != 0 ) {
                switch( cd.Unity ) {
                case 1: // ピエージェ
                    switch( uday / 7 % 4 ) {
                    case 0:
                        label125.Text = $"片手棍{ws}";
                        label126.Text = "戦闘：ララ水道(UC)";
                        label127.Text = "ウサギ族を倒す";
                        label128.Text = "討伐:Rambukk(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(コウモリの牙)(UC)";
                        label126.Text = "戦闘：ラテーヌ高原(UC)";
                        label127.Text = "コウモリ族を倒す(UC)";
                        label128.Text = "討伐:Tumbling Truggle(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"両手棍{ws}";
                        label126.Text = "戦闘：エルディーム古墳(UC)";
                        label127.Text = "樹人族を倒す(UC)";
                        label128.Text = "討伐:Duke Decapod(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(ボムの灰)(UC)";
                        label126.Text = "戦闘：ダボイ(UC)";
                        label127.Text = "ボム族を倒す(UC)";
                        label128.Text = "討伐:Poisonhand Gnadgad(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 2: // アヤメ
                    switch( uday / 7 % 4 ) {
                    case 0:
                        label125.Text = $"両手刀{ws}";
                        label126.Text = "戦闘：北グスタベルグ(UC)";
                        label127.Text = "ワーム族を倒す(UC)";
                        label128.Text = "討伐:Stinging Sophie(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(コカトリスの肉)(UC)";
                        label126.Text = "戦闘：ヤッセの狩り場(UC)";
                        label127.Text = "コカトリス族を倒す(UC)";
                        label128.Text = "討伐:Tococo(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"弓術{ws}";
                        label126.Text = "戦闘：クロウラーの巣(UC)";
                        label127.Text = "トカゲ族を倒す(UC)";
                        label128.Text = "討伐:Aqrabuamelu(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(陸ガニの肉)(UC)";
                        label126.Text = "戦闘：ベドー(UC)";
                        label127.Text = "クラブ族を倒す(UC)";
                        label128.Text = "討伐:Ge'Dha Evileye(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 3: // インビンシブルシールド
                    switch( uday / 7 % 5 ) {
                    case 0:
                        label125.Text = $"片手斧{ws}";
                        label126.Text = "戦闘：南グスタベルグ(UC)";
                        label127.Text = "頭足族を倒す(UC)";
                        label128.Text = "討伐:Leaping Lizzy(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(ネムリタケ)(UC)";
                        label126.Text = "戦闘：パシュハウ沼(UC)";
                        label127.Text = "キノコ族を倒す(UC)";
                        label128.Text = "討伐:Bloodpool Vorax(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"両手斧{ws}";
                        label126.Text = "戦闘：ケイザック古戦場(UC)";
                        label127.Text = "フライ族を倒す(UC)";
                        label128.Text = "討伐:Be'Hya Hundredwall(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(ラプトルの皮)(UC)";
                        label126.Text = "戦闘：ボスディン氷河(UC)";
                        label127.Text = "ラプトル族を倒す(UC)";
                        label128.Text = "討伐:Gargantua(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 4: // アプルル
                    switch( uday / 7 % 5 ) {
                    case 0:
                        label125.Text = $"片手棍{ws}";
                        label126.Text = "戦闘：西サルタバルタ(UC)";
                        label127.Text = "蜂族を倒す(UC)";
                        label128.Text = "討伐:Tom Tit Tat(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(絹糸)(UC)";
                        label126.Text = "戦闘：ブブリム半島(UC)";
                        label127.Text = "クロウラー族を倒す(UC)";
                        label128.Text = "討伐:Buburimboo(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"両手棍{ws}";
                        label126.Text = "戦闘：オズトロヤ城(UC)";
                        label127.Text = "ゴースト族を倒す(UC)";
                        label128.Text = "討伐:Mee Deggi the Punisher(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(サルタ綿花)(UC)";
                        label126.Text = "戦闘：エヌティエル水林(UC)";
                        label127.Text = "マンドラゴラ族を倒す(UC)";
                        label128.Text = "討伐:Juu Duzu the Whirlwind(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 5: // マート
                    switch( uday / 7 % 5 ) {
                    case 0:
                        label125.Text = $"格闘{ws}";
                        label126.Text = "戦闘：ヨルシア森林(UC)";
                        label127.Text = "リーチ族を倒す(UC)";
                        label128.Text = "討伐:Canal Moocher(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(蜘蛛の網)(UC)";
                        label126.Text = "戦闘：ロランベリー耕地(UC)";
                        label127.Text = "スパイダー族を倒す(UC)";
                        label128.Text = "討伐:Eldritch Edge(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"両手剣{ws}";
                        label126.Text = "戦闘：メリファト山地(UC)";
                        label127.Text = "ワイバーン族を倒す(UC)";
                        label128.Text = "討伐:Patripatan(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(ヘクトアイズの眼)(UC)";
                        label126.Text = "戦闘：ソロムグ原野(UC)";
                        label127.Text = "ヘクトアイズ族を倒す(UC)";
                        label128.Text = "討伐:Bashe(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 6: // アルド
                    switch( uday / 7 % 5 ) {
                    case 0:
                        label125.Text = $"短剣{ws}";
                        label126.Text = "戦闘：聖地ジ・タ(UC)";
                        label127.Text = "屍犬族を倒す(UC)";
                        label128.Text = "討伐:Bastet(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(ドールの破片)(UC)";
                        label126.Text = "戦闘：モリマー台地(UC)";
                        label127.Text = "ドール族を倒す(UC)";
                        label128.Text = "討伐:Nocuous Weapon(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"射撃{ws}";
                        label126.Text = "戦闘：ボヤーダ樹(UC)";
                        label127.Text = "スライム族を倒す(UC)";
                        label128.Text = "討伐:Aquarius(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(鳥の卵)(UC)";
                        label126.Text = "戦闘：西アルテパ砂漠(UC)";
                        label127.Text = "死鳥族を倒す(UC)";
                        label128.Text = "討伐:Cactuar Cantautor(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 7: // ジャコ・ワーコンダロ
                    switch( uday / 7 % 5 ) {
                    case 0:
                        label125.Text = $"短剣{ws}";
                        label126.Text = "戦闘：ユタンガ大森林(UC)";
                        label127.Text = "大羊族を倒す(UC)";
                        label128.Text = "討伐:Mischievous Micholas(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(大サソリの爪)(UC)";
                        label126.Text = "戦闘：東サルタバルタ(UC)";
                        label127.Text = "サソリ族を倒す(UC)";
                        label128.Text = "討伐:Sharp-Eared Ropipi(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"弓術{ws}";
                        label126.Text = "戦闘：マリアミ渓谷(UC)";
                        label127.Text = "オポオポ族を倒す(UC)";
                        label128.Text = "討伐:Ah Puch(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(黒虎の牙)(UC)";
                        label126.Text = "戦闘：海蛇の岩窟(UC)";
                        label127.Text = "剣虎族を倒す(UC)";
                        label128.Text = "討伐:Fyuu the Seabellow(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 8: // ナジャ・サラヒム
                    switch( uday / 7 % 5 ) {
                    case 0:
                        label125.Text = $"片手棍{ws}";
                        label126.Text = "戦闘：バフラウ段丘(UC)";
                        label127.Text = "イビルウェポン族を倒す(UC)";
                        label128.Text = "討伐:Emergent Elm(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(プークの翅)(UC)";
                        label126.Text = "戦闘：西ロンフォール(UC)";
                        label127.Text = "プーク族を倒す(UC)";
                        label128.Text = "討伐:Fungus Beetle(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"両手棍{ws}";
                        label126.Text = "戦闘：ワジャーム樹林(UC)";
                        label127.Text = "エレメンタル族を倒す(UC)";
                        label128.Text = "討伐:Jaded Jody(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(ダルメルの肉)(UC)";
                        label126.Text = "戦闘：カミール山麓(UC)";
                        label127.Text = "ダルメル族を倒す(UC)";
                        label128.Text = "討伐:Trembler Tabitha(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 9: // フラヴィリア
                    switch( uday / 7 % 5 ) {
                    case 0:
                        label125.Text = $"両手槍{ws}";
                        label126.Text = "戦闘：シルダス洞窟(UC)";
                        label127.Text = "プギル族を倒す(UC)";
                        label128.Text = "討伐:Hovering Hotpot(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(甲虫の甲殻)(UC)";
                        label126.Text = "戦闘：東ロンフォール(UC)";
                        label127.Text = "甲虫族を倒す(UC)";
                        label128.Text = "討伐:Bigmouth Billy(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"片手剣{ws}";
                        label126.Text = "戦闘：ザルカバード(UC)";
                        label127.Text = "グゥーブー族を倒す(UC)";
                        label128.Text = "討伐:Barbaric Weapon(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(骨くず)(UC)";
                        label126.Text = "戦闘：ウォーの門(UC)";
                        label127.Text = "スケルトン族を倒す(UC)";
                        label128.Text = "討伐:Hyakume(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 10:    // ヨランオラン
                    switch( uday / 7 % 5 ) {
                    case 0:
                        label125.Text = $"片手棍{ws}";
                        label126.Text = "戦闘：ギデアス(UC)";
                        label127.Text = "エフト族を倒す(UC)";
                        label128.Text = "討伐:Herbage Hunter(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(腐肉)(UC)";
                        label126.Text = "戦闘：モーの門(UC)";
                        label127.Text = "アンティカ族を倒す(UC)";
                        label128.Text = "討伐:Antican Praefectus(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"両手棍{ws}";
                        label126.Text = "戦闘：トライマライ水路(UC)";
                        label127.Text = "クァール族を倒す(UC)";
                        label128.Text = "討伐:Ose(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(デュラハンの鎧)(UC)";
                        label126.Text = "戦闘：ラ・カザナル宮外郭(UC)";
                        label127.Text = "デュラハン族を倒す(UC)";
                        label128.Text = "討伐:Capricious Cassie(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                case 11:    // シルヴィ
                    switch( uday / 7 % 5 ) {
                    case 0:
                        label125.Text = $"片手棍{ws}";
                        label126.Text = "戦闘：シィの門(UC)";
                        label127.Text = "アクエフ族を倒す(UC)";
                        label128.Text = "討伐:Intulo(UC)";
                        label129.Text = hp;
                        break;
                    case 1:
                        label125.Text = "戦利品(魔人の角)(UC)";
                        label126.Text = "戦闘：コンシュタット高地(UC)";
                        label127.Text = "デーモン族を倒す(UC)";
                        label128.Text = "討伐:Marquis Naberius(UC)";
                        label129.Text = db;
                        break;
                    case 2:
                        label125.Text = $"両手棍{ws}";
                        label126.Text = "戦闘：ドーの門(UC)";
                        label127.Text = "ヴェルク族を倒す(UC)";
                        label128.Text = "討伐:Dune Widow(UC)";
                        label129.Text = hp;
                        break;
                    case 3:
                        label125.Text = "戦利品(トウィザリムの翅)(UC)";
                        label126.Text = "戦闘：クフィム島(UC)";
                        label127.Text = "トウィザリム族を倒す(UC)";
                        label128.Text = "討伐:Atkorkamuy(UC)";
                        label129.Text = mb;
                        break;
                    }
                    break;
                }
            }
            label131.BackColor = ( vt.Hour & 1 ) is 0 ? cGre : cDef;
            label132.BackColor = ( ( vt.Hour & 1 ) is 0 && ( 30 <= vt.Minute ) ) || ( ( vt.Hour & 1 ) is 1 && ( vt.Minute < 30 ) ) ? cGre : cDef;
            label133.BackColor = ( vt.Hour & 1 ) is 1 ? cGre : cDef;
            label134.BackColor = ( ( vt.Hour & 1 ) is 1 && ( 30 <= vt.Minute ) ) || ( ( vt.Hour & 1 ) is 0 && ( vt.Minute < 30 ) ) ? cGre : cDef;
            ResumeLayout();
            return;

            string[] BargeManaclipper( char c )
            {
                int[] table = [];
                string[] name = [];

                if( c is 'b' ) {
                    table = [60 * 50 / 25, ( 3600 * 5 + 60 * 10 ) / 25, ( 3600 * 10 + 60 * 10 ) / 25, ( 3600 * 17 + 60 * 25 ) / 25, ( 3600 * 19 + 60 * 50 ) / 25];
                    name = ["南桟橋→中桟橋", "中桟橋→南桟橋", "南桟橋→北桟橋", "北桟橋→中桟橋", "中桟橋→南桟橋"];
                } else if( c is 'm' ) {
                    table = [60 * 45 / 25, ( 3600 * 5 + 60 * 30 ) / 25, ( 3600 * 9 + 60 * 15 ) / 25, ( 3600 * 12 + 60 * 45 ) / 25, ( 3600 * 17 + 60 * 30 ) / 25, ( 3600 * 21 + 60 * 15 ) / 25];
                    name = ["ダルメルロック遊覧", "夕照桟橋→プルゴノルゴ島", "プルゴノルゴ島→夕照桟橋", "マリヤカレヤリーフ遊覧", "夕照桟橋→プルゴノルゴ島", "プルゴノルゴ島→夕照桟橋"];
                } else {
                    throw new ArgumentException( "バージ/マナクリッパー" );
                }
                foreach( var (v, i) in table.Select( ( v, i ) => (v, i) ) ) {
                    if( vt.TotalSec < vt.Today + v ) {
                        return [name[i], $"{TimeSpan.FromSeconds( vt.Today + v - vt.TotalSec ):m\\:ss}"];
                    }
                }
                return [name[0], $"{TimeSpan.FromSeconds( vt.Today + vDaySec + table[0] - vt.TotalSec ):m\\:ss}"];
            }

            string Shop( int t, bool b = true )
            {
                return b || vt.Hour < t
                    ? $"{TimeSpan.FromSeconds( vt.Today + 3600L * t / 25 - vt.TotalSec ):m\\:ss}"
                    : $"{TimeSpan.FromSeconds( vt.Today + vDaySec + 3600L * t / 25 - vt.TotalSec ):m\\:ss}";
            }

            string TimeTable( (int, int)[] t )
            {
                foreach( (int h, int m) in t ) {
                    int sec = vt.Today + ( 3600 * h + 60 * m ) / 25;

                    if( vt.TotalSec < sec ) {
                        return $"{TimeSpan.FromSeconds( sec - vt.TotalSec ):m\\:ss}";
                    }
                }
                return $"{TimeSpan.FromSeconds( vt.Today + vDaySec + ( 3600 * t[0].Item1 + 60 * t[0].Item2 ) / 25 - vt.TotalSec ):m\\:ss}";
            }
        }
    }
}
