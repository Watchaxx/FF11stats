using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMissionMi : Form
    {
        public FormMissionMi()
        {
            InitializeComponent();

            tableLayoutPanel1.SuspendLayout();
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is ComboBox b ) {
                    b.DropDownStyle = ComboBoxStyle.DropDownList;
                    b.SelectedIndex = cd.Mission[int.Parse( b.Name.Substring( 8 ) ) - 1];
                    b.Width = 201;
                } else if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                }
            }
            tableLayoutPanel1.ResumeLayout();
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is ComboBox b ) {
                    b.SelectedIndex = b.Items.Count - 1;
                }
            }
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            foreach( Control control in tableLayoutPanel1.Controls ) {
                if( control is ComboBox b ) {
                    b.SelectedIndex = 0;
                }
            }
            return;
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is ComboBox b ) {
                    cd.Mission[int.Parse( b.Name.Substring( 8 ) ) - 1] = b.SelectedIndex;
                }
            }
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
