using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormEmiTutorialRhapsodies : Form
    {
        static int com = 0;

        public FormEmiTutorialRhapsodies()
        {
            InitializeComponent();

            const string rov = "ヴァナ・ディールの星唄";
            int idx = 0;
            int p = 0;
            int[] n = { 3, 9, 12 };
            CheckBox[] cb = new CheckBox[n.Sum()];

            AcceptButton = userControl11.ButtonAccept;
            CancelButton = userControl11.ButtonCancel;
            userControl11.ButtonClick += Button_Click;
            userControl11.Flp.SuspendLayout();
            foreach( int i in Enumerable.Range( 1, n.Length ) ) {
                foreach( int j in Enumerable.Range( 1, n[i - 1] ) ) {
                    CheckBox c = new() {
                        AutoSize = true,
                        Name = $"obj{idx:00}",
                        Size = new Size( 1, 19 ),
                        TabIndex = idx,
                        Text = $"{rov} 第{i}章 {j}",
                        UseVisualStyleBackColor = true
                    };

                    if( cd.EmiTutorialRhapsodies[int.Parse( c.Name.Substring( 3 ) )] != 0 ) {
                        p++;
                        c.Checked = true;
                    }
                    cb[idx] = c;
                    idx++;
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
                        short ch = Convert.ToInt16( b.Checked );

                        if( ch != 0 ) {
                            q++;
                        }
                        cd.EmiTutorialRhapsodies[int.Parse( b.Name.Substring( 3 ) )] = ch;
                    }
                }
                cd.EmiCompleted += q - com;
            }
            Close();
            return;
        }
    }
}
