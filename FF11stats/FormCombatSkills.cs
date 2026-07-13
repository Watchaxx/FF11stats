using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormCombatSkills : Form
    {
        public FormCombatSkills()
        {
            InitializeComponent();

            decimal[] cap = [424m, 417m];

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                } else if( c is NumericUpDown n ) {
                    n.Maximum = cap[0];
                }
            }
            numericUpDown1.Maximum += Math.Max( cd.MstlvlMnk, cd.MstlvlPup );
            numericUpDown1.Value = cd.SkillHand;
            numericUpDown2.Maximum += Math.Max( cd.MstlvlThf, cd.MstlvlDnc );
            numericUpDown2.Value = cd.SkillDagger;
            numericUpDown3.Maximum += Math.Max( cd.MstlvlPld, cd.MstlvlBlu );
            numericUpDown3.Value = cd.SkillKsword;
            numericUpDown4.Maximum += cd.MstlvlRun;
            numericUpDown4.Value = cd.SkillRsword;
            numericUpDown5.Maximum += cd.MstlvlBst;
            numericUpDown5.Value = cd.SkillKaxe;
            numericUpDown6.Maximum += cd.MstlvlWar;
            numericUpDown6.Value = cd.SkillRaxe;
            numericUpDown7.Maximum += cd.MstlvlDrk;
            numericUpDown7.Value = cd.SkillRscythe;
            numericUpDown8.Maximum += cd.MstlvlDrg;
            numericUpDown8.Value = cd.SkillRpolearm;
            numericUpDown9.Maximum += cd.MstlvlNin;
            numericUpDown9.Value = cd.SkillKkatana;
            numericUpDown10.Maximum += cd.MstlvlSam;
            numericUpDown10.Value = cd.SkillRkatana;
            numericUpDown11.Maximum = cap[1] + cd.MstlvlPld;
            numericUpDown11.Value = cd.SkillKclub;
            numericUpDown12.Maximum = cap[1] + cd.MstlvlPld;
            numericUpDown12.Value = cd.SkillRclub;
            numericUpDown13.Maximum += cd.MstlvlRng;
            numericUpDown13.Value = cd.SkillArchery;
            numericUpDown14.Maximum += cd.MstlvlRng;
            numericUpDown14.Value = cd.SkillMarksman;
            numericUpDown15.Maximum += cd.MstlvlNin;
            numericUpDown15.Value = cd.SkillThrow;
            numericUpDown16.Maximum = cap[1] + cd.MstlvlMnk;
            numericUpDown16.Value = cd.SkillGuard;
            numericUpDown17.Maximum += cd.MstlvlThf;
            numericUpDown17.Value = cd.SkillEvasion;
            numericUpDown18.Maximum += cd.MstlvlPld;
            numericUpDown18.Value = cd.SkillShield;
            numericUpDown19.Maximum += cd.MstlvlRun;
            numericUpDown19.Value = cd.SkillParry;
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

        private void Button5_Click( object sender, EventArgs e )
        {
            byte[] b = MeripoLoad( cd.MeritCombatSkills1 ).Select( x => (byte)( 2 * x ) ).ToArray();
            System.Text.StringBuilder sb = new( "メリットポイント及びギフトによる強化を含めた値です。" );

            sb.AppendLine().AppendLine( "※入力や確認を行う際は装備品を外すことを推奨します。" ).AppendLine();
            sb.AppendLine( $"格闘\t{numericUpDown1.Value + b[0]}\t短剣\t{numericUpDown2.Value + b[1]}" );
            sb.AppendLine( $"片手剣\t{numericUpDown3.Value + b[2]}\t両手剣\t{numericUpDown4.Value + b[3]}" );
            sb.AppendLine( $"片手斧\t{numericUpDown5.Value + b[4]}\t両手斧\t{numericUpDown6.Value + b[5]}" );
            sb.AppendLine( $"両手鎌\t{numericUpDown7.Value + b[6]}\t両手槍\t{numericUpDown8.Value + b[7]}" );
            sb.AppendLine( $"片手刀\t{numericUpDown9.Value + b[8]}\t両手刀\t{numericUpDown10.Value + b[9]}" );
            sb.AppendLine( $"片手棍\t{numericUpDown11.Value + b[10]}\t両手棍\t{numericUpDown12.Value + b[11]}" );
            sb.AppendLine( $"弓術\t{numericUpDown13.Value + b[12]}\t射撃\t{numericUpDown14.Value + b[13]}" );
            sb.Append( $"投てき\t{numericUpDown15.Value + b[14]}\t" );
            b = MeripoLoad( cd.MeritCombatSkills2 ).Select( x => (byte)( 2 * x ) ).ToArray();
            sb.AppendLine( $"ガード\t{numericUpDown16.Value + b[0]}" );
            sb.AppendLine( $"回避\t{numericUpDown17.Value + b[1]}\t盾\t{numericUpDown18.Value + b[2]}" );
            sb.AppendLine( $"受け流し\t{numericUpDown19.Value + b[3]}" );
            MessageBox.Show( $"{sb}", "含メリポ", MessageBoxButtons.OK, MessageBoxIcon.Information );
            return;
        }
    }
}
