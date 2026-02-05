using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormEmiTutorialSandoria : Form
    {
#pragma warning disable CS8618
        static sbyte[] dat;
        static int com = 0;

        internal FormEmiTutorialSandoria( Mission mission )
        {
            InitializeComponent();

            int i = 0;
            int p = 0;
            int[] n = [3, 3, 3, 1, 2, 2, 2, 2, 2];
            string s = string.Empty;
            CheckBox[] cb = new CheckBox[20];

            switch( mission ) {
            case Mission.Sandoria:
                s = "サンドリア";
                dat = cd.EmiTutorialSandoria;
                break;
            case Mission.Bastok:
                s = "バストゥーク";
                dat = cd.EmiTutorialBastok;
                break;
            case Mission.Windurst:
                s = "ウィンダス";
                dat = cd.EmiTutorialWindurst;
                break;
            }
            AcceptButton = userControl11.ButtonAccept;
            CancelButton = userControl11.ButtonCancel;
            Text = $"目標/チュートリアル/ミッション({s})";
            userControl11.ButtonClick += Button_Click;
            userControl11.Flp.SuspendLayout();
            foreach( int j in Enumerable.Range( 1, 9 ) ) {
                foreach( int k in Enumerable.Range( 1, n[j - 1] ) ) {
                    CheckBox c = new() {
                        AutoSize = true,
                        Name = $"obj{i:00}",
                        Size = new Size( 1, 19 ),
                        TabIndex = i,
                        Text = n[j - 1] is 1 ? $"{s}Rank{j}" : $"{s}Rank{j}-{k}",
                        UseVisualStyleBackColor = true
                    };

                    if( dat[int.Parse( c.Name.Substring( 3 ) )] != 0 ) {
                        p++;
                        c.Checked = true;
                    }
                    cb[i] = c;
                    i++;
                }
            }
            userControl11.Flp.Controls.AddRange( cb );
            userControl11.Flp.ResumeLayout();
            com = p;
            userControl11.NumComp = $"{NumComp}{p}";
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
