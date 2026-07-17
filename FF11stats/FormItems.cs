using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormItems : Form
    {
        List<CheckBox> Lcb = new();

        internal FormItems( ItemKind kind )
        {
            InitializeComponent();

            const string mogSlip = "モグの預り帳";
            Dictionary<ushort, string> rd;
            DisplayStrings ds = new();

            switch( kind ) {
            case ItemKind.MogSlip01:
                rd = ds.StorageSlip01;
                Text = $"{mogSlip}【01】";
                break;
            case ItemKind.MogSlip02:
                rd = ds.StorageSlip02;
                Text = $"{mogSlip}【02】";
                break;
            case ItemKind.MogSlip03:
                rd = ds.StorageSlip03;
                Text = $"{mogSlip}【03】";
                break;
            case ItemKind.MogSlip04:
                rd = ds.StorageSlip04;
                Text = $"{mogSlip}【04】";
                break;
            case ItemKind.MogSlip05:
                rd = ds.StorageSlip05;
                Text = $"{mogSlip}【05】";
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

        private void MenuClick( object? sender, EventArgs e )
        {
            if( sender is ToolStripMenuItem ts && ts.Tag is CheckBox cb ) {
                cb.Select();
            }
            return;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            flowLayoutPanel1.SuspendLayout();
            foreach( CheckBox c in Lcb ) {
                c.Checked = true;
            }
            flowLayoutPanel1.ResumeLayout();
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            flowLayoutPanel1.SuspendLayout();
            foreach( CheckBox c in Lcb ) {
                c.Checked = false;
            }
            flowLayoutPanel1.ResumeLayout();
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
            foreach( CheckBox c in Lcb ) {
                if( c.Tag is ushort id ) {
                    if( c.Checked is true ) {
                        cd.SItems.Add( id );
                    } else {
                        cd.SItems.Remove( id );
                    }
                }
            }
            Close();
            return;
        }

        private void Button5_Click( object sender, EventArgs e )
        {
            Close();
            return;
        }
    }
}
