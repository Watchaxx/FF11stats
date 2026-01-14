using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMoveSGHP : Form
    {
#pragma warning disable CS8618
#pragma warning disable IDE0306
        static short[] dat;
        static string MenuName;

        public FormMoveSGHP( ToolStripMenuItem menu )
        {
            InitializeComponent();

            int icb = 0;
            int p = 0;
            string sumi = "開通済：";
            List<string> dispStr = new();
            List<Control> ctrl = new();
            DisplayStrings ds = new();

            MenuName = menu.Name!;
            AcceptButton = userControl11.ButtonAccept;
            CancelButton = userControl11.ButtonCancel;
            Text = $"移動/{menu.Text![..^4]}";
            userControl11.ButtonClick += Button_Click;
            userControl11.Flp.SuspendLayout();
            switch( MenuName ) {
            case "toolStripMenuItem167":
                dat = new short[cd.MovOutpost.Length];
                Array.ConstrainedCopy( cd.MovOutpost, 0, dat, 0, cd.MovOutpost.Length );
                dispStr = new( ds.MovOutpost );
                break;
            case "toolStripMenuItem168":
                dat = new short[cd.MovRunicPortal.Length];
                Array.ConstrainedCopy( cd.MovRunicPortal, 0, dat, 0, cd.MovRunicPortal.Length );
                dispStr = new( ds.MovRunicPortal );
                break;
            case "toolStripMenuItem169":
                dat = new short[cd.MovSurvivalGuide.Length];
                Array.ConstrainedCopy( cd.MovSurvivalGuide, 0, dat, 0, cd.MovSurvivalGuide.Length );
                dispStr = new( ds.MovSurvivalGuide );
                Text = $"移動/{menu.Text![1..]}";
                break;
            case "toolStripMenuItem170":
                dat = new short[cd.MovHomePoint.Length];
                Array.ConstrainedCopy( cd.MovHomePoint, 0, dat, 0, cd.MovHomePoint.Length );
                dispStr = new( ds.MovHomePoint );
                Text = $"移動/{menu.Text![1..]}";
                break;
            case "toolStripMenuItem171":
                dat = new short[cd.MovMount.Length];
                Array.ConstrainedCopy( cd.MovMount, 0, dat, 0, cd.MovMount.Length );
                dispStr = new( ds.MovMount );
                sumi = "入手済：";
                break;
            }
            foreach( int i in Enumerable.Range( 0, dispStr.Count ) ) {
                if( dispStr[i][0] is 'l' ) {
                    Label l = new() {
                        AutoSize = true,
                        Size = new Size( 31, 15 ),
                        TabIndex = i,
                        Text = dispStr[i][1..]
                    };

                    ctrl.Add( l );
                } else {
                    CheckBox cb = new() {
                        AutoSize = true,
                        Name = $"obj{icb:00}",
                        Size = new( 1, 19 ),
                        TabIndex = i,
                        Text = dispStr[i],
                        UseVisualStyleBackColor = true
                    };

                    if( icb < dat.Length && dat[icb] != 0 ) {
                        p++;
                        cb.Checked = true;
                    } else {
                        Array.Resize( ref dat, dat.Length + 1 );
                    }
                    icb++;
                    ctrl.Add( cb );
                }
            }
            userControl11.Flp.Controls.AddRange( ctrl.ToArray() );
            userControl11.Flp.ResumeLayout();
            userControl11.NumComp = $"{sumi}{p}";
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
                        dat[int.Parse( b.Name.Substring( 3 ) )] = ch;
                    }
                }
                switch( MenuName ) {
                case "toolStripMenuItem167":
                    Array.ConstrainedCopy( dat, 0, cd.MovOutpost, 0, dat.Length );
                    break;
                case "toolStripMenuItem168":
                    Array.ConstrainedCopy( dat, 0, cd.MovRunicPortal, 0, dat.Length );
                    break;
                case "toolStripMenuItem169":
                    Array.ConstrainedCopy( dat, 0, cd.MovSurvivalGuide, 0, dat.Length );
                    break;
                case "toolStripMenuItem170":
                    Array.ConstrainedCopy( dat, 0, cd.MovHomePoint, 0, dat.Length );
                    break;
                case "toolStripMenuItem171":
                    if( cd.MovMount.Length != dat.Length ) {
                        cd.MovMount = new short[dat.Length];
                    }
                    Array.ConstrainedCopy( dat, 0, cd.MovMount, 0, dat.Length );
                    break;
                }
            }
            Close();
            return;
        }
    }
}
