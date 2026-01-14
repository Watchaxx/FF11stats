using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormCombatSkills : Form
    {
        public FormCombatSkills()
        {
            InitializeComponent();

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                } else if( c is NumericUpDown n ) {
                    n.Maximum = MaxCombatSkill;
                }
            }
            numericUpDown1.Value = cd.SkillHand;
            numericUpDown2.Value = cd.SkillDagger;
            numericUpDown3.Value = cd.SkillKsword;
            numericUpDown4.Value = cd.SkillRsword;
            numericUpDown5.Value = cd.SkillKaxe;
            numericUpDown6.Value = cd.SkillRaxe;
            numericUpDown7.Value = cd.SkillRscythe;
            numericUpDown8.Value = cd.SkillRpolearm;
            numericUpDown9.Value = cd.SkillKkatana;
            numericUpDown10.Value = cd.SkillRkatana;
            numericUpDown11.Value = cd.SkillKclub;
            numericUpDown12.Value = cd.SkillRclub;
            numericUpDown13.Value = cd.SkillArchery;
            numericUpDown14.Value = cd.SkillMarksman;
            numericUpDown15.Value = cd.SkillThrow;
            numericUpDown16.Value = cd.SkillGuard;
            numericUpDown17.Value = cd.SkillEvasion;
            numericUpDown18.Value = cd.SkillShield;
            numericUpDown19.Value = cd.SkillParry;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is NumericUpDown n ) {
                    n.Value = MaxCombatSkill;
                }
            }
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is NumericUpDown n ) {
                    n.Value = 0;
                }
            }
            return;
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            cd.SkillHand = numericUpDown1.Value;
            cd.SkillDagger = numericUpDown2.Value;
            cd.SkillKsword = numericUpDown3.Value;
            cd.SkillRsword = numericUpDown4.Value;
            cd.SkillKaxe = numericUpDown5.Value;
            cd.SkillRaxe = numericUpDown6.Value;
            cd.SkillRscythe = numericUpDown7.Value;
            cd.SkillRpolearm = numericUpDown8.Value;
            cd.SkillKkatana = numericUpDown9.Value;
            cd.SkillRkatana = numericUpDown10.Value;
            cd.SkillKclub = numericUpDown11.Value;
            cd.SkillRclub = numericUpDown12.Value;
            cd.SkillArchery = numericUpDown13.Value;
            cd.SkillMarksman = numericUpDown14.Value;
            cd.SkillThrow = numericUpDown15.Value;
            cd.SkillGuard = numericUpDown16.Value;
            cd.SkillEvasion = numericUpDown17.Value;
            cd.SkillShield = numericUpDown18.Value;
            cd.SkillParry = numericUpDown19.Value;
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
