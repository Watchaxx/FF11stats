using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormPhantomRoll : Form
    {
        public FormPhantomRoll()
        {
            InitializeComponent();

            int l = 0;

            flowLayoutPanel1.SuspendLayout();
            foreach( Control c in flowLayoutPanel1.Controls ) {
                if( c is CheckBox b ) {
                    if( cd.PhantomRoll[int.Parse( b.Name.Substring( 8 ) ) - 1] != 0 ) {
                        l++;
                        b.Checked = true;
                    }
                    b.Margin = new( 3 ) { Bottom = 2 };
                }
            }
            flowLayoutPanel1.ResumeLayout();
            label1.Text = $"{NumLearn}{l}";
        }

        private void Apply()
        {
            foreach( Control c in flowLayoutPanel1.Controls ) {
                if( c is CheckBox b ) {
                    cd.PhantomRoll[int.Parse( b.Name.Substring( 8 ) ) - 1] = Convert.ToSByte( b.Checked );
                }
            }
            return;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            Apply();
            Close();
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            Close();
            return;
        }

        private void ToolStripMenuItem4_Click( object sender, EventArgs e )
        {
            switch( MessageBox.Show( "変更を適用しますか？", "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3 ) ) {
            case DialogResult.Yes:
                Apply();
                break;
            case DialogResult.Cancel:
                return;
            }
            Close();
            return;
        }

        private void ToolStripMenuItem5_Click( object sender, EventArgs e )
        {
            using FormFinder f = new();

            if( f.ShowDialog( this ) is DialogResult.OK ) {
                foreach( Control c in flowLayoutPanel1.Controls ) {
                    if( StrComp( c.Text, sea ) is true ) {
                        c.Select();
                        break;
                    }
                }
            }
            sea = string.Empty;
            return;
        }

        private void ToolStripMenuItem6_Click( object sender, EventArgs e )
        {
            foreach( Control c in flowLayoutPanel1.Controls ) {
                if( c is CheckBox b ) {
                    b.Checked = true;
                }
            }
            return;
        }

        private void ToolStripMenuItem7_Click( object sender, EventArgs e )
        {
            foreach( Control c in flowLayoutPanel1.Controls ) {
                if( c is CheckBox b ) {
                    b.Checked = false;
                }
            }
            return;
        }

        private void ToolStripMenuItem8_Click( object sender, EventArgs e )
        {
            flowLayoutPanel1.SuspendLayout();
            foreach( Control c in flowLayoutPanel1.Controls ) {
                if( c is CheckBox b ) {
                    if( toolStripMenuItem8.Checked is true ) {
                        if( b.Checked is true ) {
                            b.Visible = false;
                        }
                    } else if( toolStripMenuItem8.Checked is false ) {
                        b.Visible = true;
                    }
                }
            }
            flowLayoutPanel1.ResumeLayout();
            return;
        }
    }
}
