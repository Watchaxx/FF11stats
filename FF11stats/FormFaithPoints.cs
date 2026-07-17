namespace FF11stats
{
    public partial class FormFaithPoints : Form
    {
        static ToolStripMenuItem Item = new();

        public FormFaithPoints( ToolStripMenuItem item )
        {
            InitializeComponent();

            int tab = 0;
            string[] str = [];
            List<sbyte> lst = [];
            DisplayStrings ds = new();

            Item = item;
            SuspendLayout();
#pragma warning disable IDE0028, IDE0306
            switch( Item.Name ) {
            case "toolStripMenuItem191":
                str = ds.FaithPtHpMp;
                lst = new( Program.cd.FaithPtHpMp );
                Text += "HP/MP";
                break;
            case "toolStripMenuItem192":
                str = ds.FaithPtStatus;
                lst = new( Program.cd.FaithPtStatus );
                Text += "ステータス";
                break;
            case "toolStripMenuItem193":
                str = ds.FaithPtSkill;
                lst = new( Program.cd.FaithPtSkill );
                Text += "スキル";
                break;
            }
#pragma warning restore
            tableLayoutPanel1.RowCount = str.Length;
            foreach( int i in Enumerable.Range( 0, str.Length ) ) {
                tableLayoutPanel1.Controls.Add( new Label() {
                    Anchor = AnchorStyles.Left,
                    AutoSize = true,
                    Location = new( 30, 30 ),
                    TabIndex = tab++,
                    Text = str[i]
                }, 0, i );
                tableLayoutPanel1.Controls.Add( new NumericUpDown() {
                    Location = new( 30, 30 ),
                    Maximum = 50,
                    Minimum = 0,
                    Name = $"n{i}",
                    Size = new( 60, 23 ),
                    TabIndex = tab++,
                    Value = lst[i]
                }, 1, i );
                tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.AutoSize ) );
            }
            tableLayoutPanel1.Height = 30 * str.Length;
            ResumeLayout();
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
                    n.Value = n.Minimum;
                }
            }
            return;
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            switch( Item.Name ) {
            case "toolStripMenuItem191":
                foreach( Control c in tableLayoutPanel1.Controls ) {
                    if( c is NumericUpDown n ) {
                        Program.cd.FaithPtHpMp[int.Parse( n.Name[1..] )] = (sbyte)n.Value;
                    }
                }
                break;
            case "toolStripMenuItem192":
                foreach( Control c in tableLayoutPanel1.Controls ) {
                    if( c is NumericUpDown n ) {
                        Program.cd.FaithPtStatus[int.Parse( n.Name[1..] )] = (sbyte)n.Value;
                    }
                }
                break;
            case "toolStripMenuItem193":
                foreach( Control c in tableLayoutPanel1.Controls ) {
                    if( c is NumericUpDown n ) {
                        Program.cd.FaithPtSkill[int.Parse( n.Name[1..] )] = (sbyte)n.Value;
                    }
                }
                break;
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
