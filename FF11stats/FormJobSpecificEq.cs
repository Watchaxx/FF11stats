using static FF11stats.Program;

namespace FF11stats
{
    public partial class FormJobSpecificEq : Form
    {
        public FormJobSpecificEq()
        {
            InitializeComponent();

            int idx = 41;
            string[] disp = ["119+4", "119+3", "119+2", "119", "109", "+1", "AF"];
            DisplayStrings ds = new();
            ushort[] key1 = ds.StorageSlip32.Keys.ToArray();
            ushort[] key2 = ds.StorageSlip25.Keys.ToArray();
            ushort[] key3 = ds.StorageSlip24.Keys.ToArray();
            ushort[] key4 = ds.StorageSlip16.Keys.ToArray();
            ushort[] key5 = ds.StorageSlip15.Keys.ToArray();
            ushort[] key6 = ds.StorageSlip05.Keys.ToArray();
            ushort[] key7 = ds.StorageSlip04.Keys.Except( new ushort[] {
                16678, 17478, 17422, 17423, 16829, 16764, 17643, 16798, 16680, 16766, 17188, 17812,
                17771, 17772, 16887, 17532, 17717, 18702, 17858, 19203, 21461, 21124, 20776 } ).ToArray();
            ushort[] pad = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
            ushort[][] itm = new ushort[5 * 22][];

            if( cd.Race is 0 or 2 or 4 or 7 ) {
                ushort[] ex = [16139, 14579, 15003, 15660, 15747];

                key1 = key1.Except( ex ).ToArray();
                ex = [11476, 11303, 15036, 16358, 11394];
                key2 = key2.Except( ex ).ToArray();
                ex = [27682, 27826, 27962, 28109, 28242];
                key3 = key3.Except( ex ).ToArray();
                ex = [27703, 27847, 27983, 28130, 28263];
                key4 = key4.Except( ex ).ToArray();
                ex = [23059, 23126, 23193, 23260, 23327];
                key5 = key5.Except( ex ).Concat( pad ).ToArray();
                ex = [23394, 23461, 23528, 23595, 23662];
                key6 = key6.Except( ex ).Concat( pad ).ToArray();
                ex = [23914, 23959, 24004, 24049, 24094];
                key7 = key7.Except( ex ).ToArray();
            } else if( cd.Race is 1 or 3 or 5 or 6 ) {
                ushort[] ex = [23913, 23958, 24003, 24048, 24093];

                key1 = key1.Except( ex ).ToArray();
                ex = [23393, 23460, 23527, 23594, 23661];
                key2 = key2.Except( ex ).ToArray();
                ex = [23058, 23125, 23192, 23259, 23326];
                key3 = key3.Except( ex ).ToArray();
                ex = [27702, 27846, 27982, 28129, 28262];
                key4 = key4.Except( ex ).ToArray();
                ex = [27681, 27825, 27961, 28108, 28241];
                key5 = key5.Except( ex ).Concat( pad ).ToArray();
                ex = [11475, 11302, 15035, 16357, 11393];
                key6 = key6.Except( ex ).Concat( pad ).ToArray();
                ex = [16138, 14578, 15002, 15659, 15746];
                key7 = key7.Except( ex ).ToArray();
            }
            foreach( int i in Enumerable.Range( 0, 5 * 22 ) ) {
                itm[i] = [key1[i], key2[i], key3[i], key4[i], key5[i], key6[i], key7[i]];
            }
            tableLayoutPanel1.SuspendLayout();
            foreach( int i in Enumerable.Range( 0, itm.Length ) ) {
                int f = Array.FindIndex( itm[i], cd.SItems.Contains );

                tableLayoutPanel1.Controls.Add( new Label() {
                    AutoSize = true,
                    Name = $"label{idx}",
                    Size = new( 1, 15 ),
                    TabIndex = idx - 1,
                    Text = 0 <= f ? disp[f] : "(無し)"
                }, i % 5 + 1, i / 5 + 2 );
                idx++;
            }
            key1 = ds.StorageSlip33.Keys.ToArray();
            key2 = ds.StorageSlip27.Keys.ToArray();
            key3 = ds.StorageSlip26.Keys.ToArray();
            key4 = ds.StorageSlip18.Keys.ToArray();
            key5 = ds.StorageSlip17.Keys.ToArray();
            key6 = ds.StorageSlip13.Keys.Concat( pad ).ToArray();
            key7 = ds.StorageSlip07.Keys.Concat( pad ).ToArray();

            ushort[] exc = [15871, 15478, 15872, 15874, 15873, 15480, 15481, 15479, 15875, 15482,
                15876, 15879, 15877, 15878, 15484, 16244, 15920, 16245, 16248, 15925];
            ushort[] key8 = ds.StorageSlip06.Keys.Except( exc ).Concat( pad ).ToArray();

            disp = ["119+4", "119+3", "119+2", "119", "109", "+2", "+1", "レリック"];
            foreach( int i in Enumerable.Range( 0, 5 * 22 ) ) {
                itm[i] = [key1[i], key2[i], key3[i], key4[i], key5[i], key6[i], key7[i], key8[i]];
            }
            foreach( int i in Enumerable.Range( 0, itm.Length ) ) {
                int f = Array.FindIndex( itm[i], cd.SItems.Contains );

                tableLayoutPanel1.Controls.Add( new Label() {
                    AutoSize = true,
                    Name = $"label{idx}",
                    Size = new( 1, 15 ),
                    TabIndex = idx - 1,
                    Text = 0 <= f ? disp[f] : "(無し)"
                }, i % 5 + 6, i / 5 + 2 );
                idx++;
            }
            exc = [11591, 19253, 11592, 19254, 11615, 11554, 11593, 16203, 11594, 16204,
                11736, 19260, 11595, 11750, 11616, 11737, 11617, 11555, 11618, 11738,
                11596, 16205, 11597, 16206, 11598, 16207, 11599, 16208, 11619, 11739,
                11600, 19255, 11601, 16209, 11602, 11751, 11603, 19256, 11620, 19247,
                11703, 11704, 11705, 11706, 11707, 11708, 11709, 11710, 11711, 11712,
                11713, 11714, 11715, 11716, 11717, 11718, 11719, 11720, 11721, 11722];
            key1 = ds.StorageSlip30.Keys.ToArray();
            key2 = ds.StorageSlip29.Keys.ToArray();
            key3 = ds.StorageSlip21.Keys.ToArray();
            key4 = ds.StorageSlip20.Keys.ToArray();
            key5 = ds.StorageSlip10.Keys.Concat( pad ).ToArray();
            key6 = ds.StorageSlip09.Keys.Concat( pad ).ToArray();
            key7 = ds.StorageSlip08.Keys.Except( exc ).Concat( pad ).ToArray();
            disp = ["119+3", "119+2", "119", "109", "+2", "+1", "エンピ"];
            foreach( int i in Enumerable.Range( 0, 5 * 22 ) ) {
                itm[i] = [key1[i], key2[i], key3[i], key4[i], key5[i], key6[i], key7[i]];
            }
            foreach( int i in Enumerable.Range( 0, itm.Length ) ) {
                int f = Array.FindIndex( itm[i], cd.SItems.Contains );

                tableLayoutPanel1.Controls.Add( new Label() {
                    AutoSize = true,
                    Name = $"label{idx}",
                    Size = new( 1, 15 ),
                    TabIndex = idx - 1,
                    Text = 0 <= f ? disp[f] : "(無し)"
                }, i % 5 + 11, i / 5 + 2 );
                idx++;
            }
            tableLayoutPanel1.ResumeLayout();
        }
    }
}
