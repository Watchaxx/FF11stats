using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMeritSch : Form
    {
        public FormMeritSch()
        {
            InitializeComponent();

            byte[] b = MeripoLoad( cd.MeritSch1 );

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                }
            }
            numericUpDown1.Value = b[0];
            numericUpDown2.Value = b[1];
            numericUpDown3.Value = b[2];
            numericUpDown4.Value = b[3];
            b = MeripoLoad( cd.MeritSch2 );
            numericUpDown5.Value = b[0];
            numericUpDown6.Value = b[1];
            numericUpDown7.Value = b[2];
            numericUpDown8.Value = b[3];
            numericUpDown9.Value = b[4];
            numericUpDown10.Value = b[5];
        }

        static decimal s1 = 0;
        static decimal s2 = 0;

        private void Button1_Click( object sender, EventArgs e )
        {
            if( MaxMeripo < s1 || MaxMeripo < s2 ) {
                MeripoErr( MaxMeripo );
                return;
            }
            cd.MeritSch1 = MeripoSave32( numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value );
            cd.MeritSch2 = MeripoSave32( numericUpDown5.Value, numericUpDown6.Value, numericUpDown7.Value, numericUpDown8.Value, numericUpDown9.Value, numericUpDown10.Value );
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
            decimal v = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value;

            s1 = v;
            label2.ForeColor = MaxMeripo < v ? Color.Red : Color.FromKnownColor( KnownColor.ControlText );
            label2.Text = $"{v}/{MaxMeripo}";
            return;
        }

        private void NumericUpDown5_ValueChanged( object sender, EventArgs e )
        {
            decimal v = numericUpDown5.Value + numericUpDown6.Value + numericUpDown7.Value + numericUpDown8.Value + numericUpDown9.Value + numericUpDown10.Value;

            s2 = v;
            label8.ForeColor = MaxMeripo < v ? Color.Red : Color.FromKnownColor( KnownColor.ControlText );
            label8.Text = $"{v}/{MaxMeripo}";
            return;
        }
    }
}
