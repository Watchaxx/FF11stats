namespace FF11stats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Icon = Resource1.logo1;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            using FormNewChr nc = new();

            if( nc.ShowDialog() == DialogResult.OK ) {
                Program.showMain = true;
                Close();
            }
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            using OpenFileDialog ofd = new();

            ofd.Filter = "キャラクタ ファイル|*.chr";
            if( ofd.ShowDialog() == DialogResult.OK ) {
                FormMain.LoadJson( ofd.FileName );
                Program.edit = ofd.FileName;
                Program.showMain = true;
                Close();
            }
            return;
        }
    }
}
