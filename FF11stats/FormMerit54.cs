using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMerit54 : Form
    {
        internal FormMerit54( Jobs j )
        {
            InitializeComponent();

            uint g1 = 0;
            uint g2 = 0;
            Label[] lbl = [label3, label4, label5, label6, label7, label10, label11, label12, label13];

            job = j;
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                }
            }
            switch( job ) {
            case Jobs.War:
                g1 = cd.MeritWar1;
                g2 = cd.MeritWar2;
                Text += "戦士";
                lbl[0].Text = "バーサク使用間隔";
                lbl[1].Text = "ディフェンダー使用間隔";
                lbl[2].Text = "ウォークライ使用間隔";
                lbl[3].Text = "アグレッサー使用間隔";
                lbl[4].Text = "ダブルアタック確率";
                lbl[5].Text = "ウォリアーチャージ";
                lbl[6].Text = "トマホーク";
                lbl[7].Text = "サベッジリ";
                lbl[8].Text = "アグレシブエイム";
                break;
            case Jobs.Mnk:
                g1 = cd.MeritMnk1;
                g2 = cd.MeritMnk2;
                Text += "モンク";
                lbl[0].Text = "集中使用間隔";
                lbl[1].Text = "回避使用間隔";
                lbl[2].Text = "チャクラ使用間隔";
                lbl[3].Text = "カウンター確率";
                lbl[4].Text = "蹴撃確率";
                lbl[5].Text = "マントラ";
                lbl[6].Text = "無想無念";
                lbl[7].Text = "練気";
                lbl[8].Text = "発剄";
                break;
            case Jobs.Whm:
                g1 = cd.MeritWhm1;
                g2 = cd.MeritWhm2;
                Text += "白魔道士";
                lbl[0].Text = "女神の印使用間隔";
                lbl[1].Text = "ケアル詠唱時間";
                lbl[2].Text = "属性耐性魔法効果";
                lbl[3].Text = "バニシュ効果";
                lbl[4].Text = "リジェネ効果";
                lbl[5].Text = "マーター";
                lbl[6].Text = "デヴォーション";
                lbl[7].Text = "ソウルオブソラス";
                lbl[8].Text = "ソウルオブミゼリ";
                break;
            case Jobs.Thf:
                g1 = cd.MeritThf1;
                g2 = cd.MeritThf2;
                Text += "シーフ";
                lbl[0].Text = "とんずら使用間隔";
                lbl[1].Text = "かくれる使用間隔";
                lbl[2].Text = "不意打ち使用間隔";
                lbl[3].Text = "だまし討ち使用間隔";
                lbl[4].Text = "トリプルアタック確率";
                lbl[5].Text = "アサシンチャージ";
                lbl[6].Text = "フェイント";
                lbl[7].Text = "オーラスティール";
                lbl[8].Text = "アンブッシュ";
                break;
            case Jobs.Pld:
                g1 = cd.MeritPld1;
                g2 = cd.MeritPld2;
                Text += "ナイト";
                lbl[0].Text = "シールドバッシュ使用間隔";
                lbl[1].Text = "ホーリーサークル使用間隔";
                lbl[2].Text = "センチネル使用間隔";
                lbl[3].Text = "かばう効果時間";
                lbl[4].Text = "ランパート使用間隔";
                lbl[5].Text = "フィールティ";
                lbl[6].Text = "シバルリー";
                lbl[7].Text = "アイアンウィル";
                lbl[8].Text = "ガーディアン";
                break;
            case Jobs.Drk:
                g1 = cd.MeritDrk1;
                g2 = cd.MeritDrk2;
                Text += "暗黒騎士";
                lbl[0].Text = "暗黒使用間隔";
                lbl[1].Text = "アルケインサークル使用間隔";
                lbl[2].Text = "ラストリゾート使用間隔";
                lbl[3].Text = "ラストリゾート効果";
                lbl[4].Text = "ウェポンバッシュ使用間隔";
                lbl[5].Text = "ダークシール";
                lbl[6].Text = "ディアボリクアイ";
                lbl[7].Text = "ミューテッドソウル";
                lbl[8].Text = "デスペレートブロー効果";
                break;
            case Jobs.Bst:
                g1 = cd.MeritBst1;
                g2 = cd.MeritBst2;
                Text += "獣使い";
                lbl[0].Text = "キラー確率";
                lbl[1].Text = "いたわる使用間隔";
                lbl[2].Text = "よびだす使用間隔";
                lbl[3].Text = "ほんきだせ使用間隔";
                lbl[4].Text = "なだめる使用間隔";
                lbl[5].Text = "フェラルハウル";
                lbl[6].Text = "K.インスティンクト";
                lbl[7].Text = "ビーストアフニティ";
                lbl[8].Text = "ビーストヒーラー";
                break;
            case Jobs.Brd:
                g1 = cd.MeritBrd1;
                g2 = cd.MeritBrd2;
                Text += "吟遊詩人";
                lbl[0].Text = "ララバイ使用間隔";
                lbl[1].Text = "フィナーレ使用間隔";
                lbl[2].Text = "ミンネ効果";
                lbl[3].Text = "メヌエット効果";
                lbl[4].Text = "マドリガル効果";
                lbl[5].Text = "ナイチンゲール";
                lbl[6].Text = "トルバドゥール";
                lbl[7].Text = "コンアニマ";
                lbl[8].Text = "コンブリオ";
                break;
            case Jobs.Rng:
                g1 = cd.MeritRng1;
                g2 = cd.MeritRng2;
                Text += "狩人";
                lbl[0].Text = "スカベンジ効果";
                lbl[1].Text = "カモフラージュ使用間隔";
                lbl[2].Text = "狙い撃ち使用間隔";
                lbl[3].Text = "エンドレスショット使用間隔";
                lbl[4].Text = "ラピッドショット確率";
                lbl[5].Text = "ステルスショット";
                lbl[6].Text = "フラッシーショット";
                lbl[7].Text = "スナップショット";
                lbl[8].Text = "リサイクル確率";
                break;
            case Jobs.Sam:
                g1 = cd.MeritSam1;
                g2 = cd.MeritSam2;
                Text += "侍";
                lbl[0].Text = "心眼使用間隔";
                lbl[1].Text = "護摩の守護円使用間隔";
                lbl[2].Text = "ストアTP効果";
                lbl[3].Text = "黙想使用間隔";
                lbl[4].Text = "残心確率";
                lbl[5].Text = "士気昂揚";
                lbl[6].Text = "峰打ち";
                lbl[7].Text = "意気衝天";
                lbl[8].Text = "正正堂堂";
                break;
            case Jobs.Drg:
                g1 = cd.MeritDrg1;
                g2 = cd.MeritDrg2;
                Text += "竜騎士";
                lbl[0].Text = "エンシェントサークル使用間隔";
                lbl[1].Text = "ジャンプ使用間隔";
                lbl[2].Text = "ハイジャンプ使用間隔";
                lbl[3].Text = "スーパージャンプ使用間隔";
                lbl[4].Text = "スピリットリンク使用間隔";
                lbl[5].Text = "ディープブリージング";
                lbl[6].Text = "アンゴン";
                lbl[7].Text = "エンパシー";
                lbl[8].Text = "ストレイフ効果";
                break;
            case Jobs.Blu:
                g1 = cd.MeritBlu1;
                g2 = cd.MeritBlu2;
                Text += "青魔道士";
                lbl[0].Text = "ブルーチェーン使用間隔";
                lbl[1].Text = "ブルーバースト使用間隔";
                lbl[2].Text = "モンスター相関関係効果";
                lbl[3].Text = "物理系青魔法攻撃力";
                lbl[4].Text = "魔法系青魔法命中率";
                lbl[5].Text = "コンバージェンス";
                lbl[6].Text = "ディフュージョン";
                lbl[7].Text = "エンチェーンメント";
                lbl[8].Text = "アシミレーション";
                break;
            case Jobs.Cor:
                g1 = cd.MeritCor1;
                g2 = cd.MeritCor2;
                Text += "コルセア";
                lbl[0].Text = "ファントムロール使用間隔";
                lbl[1].Text = "クイックドロー使用間隔";
                lbl[2].Text = "クイックドロー命中率";
                lbl[3].Text = "ランダムディール使用間隔";
                lbl[4].Text = "Bust時間短縮";
                lbl[5].Text = "スネークアイ";
                lbl[6].Text = "フォールド";
                lbl[7].Text = "ウィニングストリーク";
                lbl[8].Text = "ローデッドデッキ";
                break;
            case Jobs.Pup:
                g1 = cd.MeritPup1;
                g2 = cd.MeritPup2;
                Text += "からくり士";
                lbl[0].Text = "オートマトンスキル";
                lbl[1].Text = "フラッシング使用間隔";
                lbl[2].Text = "リペアー効果";
                lbl[3].Text = "アクティベート使用間隔";
                lbl[4].Text = "リペアー使用間隔";
                lbl[5].Text = "黒衣チェンジ";
                lbl[6].Text = "腹話術";
                lbl[7].Text = "微調整";
                lbl[8].Text = "最適化";
                break;
            case Jobs.Geo:
                g1 = cd.MeritGeo1;
                g2 = cd.MeritGeo2;
                Text += "風水士";
                lbl[0].Text = "フルサークル効果";
                lbl[1].Text = "サークルエンリッチ使用間隔";
                lbl[2].Text = "ライフサイクル使用間隔";
                lbl[3].Text = "グローリーブレイズ使用間隔";
                lbl[4].Text = "デマテリアライズ使用間隔";
                lbl[5].Text = "メンドハレイション";
                lbl[6].Text = "レイディアルアルカナ";
                lbl[7].Text = "キュアリカント";
                lbl[8].Text = "プライムジール";
                break;
            case Jobs.Run:
                g1 = cd.MeritRun1;
                g2 = cd.MeritRun2;
                Text += "魔導剣士";
                lbl[0].Text = "エンチャントルーン効果";
                lbl[1].Text = "ヴァレション効果";
                lbl[2].Text = "ランジ効果";
                lbl[3].Text = "フルーグ効果";
                lbl[4].Text = "ガンビット使用間隔";
                lbl[5].Text = "バットゥタ";
                lbl[6].Text = "レイク";
                lbl[7].Text = "インスパイア";
                lbl[8].Text = "スライトソード";
                break;
            }

            byte[] b = MeripoLoad( g1 );

            numericUpDown1.Value = b[0];
            numericUpDown2.Value = b[1];
            numericUpDown3.Value = b[2];
            numericUpDown4.Value = b[3];
            numericUpDown5.Value = b[4];
            b = MeripoLoad( g2 );
            numericUpDown6.Value = b[0];
            numericUpDown7.Value = b[1];
            numericUpDown8.Value = b[2];
            numericUpDown9.Value = b[3];
        }

        static decimal s1 = 0;
        static decimal s2 = 0;
        static Jobs job = Jobs.War;

        private void Button1_Click( object sender, EventArgs e )
        {
            if( MaxMeripo < s1 || MaxMeripo < s2 ) {
                MeripoErr( MaxMeripo );
                return;
            }

            uint g1 = MeripoSave32( numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value );
            uint g2 = MeripoSave32( numericUpDown6.Value, numericUpDown7.Value, numericUpDown8.Value, numericUpDown9.Value );

            switch( job ) {
            case Jobs.War:
                cd.MeritWar1 = g1;
                cd.MeritWar2 = g2;
                break;
            case Jobs.Mnk:
                cd.MeritMnk1 = g1;
                cd.MeritMnk2 = g2;
                break;
            case Jobs.Whm:
                cd.MeritWhm1 = g1;
                cd.MeritWhm2 = g2;
                break;
            case Jobs.Blm:
                cd.MeritBlm1 = g1;
                cd.MeritBlm2 = g2;
                break;
            case Jobs.Rdm:
                cd.MeritRdm1 = g1;
                cd.MeritRdm2 = g2;
                break;
            case Jobs.Thf:
                cd.MeritThf1 = g1;
                cd.MeritThf2 = g2;
                break;
            case Jobs.Pld:
                cd.MeritPld1 = g1;
                cd.MeritPld2 = g2;
                break;
            case Jobs.Drk:
                cd.MeritDrk1 = g1;
                cd.MeritDrk2 = g2;
                break;
            case Jobs.Bst:
                cd.MeritBst1 = g1;
                cd.MeritBst2 = g2;
                break;
            case Jobs.Brd:
                cd.MeritBrd1 = g1;
                cd.MeritBrd2 = g2;
                break;
            case Jobs.Rng:
                cd.MeritRng1 = g1;
                cd.MeritRng2 = g2;
                break;
            case Jobs.Sam:
                cd.MeritSam1 = g1;
                cd.MeritSam2 = g2;
                break;
            case Jobs.Nin:
                cd.MeritNin1 = g1;
                cd.MeritNin2 = g2;
                break;
            case Jobs.Drg:
                cd.MeritDrg1 = g1;
                cd.MeritDrg2 = g2;
                break;
            case Jobs.Smn:
                cd.MeritSmn1 = g1;
                cd.MeritSmn2 = g2;
                break;
            case Jobs.Blu:
                cd.MeritBlu1 = g1;
                cd.MeritBlu2 = g2;
                break;
            case Jobs.Cor:
                cd.MeritCor1 = g1;
                cd.MeritCor2 = g2;
                break;
            case Jobs.Pup:
                cd.MeritPup1 = g1;
                cd.MeritPup2 = g2;
                break;
            case Jobs.Dnc:
                cd.MeritDnc1 = g1;
                cd.MeritDnc2 = g2;
                break;
            case Jobs.Sch:
                cd.MeritSch1 = g1;
                cd.MeritSch2 = g2;
                break;
            case Jobs.Geo:
                cd.MeritGeo1 = g1;
                cd.MeritGeo2 = g2;
                break;
            case Jobs.Run:
                cd.MeritRun1 = g1;
                cd.MeritRun2 = g2;
                break;
            }
            Close();
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            Close();
            return;
        }

        private void NumericUpDown1_ValueChanged( object sender, EventArgs e )
        {
            decimal v = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value;

            s1 = v;
            label2.ForeColor = MaxMeripo < v ? Color.Red : Color.FromKnownColor( KnownColor.ControlText );
            label2.Text = $"{v}/{MaxMeripo}";
            return;
        }

        private void NumericUpDown6_ValueChanged( object sender, EventArgs e )
        {
            decimal v = numericUpDown6.Value + numericUpDown7.Value + numericUpDown8.Value + numericUpDown9.Value;

            s2 = v;
            label9.ForeColor = MaxMeripo < v ? Color.Red : Color.FromKnownColor( KnownColor.ControlText );
            label9.Text = $"{v}/{MaxMeripo}";
            return;
        }
    }
}
