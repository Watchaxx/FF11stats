using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMeritOthers : Form
    {
        public FormMeritOthers()
        {
            InitializeComponent();

            byte[] b = MeripoLoad( cd.MeritOthers );

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
        }

        static decimal s = 0;

        private void Button1_Click( object sender, EventArgs e )
        {
            if( MaxMeripo < s ) {
                MeripoErr( MaxMeripo );
                return;
            }
            cd.MeritOthers = MeripoSave32( numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value );
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
            label2.ForeColor = MaxMeripo < v ? Color.Red : Color.FromKnownColor( KnownColor.ControlText );
            label2.Text = $"{v}/{MaxMeripo}";
            return;
        }
    }
}
