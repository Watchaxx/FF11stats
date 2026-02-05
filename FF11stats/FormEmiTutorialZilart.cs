using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormEmiTutorialZilart : Form
    {
#pragma warning disable CS8618
        static sbyte[] dat;
        static int com = 0;

        internal FormEmiTutorialZilart( Mission mission )
        {
            InitializeComponent();

            int i = 0;
            int l = 0;
            int p = 0;
            string s = string.Empty;
            CheckBox[] cb = new CheckBox[20];

            switch( mission ) {
            case Mission.Zilart:
                l = 16;
                s = "ジラート";
                dat = cd.EmiTutorialZilart;
                break;
            case Mission.Promathia:
                l = 8;
                s = "プロマシア";
                dat = cd.EmiTutorialPromathia;
                break;
            case Mission.Ahturhgan:
                l = 6;
                s = "アトルガン";
                dat = cd.EmiTutorialAhturhgan;
                break;
            case Mission.Altana:
                l = 8;
                s = "アルタナ";
                dat = cd.EmiTutorialAltana;
                break;
            case Mission.Adoulin:
                l = 5;
                s = "アドゥリン";
                dat = cd.EmiTutorialAdoulin;
                break;
            default:
                throw new ArgumentException( "拡張ディスク" );
            }
            AcceptButton = userControl11.ButtonAccept;
            CancelButton = userControl11.ButtonCancel;
            Text = $"目標/チュートリアル/ミッション({s})";
            userControl11.ButtonClick += Button_Click;
            userControl11.Flp.SuspendLayout();
            foreach( int j in Enumerable.Range( 1, l ) ) {
                CheckBox c = new() {
                    AutoSize = true,
                    Name = $"obj{i:00}",
                    Size = new Size( 1, 19 ),
                    TabIndex = i,
                    Text = CbTxt( mission, j ),
                    UseVisualStyleBackColor = true
                };

                if( dat[int.Parse( c.Name.Substring( 3 ) )] != 0 ) {
                    p++;
                    c.Checked = true;
                }
                cb[i] = c;
                i++;
            }
            userControl11.Flp.Controls.AddRange( cb );
            userControl11.Flp.ResumeLayout();
            com = p;
            userControl11.NumComp = $"{NumComp}{p}";

            static string CbTxt( Mission m, int i )
            {
                return m switch {
                    Mission.Zilart      => $"ジラートの幻影 {i}",
                    Mission.Promathia   => $"プロマシアの呪縛 第{i}章",
                    Mission.Ahturhgan   => $"アトルガンの秘宝 {i}",
                    Mission.Altana      => $"アルタナの神兵 {i}",
                    Mission.Adoulin     => $"アドゥリンの魔境 第{i}章",
                    _ => string.Empty,
                };
            }
        }

        private void Button_Click( UserControl1.ButtonEventArgs e )
        {
            if( e.apply is true ) {
                int q = 0;

                foreach( Control c in userControl11.Flp.Controls ) {
                    if( c is CheckBox b ) {
                        sbyte ch = Convert.ToSByte( b.Checked );

                        if( ch != 0 ) {
                            q++;
                        }
                        dat[int.Parse( b.Name.Substring( 3 ) )] = ch;
                    }
                }
                cd.EmiCompleted += q - com;
            }
            Close();
            return;
        }
    }
}
