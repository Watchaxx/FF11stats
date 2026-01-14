using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMeritHpmp : Form
    {
        public FormMeritHpmp()
        {
            InitializeComponent();

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                }
            }
            numericUpDown1.Value =   cd.MeritHpmp & 0x000F;
            numericUpDown2.Value = ( cd.MeritHpmp & 0x00F0 ) >>> 4;
            numericUpDown3.Value = ( cd.MeritHpmp & 0xFF00 ) >>> 8;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is NumericUpDown n ) {
                    n.Value = n.Maximum;
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
            cd.MeritHpmp = ( (uint)numericUpDown3.Value << 8 ) | ( (uint)numericUpDown2.Value << 4 ) | (uint)numericUpDown1.Value;
            Close();
            return;
        }

        private void Button4_Click( object sender, EventArgs e )
        {
            Close();
            return;
        }

        private void NumericUpDown1_ValueChanged( object sender, EventArgs e )
        {
            decimal v = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value;

            label2.Text = $"{v}/75";
            return;
        }
    }
}
