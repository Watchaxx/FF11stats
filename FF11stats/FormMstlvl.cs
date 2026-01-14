using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMstlvl : Form
    {
        public FormMstlvl()
        {
            InitializeComponent();

            const ulong cap = 0b10100_10100_10100_10100_10100_10100_10100_10100_10100_10100;

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                } else if( c is NumericUpDown n ) {
                    n.Maximum = MaxMstlvl;
                }
            }
            if( cd.JobpoWar is cap ) {
                numericUpDown1.Value = cd.MstlvlWar;
            } else {
                Not( numericUpDown1 );
            }
            if( cd.JobpoMnk is cap ) {
                numericUpDown2.Value = cd.MstlvlMnk;
            } else {
                Not( numericUpDown2 );
            }
            if( cd.JobpoWhm is cap ) {
                numericUpDown3.Value = cd.MstlvlWhm;
            } else {
                Not( numericUpDown3 );
            }
            if( cd.JobpoBlm is cap ) {
                numericUpDown4.Value = cd.MstlvlBlm;
            } else {
                Not( numericUpDown4 );
            }
            if( cd.JobpoRdm is cap ) {
                numericUpDown5.Value = cd.MstlvlRdm;
            } else {
                Not( numericUpDown5 );
            }
            if( cd.JobpoThf is cap ) {
                numericUpDown6.Value = cd.MstlvlThf;
            } else {
                Not( numericUpDown6 );
            }
            if( cd.JobpoPld is cap ) {
                numericUpDown7.Value = cd.MstlvlPld;
            } else {
                Not( numericUpDown7 );
            }
            if( cd.JobpoDrk is cap ) {
                numericUpDown8.Value = cd.MstlvlDrk;
            } else {
                Not( numericUpDown8 );
            }
            if( cd.JobpoBst is cap ) {
                numericUpDown9.Value = cd.MstlvlBst;
            } else {
                Not( numericUpDown9 );
            }
            if( cd.JobpoBrd is cap ) {
                numericUpDown10.Value = cd.MstlvlBrd;
            } else {
                Not( numericUpDown10 );
            }
            if( cd.JobpoRng is cap ) {
                numericUpDown11.Value = cd.MstlvlRng;
            } else {
                Not( numericUpDown11 );
            }
            if( cd.JobpoSam is cap ) {
                numericUpDown12.Value = cd.MstlvlSam;
            } else {
                Not( numericUpDown12 );
            }
            if( cd.JobpoNin is cap ) {
                numericUpDown13.Value = cd.MstlvlNin;
            } else {
                Not( numericUpDown13 );
            }
            if( cd.JobpoDrg is cap ) {
                numericUpDown14.Value = cd.MstlvlDrg;
            } else {
                Not( numericUpDown14 );
            }
            if( cd.JobpoSmn is cap ) {
                numericUpDown15.Value = cd.MstlvlSmn;
            } else {
                Not( numericUpDown15 );
            }
            if( cd.JobpoBlu is cap ) {
                numericUpDown16.Value = cd.MstlvlBlu;
            } else {
                Not( numericUpDown16 );
            }
            if( cd.JobpoCor is cap ) {
                numericUpDown17.Value = cd.MstlvlCor;
            } else {
                Not( numericUpDown17 );
            }
            if( cd.JobpoPup is cap ) {
                numericUpDown18.Value = cd.MstlvlPup;
            } else {
                Not( numericUpDown18 );
            }
            if( cd.JobpoDnc is cap ) {
                numericUpDown19.Value = cd.MstlvlDnc;
            } else {
                Not( numericUpDown19 );
            }
            if( cd.JobpoSch is cap ) {
                numericUpDown20.Value = cd.MstlvlSch;
            } else {
                Not( numericUpDown20 );
            }
            if( cd.JobpoGeo is cap ) {
                numericUpDown21.Value = cd.MstlvlGeo;
            } else {
                Not( numericUpDown21 );
            }
            if( cd.JobpoRun is cap ) {
                numericUpDown22.Value = cd.MstlvlRun;
            } else {
                Not( numericUpDown22 );
            }

            static void Not( NumericUpDown n )
            {
                n.Value = 0;
                n.Enabled = false;
                return;
            }
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is NumericUpDown n ) {
                    n.Value = MaxMstlvl;
                }
            }
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is NumericUpDown n ) {
                    n.Value = 0;
                }
            }
            return;
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            cd.MstlvlWar = (byte)numericUpDown1.Value;
            cd.MstlvlMnk = (byte)numericUpDown2.Value;
            cd.MstlvlWhm = (byte)numericUpDown3.Value;
            cd.MstlvlBlm = (byte)numericUpDown4.Value;
            cd.MstlvlRdm = (byte)numericUpDown5.Value;
            cd.MstlvlThf = (byte)numericUpDown6.Value;
            cd.MstlvlPld = (byte)numericUpDown7.Value;
            cd.MstlvlDrk = (byte)numericUpDown8.Value;
            cd.MstlvlBst = (byte)numericUpDown9.Value;
            cd.MstlvlBrd = (byte)numericUpDown10.Value;
            cd.MstlvlRng = (byte)numericUpDown11.Value;
            cd.MstlvlSam = (byte)numericUpDown12.Value;
            cd.MstlvlNin = (byte)numericUpDown13.Value;
            cd.MstlvlDrg = (byte)numericUpDown14.Value;
            cd.MstlvlSmn = (byte)numericUpDown15.Value;
            cd.MstlvlBlu = (byte)numericUpDown16.Value;
            cd.MstlvlCor = (byte)numericUpDown17.Value;
            cd.MstlvlPup = (byte)numericUpDown18.Value;
            cd.MstlvlDnc = (byte)numericUpDown19.Value;
            cd.MstlvlSch = (byte)numericUpDown20.Value;
            cd.MstlvlGeo = (byte)numericUpDown21.Value;
            cd.MstlvlRun = (byte)numericUpDown22.Value;
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
