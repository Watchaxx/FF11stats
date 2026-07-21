using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormItems : Form
    {
        List<CheckBox> Lcb = new();

        internal FormItems( string kind )
        {
            InitializeComponent();

            const string mogSlip = "モグの預り帳";
            DisplayStrings ds = new();
            System.Collections.ObjectModel.ReadOnlyDictionary<ushort, string> rd;

            switch( kind ) {
            case "toolStripMenuItem198":
                rd = new( ds.StorageSlip01 );
                Text = $"{mogSlip}【01】";
                break;
            case "toolStripMenuItem199":
                rd = new( ds.StorageSlip02 );
                Text = $"{mogSlip}【02】";
                break;
            case "toolStripMenuItem200":
                rd = new( ds.StorageSlip03 );
                Text = $"{mogSlip}【03】";
                break;
            case "toolStripMenuItem201":
                rd = new( ds.StorageSlip04 );
                Text = $"{mogSlip}【04】";
                break;
            case "toolStripMenuItem202":
                rd = new( ds.StorageSlip05 );
                Text = $"{mogSlip}【05】";
                textBox1.ImeMode = ImeMode.Off;
                break;
            case "toolStripMenuItem203":
                rd = new( ds.StorageSlip06 );
                Text = $"{mogSlip}【06】";
                break;
            case "toolStripMenuItem204":
                rd = new( ds.StorageSlip07 );
                Text = $"{mogSlip}【07】";
                textBox1.ImeMode = ImeMode.Off;
                break;
            case "toolStripMenuItem205":
                rd = new( ds.StorageSlip08 );
                Text = $"{mogSlip}【08】";
                break;
            case "toolStripMenuItem206":
                rd = new( ds.StorageSlip09 );
                Text = $"{mogSlip}【09】";
                textBox1.ImeMode = ImeMode.Off;
                break;
            case "toolStripMenuItem207":
                rd = new( ds.StorageSlip10 );
                Text = $"{mogSlip}【10】";
                textBox1.ImeMode = ImeMode.Off;
                break;
            default:
                throw new InvalidOperationException( "フォームの初期化エラー" );
            }
            flowLayoutPanel1.SuspendLayout();
            foreach( var (kvp, idx) in rd.Select( ( val, idx ) => (val, idx) ) ) {
                Lcb.Add( new() {
                    AutoSize = true,
                    Checked = cd.SItems.Contains( kvp.Key ),
                    Name = $"cb{kvp.Key}",
                    Size = new( 1, 19 ),
                    TabIndex = idx,
                    Tag = kvp.Key,
                    Text = kvp.Value,
                    UseVisualStyleBackColor = true
                } );
            }
            flowLayoutPanel1.Controls.AddRange( Lcb.ToArray() );
            flowLayoutPanel1.ResumeLayout();
        }

        private void AllCheck()
        {
            flowLayoutPanel1.SuspendLayout();
            foreach( CheckBox c in Lcb ) {
                c.Checked = true;
            }
            flowLayoutPanel1.ResumeLayout();
            return;
        }

        private void AllUncheck()
        {
            flowLayoutPanel1.SuspendLayout();
            foreach( CheckBox c in Lcb ) {
                c.Checked = false;
            }
            flowLayoutPanel1.ResumeLayout();
            return;
        }

        private void ApplyToChrDat()
        {
            foreach( CheckBox c in Lcb ) {
                if( c.Tag is ushort id ) {
                    if( c.Checked is true ) {
                        cd.SItems.Add( id );
                    } else {
                        cd.SItems.Remove( id );
                    }
                }
            }
            return;
        }

        private void MenuClick( object? sender, EventArgs e )
        {
            if( sender is ToolStripMenuItem ts && ts.Tag is CheckBox cb ) {
                cb.Select();
            }
            return;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            AllCheck();
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            AllUncheck();
            return;
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            if( string.IsNullOrWhiteSpace( textBox1.Text ) is true ) {
                return;
            }

            List<ToolStripMenuItem> tsi = new();

            foreach( CheckBox c in Lcb ) {
                if( c.Text.Contains( textBox1.Text, StringComparison.OrdinalIgnoreCase ) is true ) {
                    tsi.Add( new( c.Text, null, MenuClick ) { Tag = c } );
                }
            }
            if( tsi.Count is 0 ) {
                tsi.Add( new( "見つかりません" ) );
            }
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.AddRange( tsi.OrderBy( x => x.Text ).ToArray() );
            textBox1.ContextMenuStrip = contextMenuStrip1;
            textBox1.ContextMenuStrip.Show( textBox1, new Point( 0, textBox1.Height ) );
            return;
        }

        private void Button4_Click( object sender, EventArgs e )
        {
            ApplyToChrDat();
            Close();
            return;
        }

        private void Button5_Click( object sender, EventArgs e )
        {
            Close();
            return;
        }

        private void ToolStripMenuItem4_Click( object sender, EventArgs e )
        {
            DialogResult r = MessageBox.Show( "変更を適用しますか？", "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3 );

            if( r is DialogResult.Cancel ) {
                return;
            } else if( r is DialogResult.Yes ) {
                ApplyToChrDat();
            }
            Close();
            return;
        }

        private void ToolStripMenuItem5_Click( object sender, EventArgs e )
        {
            textBox1.Select();
            textBox1.SelectAll();
            return;
        }

        private void ToolStripMenuItem6_Click( object sender, EventArgs e )
        {
            AllCheck();
            return;
        }

        private void ToolStripMenuItem7_Click( object sender, EventArgs e )
        {
            AllUncheck();
            return;
        }

        private void ToolStripMenuItem8_Click( object sender, EventArgs e )
        {
            flowLayoutPanel1.SuspendLayout();
            switch( toolStripMenuItem8.Checked ) {
            case true:
                foreach( CheckBox c in Lcb ) {
                    if( c.Checked is true ) {
                        c.Visible = false;
                    }
                }
                break;
            case false:
                foreach( CheckBox c in Lcb ) {
                    c.Visible = true;
                }
                break;
            }
            flowLayoutPanel1.ResumeLayout();
            return;
        }
    }
}
