using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMeritWS : Form
    {
        public FormMeritWS()
        {
            InitializeComponent();

            byte[] b = MeripoLoad( cd.MeritWS );

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                }
            }
            numericUpDown1.Value = b[0];
            numericUpDown2.Value = b[1];
            numericUpDown3.Value = b[2];
            numericUpDown4.Value = b[3];
            numericUpDown5.Value = b[4];
            numericUpDown6.Value = b[5];
            numericUpDown7.Value = b[6];
            numericUpDown8.Value = b[7];
            numericUpDown9.Value = b[8];
            numericUpDown10.Value = b[9];
            numericUpDown11.Value = b[10];
            numericUpDown12.Value = b[11];
            numericUpDown13.Value = b[12];
            numericUpDown14.Value = b[13];
        }

        static byte cap = 25;
        static decimal s = 0;

        private void Button1_Click( object sender, EventArgs e )
        {
            if( cap < s ) {
                MeripoErr( cap );
                return;
            }
            cd.MeritWS = MeripoSave64( numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value,
                                        numericUpDown6.Value, numericUpDown7.Value, numericUpDown8.Value, numericUpDown9.Value, numericUpDown10.Value,
                                        numericUpDown11.Value, numericUpDown12.Value, numericUpDown13.Value, numericUpDown14.Value );
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
            decimal v = 0;

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is NumericUpDown n ) {
                    v += n.Value;
                }
            }
            s = v;
            label2.ForeColor = cap < v ? Color.Red : Color.FromKnownColor( KnownColor.ControlText );
            label2.Text = $"{v}/{cap}";
            return;
        }
    }
}
