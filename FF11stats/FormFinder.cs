namespace FF11stats
{
    public partial class FormFinder : Form
    {
        static Control.ControlCollection? cc = null;

        public FormFinder()
        {
            Init();
        }

        public FormFinder( Control.ControlCollection c )
        {
            cc = c;
            Init();
        }

        private void Init()
        {
            InitializeComponent();

            foreach( Control c in Controls ) {
                helpProvider1.SetHelpString( c, "項目選択後にスペースキーを押すと，チェック状態を変えられます。" );
            }
            helpProvider1.SetShowHelp( contextMenuStrip1, false );
            return;
        }

        private void MenuClick( object? sender, EventArgs e )
        {
            if( sender == null ) {
                return;
            }

            ToolStripItem i = (ToolStripItem)sender;

            Program.sea = i.Text!;
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            if( Owner is null || string.IsNullOrWhiteSpace( textBox1.Text ) is true ) {
                return;
            }

            List<ToolStripMenuItem> tsi = new();

            foreach( Control c in cc is null ? Owner.Controls : cc ) {
                if( c is FlowLayoutPanel or TableLayoutPanel ) {
                    foreach( Control c2 in c.Controls ) {
                        if( c2 is CheckBox cb ) {
                            if( cb.Text.Contains( textBox1.Text, StringComparison.OrdinalIgnoreCase ) is true ) {
                                tsi.Add( new( cb.Text, null, MenuClick ) );
                            }
                        }
                    }
                    break;
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

        private void Button2_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
            return;
        }
    }
}
