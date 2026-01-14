using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormJoblvl : Form
    {
        public FormJoblvl()
        {
            InitializeComponent();

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                } else if( c is NumericUpDown n ) {
                    n.Maximum = MaxJoblvl;
                }
            }
            numericUpDown1.Value = cd.JoblvlWar;
            numericUpDown2.Value = cd.JoblvlMnk;
            numericUpDown3.Value = cd.JoblvlWhm;
            numericUpDown4.Value = cd.JoblvlBlm;
            numericUpDown5.Value = cd.JoblvlRdm;
            numericUpDown6.Value = cd.JoblvlThf;
            numericUpDown7.Value = cd.JoblvlPld;
            numericUpDown8.Value = cd.JoblvlDrk;
            numericUpDown9.Value = cd.JoblvlBst;
            numericUpDown10.Value = cd.JoblvlBrd;
            numericUpDown11.Value = cd.JoblvlRng;
            numericUpDown12.Value = cd.JoblvlSam;
            numericUpDown13.Value = cd.JoblvlNin;
            numericUpDown14.Value = cd.JoblvlDrg;
            numericUpDown15.Value = cd.JoblvlSmn;
            numericUpDown16.Value = cd.JoblvlBlu;
            numericUpDown17.Value = cd.JoblvlCor;
            numericUpDown18.Value = cd.JoblvlPup;
            numericUpDown19.Value = cd.JoblvlDnc;
            numericUpDown20.Value = cd.JoblvlSch;
            numericUpDown21.Value = cd.JoblvlGeo;
            numericUpDown22.Value = cd.JoblvlRun;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is NumericUpDown n ) {
                    n.Value = MaxJoblvl;
                }
            }
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is NumericUpDown n ) {
                    n.Value = n.Minimum;
                }
            }
            return;
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            cd.JoblvlWar = (byte)numericUpDown1.Value;
            cd.JoblvlMnk = (byte)numericUpDown2.Value;
            cd.JoblvlWhm = (byte)numericUpDown3.Value;
            cd.JoblvlBlm = (byte)numericUpDown4.Value;
            cd.JoblvlRdm = (byte)numericUpDown5.Value;
            cd.JoblvlThf = (byte)numericUpDown6.Value;
            cd.JoblvlPld = (byte)numericUpDown7.Value;
            cd.JoblvlDrk = (byte)numericUpDown8.Value;
            cd.JoblvlBst = (byte)numericUpDown9.Value;
            cd.JoblvlBrd = (byte)numericUpDown10.Value;
            cd.JoblvlRng = (byte)numericUpDown11.Value;
            cd.JoblvlSam = (byte)numericUpDown12.Value;
            cd.JoblvlNin = (byte)numericUpDown13.Value;
            cd.JoblvlDrg = (byte)numericUpDown14.Value;
            cd.JoblvlSmn = (byte)numericUpDown15.Value;
            cd.JoblvlBlu = (byte)numericUpDown16.Value;
            cd.JoblvlCor = (byte)numericUpDown17.Value;
            cd.JoblvlPup = (byte)numericUpDown18.Value;
            cd.JoblvlDnc = (byte)numericUpDown19.Value;
            cd.JoblvlSch = (byte)numericUpDown20.Value;
            cd.JoblvlGeo = (byte)numericUpDown21.Value;
            cd.JoblvlRun = (byte)numericUpDown22.Value;
            Close();
            return;
        }

        private void Button4_Click( object sender, EventArgs e )
        {
            Close();
            return;
        }
    }
}
