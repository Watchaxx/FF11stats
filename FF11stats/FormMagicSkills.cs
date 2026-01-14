using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMagicSkills : Form
    {
        public FormMagicSkills()
        {
            InitializeComponent();

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                } else if( c is NumericUpDown n ) {
                    n.Maximum = MaxCombatSkill;
                }
            }
            numericUpDown1.Value = cd.SkillDivine;
            numericUpDown2.Value = cd.SkillHealing;
            numericUpDown3.Value = cd.SkillEnhancing;
            numericUpDown4.Value = cd.SkillEnfeebling;
            numericUpDown5.Value = cd.SkillElemental;
            numericUpDown6.Value = cd.SkillDark;
            numericUpDown7.Value = cd.SkillSummoning;
            numericUpDown8.Value = cd.SkillNinjutsu;
            numericUpDown9.Value = cd.SkillSinging;
            numericUpDown10.Value = cd.SkillStringInst;
            numericUpDown11.Value = cd.SkillWindInst;
            numericUpDown12.Value = cd.SkillBlue;
            numericUpDown13.Value = cd.SkillGeomancy;
            numericUpDown14.Value = cd.SkillHandbell;
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
            cd.SkillDivine = numericUpDown1.Value;
            cd.SkillHealing = numericUpDown2.Value;
            cd.SkillEnhancing = numericUpDown3.Value;
            cd.SkillEnfeebling = numericUpDown4.Value;
            cd.SkillElemental = numericUpDown5.Value;
            cd.SkillDark = numericUpDown6.Value;
            cd.SkillSummoning = numericUpDown7.Value;
            cd.SkillNinjutsu = numericUpDown8.Value;
            cd.SkillSinging = numericUpDown9.Value;
            cd.SkillStringInst = numericUpDown10.Value;
            cd.SkillWindInst = numericUpDown11.Value;
            cd.SkillBlue = numericUpDown12.Value;
            cd.SkillGeomancy = numericUpDown13.Value;
            cd.SkillHandbell = numericUpDown14.Value;
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
