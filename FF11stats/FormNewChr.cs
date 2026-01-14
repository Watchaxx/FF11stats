namespace FF11stats
{
    public partial class FormNewChr : Form
    {
        public FormNewChr()
        {
            InitializeComponent();

            foreach( Control c in Controls ) {
                if( c is ComboBox b ) {
                    b.DropDownStyle = ComboBoxStyle.DropDownList;
                    b.SelectedIndex = 0;
                }
            }
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            if( string.IsNullOrWhiteSpace( textBox1.Text ) is true ) {
                errorProvider1.SetError( textBox1, "名前を入力してください。" );
                textBox1.Select();
                textBox1.SelectAll();
                return;
            }
            Program.cd = new() {
                Name = textBox1.Text,
                Race = comboBox1.SelectedIndex,
                Face = comboBox2.SelectedIndex,
                Nation = comboBox3.SelectedIndex
            };
            Program.edit = string.Empty;
            Program.showMain = true;
            DialogResult = DialogResult.OK;
            errorProvider1.Clear();
            Close();
            return;
        }

        private void ComboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            pictureBox1.Image = Program.SetFaceImg( comboBox1.SelectedIndex, comboBox2.SelectedIndex );
            return;
        }

        private void ComboBox3_SelectedIndexChanged( object sender, EventArgs e )
        {
            pictureBox2.Image = comboBox3.SelectedIndex switch {
                0 => Resource1.snd,
                1 => Resource1.bas,
                2 => Resource1.win,
                _ => Resource1.snd
            };
            return;
        }
    }
}
