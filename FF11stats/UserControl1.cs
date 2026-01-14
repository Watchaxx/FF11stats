using System.ComponentModel;
using static FF11stats.Program;

namespace FF11stats
{
    public partial class UserControl1 : UserControl
    {
        [DesignerSerializationVisibility( DesignerSerializationVisibility.Visible )]
        public string NumComp { set { label1.Text = value; } }
        public Button ButtonAccept { get; }
        public Button ButtonCancel { get; }
        [DesignerSerializationVisibility( DesignerSerializationVisibility.Visible )]
        public FlowLayoutPanel Flp { get; set; }

        public delegate void ButtonClickEventHandler( ButtonEventArgs e );
        public event ButtonClickEventHandler ButtonClick;

        public class ButtonEventArgs : EventArgs
        {
            public bool apply = false;
        }

#pragma warning disable CS8618
        public UserControl1()
        {
            InitializeComponent();

            ButtonAccept = button1;
            ButtonCancel = button2;
            Dock = DockStyle.Fill;
            Flp = flowLayoutPanel1;
        }
#pragma  warning restore

        private void Button1_Click( object sender, EventArgs e )
        {
            ButtonClick( new ButtonEventArgs { apply = true } );
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            ButtonClick( new ButtonEventArgs { apply = false } );
            return;
        }

        private void ToolStripMenuItem4_Click( object sender, EventArgs e )
        {
            switch( MessageBox.Show( "変更を適用しますか？", "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3 ) ) {
            case DialogResult.Yes:
                ButtonClick( new ButtonEventArgs { apply = true } );
                break;
            case DialogResult.No:
                ButtonClick( new ButtonEventArgs { apply = false } );
                break;
            }
            return;
        }

        private void ToolStripMenuItem5_Click( object sender, EventArgs e )
        {
            using FormFinder f = new( Controls );

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
