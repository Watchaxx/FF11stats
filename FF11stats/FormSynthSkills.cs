using static FF11stats.Program;
using Tpl = System.Tuple<System.Drawing.Color, string, string>;

namespace FF11stats
{
    public partial class FormSynthSkills : Form
    {
        public FormSynthSkills()
        {
            InitializeComponent();

            byte[] m = MeripoLoad( cd.RankSynth );
            string[] rank = ["素人", "見習", "徒弟", "下級職人", "名取", "目録", "印可"];

            SuspendLayout();
            comboBox1.BeginUpdate();
            comboBox2.BeginUpdate();
            comboBox3.BeginUpdate();
            comboBox4.BeginUpdate();
            comboBox5.BeginUpdate();
            comboBox6.BeginUpdate();
            comboBox7.BeginUpdate();
            comboBox8.BeginUpdate();
            comboBox9.BeginUpdate();
            comboBox10.BeginUpdate();
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is ComboBox b ) {
                    b.Items.AddRange( rank );
                    b.Items.AddRange( ["高弟", "皆伝", "師範", "高級職人"] );
                } else if( c is Label l ) {
                    l.Anchor = l.Name is "label12" or "label14" or "label16" or "label18" or "label20" or "label22" or "label24" or "label26" or "label28"
                        ? AnchorStyles.Right
                        : AnchorStyles.Left;
                } else if( c is NumericUpDown n ) {
                    n.Maximum = MaxSynthSkill2;
                }
            }
            comboBox10.Items.Clear();
            comboBox10.Items.AddRange( rank );
            comboBox10.Items.Add( "高弟" );
            comboBox1.SelectedIndex = m[0];
            comboBox2.SelectedIndex = m[1];
            comboBox3.SelectedIndex = m[2];
            comboBox4.SelectedIndex = m[3];
            comboBox5.SelectedIndex = m[4];
            comboBox6.SelectedIndex = m[5];
            comboBox7.SelectedIndex = m[6];
            comboBox8.SelectedIndex = m[7];
            comboBox9.SelectedIndex = m[8];
            comboBox10.SelectedIndex = m[9];
            comboBox1.EndUpdate();
            comboBox2.EndUpdate();
            comboBox3.EndUpdate();
            comboBox4.EndUpdate();
            comboBox5.EndUpdate();
            comboBox6.EndUpdate();
            comboBox7.EndUpdate();
            comboBox8.EndUpdate();
            comboBox9.EndUpdate();
            comboBox10.EndUpdate();
            numericUpDown10.Maximum = MaxSynergySkill;
            numericUpDown1.Value = cd.SkillFishing;
            numericUpDown2.Value = cd.SkillWood;
            numericUpDown3.Value = cd.SkillSmithing;
            numericUpDown4.Value = cd.SkillGoldsmithing;
            numericUpDown5.Value = cd.SkillClothcraft;
            numericUpDown6.Value = cd.SkillLeathercraft;
            numericUpDown7.Value = cd.SkillBonecraft;
            numericUpDown8.Value = cd.SkillAlchemy;
            numericUpDown9.Value = cd.SkillCooking;
            numericUpDown10.Value = cd.SkillSynergy;
            ResumeLayout();
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is ComboBox b ) {
                    b.SelectedIndex = 6;
                } else if( c is NumericUpDown n ) {
                    n.Value = MaxSynthSkill1;
                }
            }
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            comboBox10.SelectedIndex = comboBox10.Items.Count - 1;
            numericUpDown1.Value = MaxSynthSkill2;
            numericUpDown10.Value = MaxSynergySkill;
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is ComboBox b ) {
                    b.SelectedIndex = 0;
                } else if( c is NumericUpDown n ) {
                    n.Value = 0;
                }
            }
            return;
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            if( 600m < numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value
                     + numericUpDown6.Value + numericUpDown7.Value + numericUpDown8.Value + numericUpDown9.Value ) {
                MessageBox.Show( "スキル値に誤りがあります。", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }
            cd.RankSynth = MeripoSave64( comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex, comboBox4.SelectedIndex, comboBox5.SelectedIndex,
                                         comboBox6.SelectedIndex, comboBox7.SelectedIndex, comboBox8.SelectedIndex, comboBox9.SelectedIndex, comboBox10.SelectedIndex );
            cd.SkillFishing = numericUpDown1.Value;
            cd.SkillWood = numericUpDown2.Value;
            cd.SkillSmithing = numericUpDown3.Value;
            cd.SkillGoldsmithing = numericUpDown4.Value;
            cd.SkillClothcraft = numericUpDown5.Value;
            cd.SkillLeathercraft = numericUpDown6.Value;
            cd.SkillBonecraft = numericUpDown7.Value;
            cd.SkillAlchemy = numericUpDown8.Value;
            cd.SkillCooking = numericUpDown9.Value;
            cd.SkillSynergy = numericUpDown10.Value;
            Close();
            return;
        }

        private void Button4_Click( object sender, EventArgs e )
        {
            Close();
            return;
        }

        private void Timer1_Tick( object sender, EventArgs e )
        {
            ulong earthSec = (ulong)( DateTime.Now.ToLocalTime() - new DateTimeOffset( 2002, 1, 1, 0, 0, 0, TimeSpan.FromHours( 9d ) ) ).TotalSeconds;
            Tpl fish = Store( earthSec, 3, 18 );
            Tpl wood = Store( earthSec, 6, 21 );
            Tpl smit = Store( earthSec, 8, 23 );
            Tpl gold = Store( earthSec, 8, 23 );
            Tpl clot = Store( earthSec, 6, 21 );
            Tpl leat = Store( earthSec, 3, 18 );
            Tpl bone = Store( earthSec, 8, 23 );
            Tpl alch = Store( earthSec, 8, 23 );
            Tpl cook = Store( earthSec, 5, 20 );

            label11.BackColor = fish.Item1;
            label11.Text = fish.Item2;
            label12.Text = fish.Item3;
            label13.BackColor = wood.Item1;
            label13.Text = wood.Item2;
            label14.Text = wood.Item3;
            label15.BackColor = smit.Item1;
            label15.Text = smit.Item2;
            label16.Text = smit.Item3;
            label17.BackColor = gold.Item1;
            label17.Text = gold.Item2;
            label18.Text = gold.Item3;
            label19.BackColor = clot.Item1;
            label19.Text = clot.Item2;
            label20.Text = clot.Item3;
            label21.BackColor = leat.Item1;
            label21.Text = leat.Item2;
            label22.Text = leat.Item3;
            label23.BackColor = bone.Item1;
            label23.Text = bone.Item2;
            label24.Text = bone.Item3;
            label25.BackColor = alch.Item1;
            label25.Text = alch.Item2;
            label26.Text = alch.Item3;
            label27.BackColor = cook.Item1;
            label27.Text = cook.Item2;
            label28.Text = cook.Item3;
            return;

            static Tpl Store( ulong sec, byte o, byte c )
            {
                const ulong vana1h = 3456ul;
                ulong close = 3600ul * c / 25 + sec / vana1h * vana1h;
                ulong open  = 3600ul * o / 25 + sec / vana1h * vana1h;

                while( true ) {
                    if( open <= sec && sec < close ) {
                        return new( Color.FromKnownColor( KnownColor.LightGreen ), "営業中", $"{TimeSpan.FromSeconds( close - sec ):m\\:ss}" );
                    } else if( sec <= open ) {
                        break;
                    }
                    close += vana1h;
                    open  += vana1h;
                }
                return new( Color.FromKnownColor( KnownColor.Control ), "時間外", $"{TimeSpan.FromSeconds( open - sec ):m\\:ss}" );
            }
        }
    }
}
