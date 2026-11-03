using static FF11stats.Program;
using Itm = (System.Collections.Generic.Dictionary<ushort, string>, string);

namespace FF11stats
{
    public partial class FormStorageSearch : Form
    {
        public FormStorageSearch()
        {
            InitializeComponent();
        }

        private readonly DisplayStrings ds = new();

        private void Search()
        {
            const string mog = "モグの預り帳";
            Itm[] st = [(ds.StorageSlip01, $"{mog}【01】"), (ds.StorageSlip02, $"{mog}【02】"), (ds.StorageSlip03, $"{mog}【03】"), (ds.StorageSlip04, $"{mog}【04】"),
                (ds.StorageSlip05, $"{mog}【05】"), (ds.StorageSlip06, $"{mog}【06】"), (ds.StorageSlip07, $"{mog}【07】"), (ds.StorageSlip08, $"{mog}【08】"),
                (ds.StorageSlip09, $"{mog}【09】"), (ds.StorageSlip10, $"{mog}【10】"), (ds.StorageSlip11, $"{mog}【11】"), (ds.StorageSlip12, $"{mog}【12】"),
                (ds.StorageSlip13, $"{mog}【13】"), (ds.StorageSlip14, $"{mog}【14】"), (ds.StorageSlip15, $"{mog}【15】"), (ds.StorageSlip16, $"{mog}【16】"),
                (ds.StorageSlip17, $"{mog}【17】"), (ds.StorageSlip18, $"{mog}【18】"), (ds.StorageSlip19, $"{mog}【19】"), (ds.StorageSlip20, $"{mog}【20】"),
                (ds.StorageSlip21, $"{mog}【21】"), (ds.StorageSlip22, $"{mog}【22】"), (ds.StorageSlip23, $"{mog}【23】"), (ds.StorageSlip24, $"{mog}【24】"),
                (ds.StorageSlip25, $"{mog}【25】"), (ds.StorageSlip26, $"{mog}【26】"), (ds.StorageSlip27, $"{mog}【27】"), (ds.StorageSlip28, $"{mog}【28】"),
                (ds.StorageSlip29, $"{mog}【29】"), (ds.StorageSlip30, $"{mog}【30】"), (ds.StorageSlip31, $"{mog}【31】"), (ds.StorageSlip32, $"{mog}【32】"),
                (ds.StorageSlip33, $"{mog}【33】"), (ds.EventItemNPC, "イベントアイテム保管")];

            foreach( Itm i in st ) {
                foreach( KeyValuePair<ushort, string> kvp in i.Item1 ) {
                    if( string.Compare( kvp.Value, textBox1.Text, StringComparison.OrdinalIgnoreCase ) is 0 ) {
                        label4.Text = $"はい({i.Item2})";
                        label6.Text = cd.SItems.Contains( kvp.Key ) ? "はい" : "いいえ";
                        return;
                    }
                }
            }
            label4.Text = "いいえ";
            label6.Text = "いいえ";
            return;
        }

        private void FormStorageSearch_HelpButtonClicked( object sender, System.ComponentModel.CancelEventArgs e )
        {
            using FormStorageSearchHelp h = new();

            h.ShowDialog();
            e.Cancel = true;
            return;
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            Search();
            ActiveControl = textBox1;
            textBox1.SelectAll();
            return;
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            Close();
            return;
        }

        private void TextBox1_KeyPress( object sender, KeyPressEventArgs e )
        {
            if( e.KeyChar is (char)Keys.Enter ) {
                e.Handled = true;
                Search();
                textBox1.SelectAll();
            }
            return;
        }
    }
}
