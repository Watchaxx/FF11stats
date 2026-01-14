using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();

            tableLayoutPanel1.SuspendLayout();
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is ComboBox b ) {
                    if( b.Name is "comboBox9" or "comboBox10" or "comboBox11" or "comboBox12" or "comboBox13" or "comboBox14" ) {
                        b.Items.AddRange( ["ルーキー", "スタッフ", "パートナー", "アドバイザー", "アーティスト", "チーフ", "マイスター", "レジェンド"] );
                    }
                    b.DropDownStyle = ComboBoxStyle.DropDownList;
                    b.Width = 150;
                } else if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                }
            }
            textBox1.Text = cd.Name;
            comboBox1.SelectedIndex = cd.Race;
            comboBox2.SelectedIndex = cd.Face;
            comboBox3.SelectedIndex = cd.Nation;
            numericUpDown1.Value = cd.Rank;
            numericUpDown2.Value = cd.Mastery;
            comboBox5.SelectedIndex = cd.Mentor;
            comboBox6.SelectedIndex = cd.Gladiators;
            comboBox15.SelectedIndex = cd.Mercenary;
            comboBox4.SelectedIndex = cd.Campaign & 0x03;
            comboBox8.SelectedIndex = ( cd.Campaign & 0xFC ) >>> 2;
            comboBox9.SelectedIndex = cd.CoalitionEvaluation & 0x0000_000F;
            comboBox10.SelectedIndex = ( cd.CoalitionEvaluation & 0x0000_00F0 ) >>> 4;
            comboBox11.SelectedIndex = ( cd.CoalitionEvaluation & 0x0000_0F00 ) >>> 8;
            comboBox12.SelectedIndex = ( cd.CoalitionEvaluation & 0x0000_F000 ) >>> 12;
            comboBox13.SelectedIndex = ( cd.CoalitionEvaluation & 0x000F_0000 ) >>> 16;
            comboBox14.SelectedIndex = ( cd.CoalitionEvaluation & 0x00F0_0000 ) >>> 20;
            comboBox7.SelectedIndex = cd.Unity;
            tableLayoutPanel1.ResumeLayout();
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            cd.Name = textBox1.Text;
            cd.Race = comboBox1.SelectedIndex;
            cd.Face = comboBox2.SelectedIndex;
            cd.Nation = comboBox3.SelectedIndex;
            cd.Rank = numericUpDown1.Value;
            cd.Mastery = numericUpDown2.Value;
            cd.Mentor = comboBox5.SelectedIndex;
            cd.Gladiators = comboBox6.SelectedIndex;
            cd.Mercenary = comboBox15.SelectedIndex;
            cd.Campaign = comboBox4.SelectedIndex | comboBox8.SelectedIndex << 2;
            cd.CoalitionEvaluation = comboBox9.SelectedIndex | comboBox10.SelectedIndex << 4 | comboBox11.SelectedIndex << 8 | comboBox12.SelectedIndex << 12 | comboBox13.SelectedIndex << 16 | comboBox14.SelectedIndex << 20;
            cd.Unity = comboBox7.SelectedIndex;
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
            return;
        }

        private void ComboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            pictureBox1.Image = SetFaceImg( comboBox1.SelectedIndex, comboBox2.SelectedIndex );
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

        private void ComboBox4_SelectedIndexChanged( object sender, EventArgs e )
        {
            pictureBox3.Image = comboBox4.SelectedIndex switch {
                0 => null,
                1 => Resource1.snd,
                2 => Resource1.bas,
                3 => Resource1.win,
                _ => null
            };
            return;
        }
    }
}
