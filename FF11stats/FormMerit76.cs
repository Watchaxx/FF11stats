using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormMerit76 : Form
    {
        internal FormMerit76( Jobs j )
        {
            InitializeComponent();

            uint g1 = 0;
            uint g2 = 0;
            Label[] lbl = [label3, label4, label5, label6, label7, label8, label9, label12, label13, label14, label15, label16, label17];

            job = j;
            foreach( Control c in tableLayoutPanel1.Controls ) {
                if( c is Label l ) {
                    l.Anchor = AnchorStyles.Left;
                }
            }
            switch( job ) {
            case Jobs.Blm:
                g1 = cd.MeritBlm1;
                g2 = cd.MeritBlm2;
                Text += "黒魔道士";
                lbl[0].Text = "精霊の印使用間隔";
                lbl[1].Text = "火属性魔法攻撃力";
                lbl[2].Text = "氷属性魔法攻撃力";
                lbl[3].Text = "風属性魔法攻撃力";
                lbl[4].Text = "土属性魔法攻撃力";
                lbl[5].Text = "雷属性魔法攻撃力";
                lbl[6].Text = "水属性魔法攻撃力";
                lbl[7].Text = "古代魔法の魔法攻撃力";
                lbl[8].Text = "古代魔法のMBダメージ";
                lbl[9].Text = "精霊魔法の魔法命中率";
                lbl[10].Text = "精霊魔法のSTダウン効果時間";
                lbl[11].Text = "精霊魔法のSTダウン効果";
                lbl[12].Text = "アスピル吸収量";
                break;
            case Jobs.Rdm:
                g1 = cd.MeritRdm1;
                g2 = cd.MeritRdm2;
                Text += "赤魔道士";
                lbl[0].Text = "コンバート使用間隔";
                lbl[1].Text = "火属性魔法命中率";
                lbl[2].Text = "氷属性魔法命中率";
                lbl[3].Text = "風属性魔法命中率";
                lbl[4].Text = "土属性魔法命中率";
                lbl[5].Text = "雷属性魔法命中率";
                lbl[6].Text = "水属性魔法命中率";
                lbl[7].Text = "弱体魔法の効果時間";
                lbl[8].Text = "魔法命中率";
                lbl[9].Text = "強化魔法の効果時間";
                lbl[10].Text = "レジストハック確率";
                lbl[11].Text = "魔法剣ダメージ";
                lbl[12].Text = "命中率";
                break;
            case Jobs.Nin:
                g1 = cd.MeritNin1;
                g2 = cd.MeritNin2;
                Text += "忍者";
                lbl[0].Text = "モクシャ効果";
                lbl[1].Text = "火遁の術効果";
                lbl[2].Text = "氷遁の術効果";
                lbl[3].Text = "風遁の術効果";
                lbl[4].Text = "土遁の術効果";
                lbl[5].Text = "雷遁の術効果";
                lbl[6].Text = "水遁の術効果";
                lbl[7].Text = "散華";
                lbl[8].Text = "忍具の知識";
                lbl[9].Text = "陽忍効果アップ";
                lbl[10].Text = "陰忍効果アップ";
                lbl[11].Text = "忍術の魔法命中率";
                lbl[12].Text = "忍術の魔法攻撃力";
                break;
            }

            byte[] b = MeripoLoad( g1 );

            numericUpDown1.Value = b[0];
            numericUpDown2.Value = b[1];
            numericUpDown3.Value = b[2];
            numericUpDown4.Value = b[3];
            numericUpDown5.Value = b[4];
            numericUpDown6.Value = b[5];
            numericUpDown7.Value = b[6];
            b = MeripoLoad( g2 );
            numericUpDown8.Value = b[0];
            numericUpDown9.Value = b[1];
            numericUpDown10.Value = b[2];
            numericUpDown11.Value = b[3];
            numericUpDown12.Value = b[4];
            numericUpDown13.Value = b[5];
        }

        static decimal s1 = 0;
        static decimal s2 = 0;
        static Jobs job;

        private void Button1_Click( object sender, EventArgs e )
        {
            if( MaxMeripo < s1 || MaxMeripo < s2 ) {
                MeripoErr( MaxMeripo );
                return;
            }

            uint g1 = MeripoSave32( numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, numericUpDown6.Value, numericUpDown7.Value );
            uint g2 = MeripoSave32( numericUpDown8.Value, numericUpDown9.Value, numericUpDown10.Value, numericUpDown11.Value, numericUpDown12.Value, numericUpDown13.Value );

            switch( job ) {
            case Jobs.Blm:
                cd.MeritBlm1 = g1;
                cd.MeritBlm2 = g2;
                break;
            case Jobs.Rdm:
                cd.MeritRdm1 = g1;
                cd.MeritRdm2 = g2;
                break;
            case Jobs.Nin:
                cd.MeritNin1 = g1;
                cd.MeritNin2 = g2;
                break;
            }
            Close();
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            Close();
            return;
        }

        private void NumericUpDown1_ValueChanged( object sender, EventArgs e )
        {
            decimal v = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value + numericUpDown7.Value;

            s1 = v;
            label2.ForeColor = MaxMeripo < v ? Color.Red : Color.FromKnownColor( KnownColor.ControlText );
            label2.Text = $"{v}/{MaxMeripo}";
            return;
        }

        private void NumericUpDown8_ValueChanged( object sender, EventArgs e )
        {
            decimal v = numericUpDown8.Value + numericUpDown9.Value + numericUpDown10.Value + numericUpDown11.Value + numericUpDown12.Value + numericUpDown13.Value;

            s2 = v;
            label11.ForeColor = MaxMeripo < v ? Color.Red : Color.FromKnownColor( KnownColor.ControlText );
            label11.Text = $"{v}/{MaxMeripo}";
            return;
        }
    }
}
