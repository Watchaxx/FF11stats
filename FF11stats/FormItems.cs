using static FF11stats.Program;

namespace FF11Stats
{
    public partial class FormItems : Form
    {
        List<CheckBox> Lcb = new();

        internal FormItems( ItemKind kind )
        {
            InitializeComponent();

            const string mogSlip = "モグの預り帳";
            Dictionary<ushort, string> rd;
            FF11stats.DisplayStrings ds = new();

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
            default:
                throw new InvalidOperationException( "フォームの初期化エラー" );
            }
            foreach( (KeyValuePair<ushort, string>, int) t in rd.Select( ( val, idx ) => (val, idx) ) ) {
                Lcb.Add( new() {
                    AutoSize = true,
                    Checked = cd.SItems.Contains( t.Item1.Key ),
                    Name = $"c{t.Item1.Key}",
                    Size = new( 1, 19 ),
                    TabIndex = t.Item2,
                    Text = t.Item1.Value,
                    UseVisualStyleBackColor = true
                } );
            }
            flowLayoutPanel1.Controls.AddRange( Lcb.ToArray() );
        }

        private void MenuClick( object? sender, EventArgs e )
        {
            ToolStripItem i = (ToolStripItem)sender!;

            foreach( CheckBox c in Lcb ) {
                if( StrComp( c.Text, i.Text! ) is true ) {
                    c.Select();
                    break;
                }
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
                    tsi.Add( new( c.Text, null, MenuClick ) );
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
                if( c.Checked is true ) {
                    cd.SItems.Add( ushort.Parse( c.Name[1..] ) );
                } else {
                    cd.SItems.Remove( ushort.Parse( c.Name[1..] ) );
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
