using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormEmiCombatEschaArea : Form
    {
        static int com = 0;

        public FormEmiCombatEschaArea()
        {
            InitializeComponent();

            const string se = "戦闘：";
            int i = 0;
            int p = 0;
            CheckBox[] cb = new CheckBox[28];
            Dictionary<string, int> d = new( 3 );

            d.Add( "エスカ-ジ・タ", 7 );
            d.Add( "エスカ-ル・オン", 10 );
            d.Add( "醴泉島", 11 );
            AcceptButton = userControl11.ButtonAccept;
            CancelButton = userControl11.ButtonCancel;
            userControl11.ButtonClick += Button_Click;
            userControl11.Flp.SuspendLayout();
            foreach( var r in d ) {
                foreach( int j in Enumerable.Range( 1, r.Value ) ) {
                    CheckBox c = new() {
                        AutoSize = true,
                        Name = $"obj{i:00}",
                        Size = new( 1, 19 ),
                        TabIndex = i,
                        Text = $"{se}{r.Key}{j}",
                        UseVisualStyleBackColor = true
                    };

                    if( cd.EmiCombatEschaArea[int.Parse( c.Name.Substring( 3 ) )] != 0 ) {
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
                int p = 0;

                foreach( Control c in userControl11.Flp.Controls ) {
                    if( c is CheckBox b ) {
                        short ch = Convert.ToInt16( b.Checked );

                        if( ch != 0 ) {
                            p++;
                        }
                        cd.EmiCombatEschaArea[int.Parse( b.Name.Substring( 3 ) )] = ch;
                    }
                }
                cd.EmiCompleted += p - com;
            }
            Close();
            return;
        }
    }
}
