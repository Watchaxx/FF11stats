using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMeritSmn : Form
    {
        public FormMeritSmn()
        {
            InitializeComponent();

            byte[] b = MeripoLoad( cd.MeritSmn1 );

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
            b = MeripoLoad( cd.MeritSmn2 );
            numericUpDown6.Value = b[0];
            numericUpDown7.Value = b[1];
            numericUpDown8.Value = b[2];
            numericUpDown9.Value = b[3];
            numericUpDown10.Value = b[4];
            numericUpDown11.Value = b[5];
        }

        static decimal s1 = 0;
        static decimal s2 = 0;

        private void Button1_Click( object sender, EventArgs e )
        {
            if( MaxMeripo < s1 || MaxMeripo < s2 ) {
                MeripoErr( MaxMeripo );
                return;
            }
            cd.MeritSmn1 = MeripoSave32( numericUpDown11.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value );
            cd.MeritSmn2 = MeripoSave32( numericUpDown6.Value, numericUpDown7.Value, numericUpDown8.Value, numericUpDown9.Value, numericUpDown10.Value, numericUpDown11.Value );
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
            decimal v = numericUpDown6.Value + numericUpDown7.Value + numericUpDown8.Value + numericUpDown9.Value + numericUpDown10.Value + numericUpDown11.Value;

            s2 = v;
            label9.ForeColor = MaxMeripo < v ? Color.Red : Color.FromKnownColor( KnownColor.ControlText );
            label9.Text = $"{v}/{MaxMeripo}";
            return;
        }
    }
}
