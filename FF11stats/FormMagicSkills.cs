using static FF11stats.Program;
using static System.Convert;

namespace FF11stats
{
    public partial class FormMagicSkills : Form
    {
        enum Cap
        {
            A1 = 424,
            A2 = 417,
            B1 = 404,
            B2 = 398,
            B3 = 388,
            C1 = 378,
            C2 = 373
        }

        public FormMagicSkills()
        {
            InitializeComponent();

            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                }
            }
            numericUpDown1.Maximum = ToDecimal( Cap.A2 ) + cd.MstlvlWhm;
            numericUpDown1.Value = cd.SkillDivine;
            numericUpDown2.Maximum = ToDecimal( Cap.A1 ) + cd.MstlvlWhm;
            numericUpDown2.Value = cd.SkillHealing;
            numericUpDown3.Maximum = ToDecimal( Cap.B1 ) + cd.MstlvlRdm;
            numericUpDown3.Value = cd.SkillEnhancing;
            numericUpDown4.Maximum = ToDecimal( Cap.A1 ) + cd.MstlvlRdm;
            numericUpDown4.Value = cd.SkillEnfeebling;
            numericUpDown5.Maximum = ToDecimal( Cap.A1 ) + cd.MstlvlBlm;
            numericUpDown5.Value = cd.SkillElemental;
            numericUpDown6.Maximum = ToDecimal( Cap.A2 ) + Math.Max( cd.MstlvlBlm, cd.MstlvlDrk );
            numericUpDown6.Value = cd.SkillDark;
            numericUpDown7.Maximum = ToDecimal( Cap.A2 ) + cd.MstlvlSmn;
            numericUpDown7.Value = cd.SkillSummoning;
            numericUpDown8.Maximum = ToDecimal( Cap.A2 ) + cd.MstlvlNin;
            numericUpDown8.Value = cd.SkillNinjutsu;
            numericUpDown9.Maximum = ToDecimal( Cap.C2 ) + cd.MstlvlBrd;
            numericUpDown9.Value = cd.SkillSinging;
            numericUpDown10.Maximum = ToDecimal( Cap.C2 ) + cd.MstlvlBrd;
            numericUpDown10.Value = cd.SkillStringInst;
            numericUpDown11.Maximum = ToDecimal( Cap.C2 ) + cd.MstlvlBrd;
            numericUpDown11.Value = cd.SkillWindInst;
            numericUpDown12.Maximum = ToDecimal( Cap.A1 ) + cd.MstlvlBlu;
            numericUpDown12.Value = cd.SkillBlue;
            numericUpDown13.Maximum = ToDecimal( Cap.C2 ) + cd.MstlvlGeo;
            numericUpDown13.Value = cd.SkillGeomancy;
            numericUpDown14.Maximum = ToDecimal( Cap.C2 ) + cd.MstlvlGeo;
            numericUpDown14.Value = cd.SkillHandbell;
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

        private void Button5_Click( object sender, EventArgs e )
        {
            byte[] b = MeripoLoad( cd.MeritMagicSkills ).Select( x => (byte)( 2 * x ) ).ToArray();
            System.Text.StringBuilder sb = new( "メリットポイント及びギフトによる強化を含めた値です。" );

            sb.AppendLine().AppendLine( "※入力や確認を行う際は装備品を外すことを推奨します。" ).AppendLine();
            sb.AppendLine( $"神聖魔法\t{numericUpDown1.Value + b[0]}\t回復魔法\t{numericUpDown2.Value + b[1]}" );
            sb.AppendLine( $"強化魔法\t{numericUpDown3.Value + b[2]}\t弱体魔法\t{numericUpDown4.Value + b[3]}" );
            sb.AppendLine( $"精霊魔法\t{numericUpDown5.Value + b[4]}\t暗黒魔法\t{numericUpDown6.Value + b[5]}" );
            sb.AppendLine( $"召喚魔法\t{numericUpDown7.Value + b[6]}\t忍術\t{numericUpDown8.Value + b[7]}" );
            sb.AppendLine( $"歌唱\t{numericUpDown9.Value + b[8]}\t弦楽器\t{numericUpDown10.Value + b[9]}" );
            sb.AppendLine( $"管楽器\t{numericUpDown11.Value + b[10]}\t青魔法\t{numericUpDown12.Value + b[11]}" );
            sb.AppendLine( $"風水魔法\t{numericUpDown13.Value + b[12]}\t風水鈴\t{numericUpDown14.Value + b[13]}" );
            MessageBox.Show( $"{sb}", "含メリポ", MessageBoxButtons.OK, MessageBoxIcon.Information );
            return;
        }
    }
}
