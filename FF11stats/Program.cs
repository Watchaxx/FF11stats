namespace FF11stats
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run( new Form1() );
            if( showMain is true ) {
                Application.Run( new FormMain() );
            }
            GC.Collect();
            return;
        }

        internal const byte MaxJoblvl = 99;
        internal const byte MaxMstlvl = 50;
        internal const byte MaxMeripo = 10;
        internal const decimal MaxCombatSkill = 440m;
        internal const decimal MaxSynergySkill = 80m;
        internal const decimal MaxSynthSkill1 = 70m;
        internal const decimal MaxSynthSkill2 = 110m;
        internal const string NumComp = "コンプリート数：";
        internal const string NumLearn = "習得数：";
        internal static bool showMain = false;
        internal static string edit = string.Empty;
        internal static string sea = string.Empty;
        internal static ChrDat cd = new();

        internal enum Jobs
        {
            War,
            Mnk,
            Whm,
            Blm,
            Rdm,
            Thf,
            Pld,
            Drk,
            Bst,
            Brd,
            Rng,
            Sam,
            Nin,
            Drg,
            Smn,
            Blu,
            Cor,
            Pup,
            Dnc,
            Sch,
            Geo,
            Run
        }

        internal enum Mission
        {
            Sandoria,
            Bastok,
            Windurst,
            Zilart,
            Promathia,
            Ahturhgan,
            Altana,
            Adoulin
        }

        /// <summary>
        /// メリポグループの入力値が上限を超えている時
        /// </summary>
        /// <param name="max">上限値</param>
        internal static void MeripoErr( byte max )
        {
            MessageBox.Show( $"能力値の上限は {max} です。", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            return;
        }

        /// <summary>
        /// キャラクタデータからメリポを取り出す(32 bits)
        /// </summary>
        /// <param name="i">キャラクタデータ</param>
        /// <returns>取り出したメリポ</returns>
        //メリポの項目が増えた時はシフト数を減らす。それでも足りなくなったら uint を ulong にする
        internal static byte[] MeripoLoad( uint i )
        {
            return [
                (byte)(   i & 0x0000_000Fu ),
                (byte)( ( i & 0x0000_00F0u ) >>> 4 ),
                (byte)( ( i & 0x0000_0F00u ) >>> 8 ),
                (byte)( ( i & 0x0000_F000u ) >>> 12 ),
                (byte)( ( i & 0x000F_0000u ) >>> 16 ),
                (byte)( ( i & 0x00F0_0000u ) >>> 20 ),
                (byte)( ( i & 0x0F00_0000u ) >>> 24 ),
                (byte)( ( i & 0xF000_0000u ) >>> 28 ),
            ];
        }

        /// <summary>
        /// キャラクタデータからメリポを取り出す(64 bits)
        /// </summary>
        /// <param name="i">キャラクタデータ</param>
        /// <returns>取り出したメリポ</returns>
        internal static byte[] MeripoLoad( ulong i )
        {
            return [
                (byte)(   i & 0x0000_0000_0000_000Ful ),
                (byte)( ( i & 0x0000_0000_0000_00F0ul ) >>> 4 ),
                (byte)( ( i & 0x0000_0000_0000_0F00ul ) >>> 8 ),
                (byte)( ( i & 0x0000_0000_0000_F000ul ) >>> 12 ),
                (byte)( ( i & 0x0000_0000_000F_0000ul ) >>> 16 ),
                (byte)( ( i & 0x0000_0000_00F0_0000ul ) >>> 20 ),
                (byte)( ( i & 0x0000_0000_0F00_0000ul ) >>> 24 ),
                (byte)( ( i & 0x0000_0000_F000_0000ul ) >>> 28 ),
                (byte)( ( i & 0x0000_000F_0000_0000ul ) >>> 32 ),
                (byte)( ( i & 0x0000_00F0_0000_0000ul ) >>> 36 ),
                (byte)( ( i & 0x0000_0F00_0000_0000ul ) >>> 40 ),
                (byte)( ( i & 0x0000_F000_0000_0000ul ) >>> 44 ),
                (byte)( ( i & 0x000F_0000_0000_0000ul ) >>> 48 ),
                (byte)( ( i & 0x00F0_0000_0000_0000ul ) >>> 52 ),
                (byte)( ( i & 0x0F00_0000_0000_0000ul ) >>> 56 ),
                (byte)( ( i & 0xF000_0000_0000_0000ul ) >>> 60 )
            ];
        }

        /// <summary>
        /// キャラクタデータにメリポを登録(32 bits)
        /// </summary>
        internal static uint MeripoSave32( decimal a = 0, decimal b = 0, decimal c = 0, decimal d = 0, decimal e = 0, decimal f = 0, decimal g = 0, decimal h = 0 )
        {
            return ( (uint)h << 28 ) | ( (uint)g << 24 ) | ( (uint)f << 20 ) | ( (uint)e << 16 ) | ( (uint)d << 12 ) | ( (uint)c << 8 ) | ( (uint)b << 4 ) | (uint)a;
        }

        /// <summary>
        /// キャラクタデータにメリポを登録(64 bits)
        /// </summary>
        internal static ulong MeripoSave64( decimal a = 0, decimal b = 0, decimal c = 0, decimal d = 0, decimal e = 0, decimal f = 0, decimal g = 0, decimal h = 0,
                                        decimal i = 0, decimal j = 0, decimal k = 0, decimal l = 0, decimal m = 0, decimal n = 0, decimal o = 0, decimal p = 0 )
        {
            return ( (ulong)p << 60 ) | ( (ulong)o << 56 ) | ( (ulong)n << 52 ) | ( (ulong)m << 48 ) | ( (ulong)l << 44 ) | ( (ulong)k << 40 ) | ( (ulong)j << 36 ) | ( (ulong)i << 32 )
                | ( (ulong)h << 28 ) | ( (ulong)g << 24 ) | ( (ulong)f << 20 ) | ( (ulong)e << 16 ) | ( (ulong)d << 12 ) | ( (ulong)c << 8 ) | ( (ulong)b << 4 ) |  (ulong)a;
        }

        /// <summary>
        /// フェイスタイプの画像を設定
        /// </summary>
        /// <param name="race">種族</param>
        /// <param name="type">フェイスタイプ</param>
        /// <returns>画像</returns>
        internal static Image SetFaceImg( int race, int type )
        {
            switch( race ) {
            case 0:
                switch( type ) {
                case 0:
                    return Resource1.hm1a;
                case 1:
                    return Resource1.hm1b;
                case 2:
                    return Resource1.hm2a;
                case 3:
                    return Resource1.hm2b;
                case 4:
                    return Resource1.hm3a;
                case 5:
                    return Resource1.hm3b;
                case 6:
                    return Resource1.hm4a;
                case 7:
                    return Resource1.hm4b;
                case 8:
                    return Resource1.hm5a;
                case 9:
                    return Resource1.hm5b;
                case 10:
                    return Resource1.hm6a;
                case 11:
                    return Resource1.hm6b;
                case 12:
                    return Resource1.hm7a;
                case 13:
                    return Resource1.hm7b;
                case 14:
                    return Resource1.hm8a;
                case 15:
                    return Resource1.hm8b;
                }
                break;
            case 1:
                switch( type ) {
                case 0:
                    return Resource1.hf1a;
                case 1:
                    return Resource1.hf1b;
                case 2:
                    return Resource1.hf2a;
                case 3:
                    return Resource1.hf2b;
                case 4:
                    return Resource1.hf3a;
                case 5:
                    return Resource1.hf3b;
                case 6:
                    return Resource1.hf4a;
                case 7:
                    return Resource1.hf4b;
                case 8:
                    return Resource1.hf5a;
                case 9:
                    return Resource1.hf5b;
                case 10:
                    return Resource1.hf6a;
                case 11:
                    return Resource1.hf6b;
                case 12:
                    return Resource1.hf7a;
                case 13:
                    return Resource1.hf7b;
                case 14:
                    return Resource1.hf8a;
                case 15:
                    return Resource1.hf8b;
                }
                break;
            case 2:
                switch( type ) {
                case 0:
                    return Resource1.em1a;
                case 1:
                    return Resource1.em1b;
                case 2:
                    return Resource1.em2a;
                case 3:
                    return Resource1.em2b;
                case 4:
                    return Resource1.em3a;
                case 5:
                    return Resource1.em3b;
                case 6:
                    return Resource1.em4a;
                case 7:
                    return Resource1.em4b;
                case 8:
                    return Resource1.em5a;
                case 9:
                    return Resource1.em5b;
                case 10:
                    return Resource1.em6a;
                case 11:
                    return Resource1.em6b;
                case 12:
                    return Resource1.em7a;
                case 13:
                    return Resource1.em7b;
                case 14:
                    return Resource1.em8a;
                case 15:
                    return Resource1.em8b;
                }
                break;
            case 3:
                switch( type ) {
                case 0:
                    return Resource1.ef1a;
                case 1:
                    return Resource1.ef1b;
                case 2:
                    return Resource1.ef2a;
                case 3:
                    return Resource1.ef2b;
                case 4:
                    return Resource1.ef3a;
                case 5:
                    return Resource1.ef3b;
                case 6:
                    return Resource1.ef4a;
                case 7:
                    return Resource1.ef4b;
                case 8:
                    return Resource1.ef5a;
                case 9:
                    return Resource1.ef5b;
                case 10:
                    return Resource1.ef6a;
                case 11:
                    return Resource1.ef6b;
                case 12:
                    return Resource1.ef7a;
                case 13:
                    return Resource1.ef7b;
                case 14:
                    return Resource1.ef8a;
                case 15:
                    return Resource1.ef8b;
                }
                break;
            case 4:
                switch( type ) {
                case 0:
                    return Resource1.tm1a;
                case 1:
                    return Resource1.tm1b;
                case 2:
                    return Resource1.tm2a;
                case 3:
                    return Resource1.tm2b;
                case 4:
                    return Resource1.tm3a;
                case 5:
                    return Resource1.tm3b;
                case 6:
                    return Resource1.tm4a;
                case 7:
                    return Resource1.tm4b;
                case 8:
                    return Resource1.tm5a;
                case 9:
                    return Resource1.tm5b;
                case 10:
                    return Resource1.tm6a;
                case 11:
                    return Resource1.tm6b;
                case 12:
                    return Resource1.tm7a;
                case 13:
                    return Resource1.tm7b;
                case 14:
                    return Resource1.tm8a;
                case 15:
                    return Resource1.tm8b;
                }
                break;
            case 5:
                switch( type ) {
                case 0:
                    return Resource1.tf1a;
                case 1:
                    return Resource1.tf1b;
                case 2:
                    return Resource1.tf2a;
                case 3:
                    return Resource1.tf2b;
                case 4:
                    return Resource1.tf3a;
                case 5:
                    return Resource1.tf3b;
                case 6:
                    return Resource1.tf4a;
                case 7:
                    return Resource1.tf4b;
                case 8:
                    return Resource1.tf5a;
                case 9:
                    return Resource1.tf5b;
                case 10:
                    return Resource1.tf6a;
                case 11:
                    return Resource1.tf6b;
                case 12:
                    return Resource1.tf7a;
                case 13:
                    return Resource1.tf7b;
                case 14:
                    return Resource1.tf8a;
                case 15:
                    return Resource1.tf8b;
                }
                break;
            case 6:
                switch( type ) {
                case 0:
                    return Resource1.mf1a;
                case 1:
                    return Resource1.mf1b;
                case 2:
                    return Resource1.mf2a;
                case 3:
                    return Resource1.mf2b;
                case 4:
                    return Resource1.mf3a;
                case 5:
                    return Resource1.mf3b;
                case 6:
                    return Resource1.mf4a;
                case 7:
                    return Resource1.mf4b;
                case 8:
                    return Resource1.mf5a;
                case 9:
                    return Resource1.mf5b;
                case 10:
                    return Resource1.mf6a;
                case 11:
                    return Resource1.mf6b;
                case 12:
                    return Resource1.mf7a;
                case 13:
                    return Resource1.mf7b;
                case 14:
                    return Resource1.mf8a;
                case 15:
                    return Resource1.mf8b;
                }
                break;
            case 7:
                switch( type ) {
                case 0:
                    return Resource1.gm1a;
                case 1:
                    return Resource1.gm1b;
                case 2:
                    return Resource1.gm2a;
                case 3:
                    return Resource1.gm2b;
                case 4:
                    return Resource1.gm3a;
                case 5:
                    return Resource1.gm3b;
                case 6:
                    return Resource1.gm4a;
                case 7:
                    return Resource1.gm4b;
                case 8:
                    return Resource1.gm5a;
                case 9:
                    return Resource1.gm5b;
                case 10:
                    return Resource1.gm6a;
                case 11:
                    return Resource1.gm6b;
                case 12:
                    return Resource1.gm7a;
                case 13:
                    return Resource1.gm7b;
                case 14:
                    return Resource1.gm8a;
                case 15:
                    return Resource1.gm8b;
                }
                break;
            }
            return Resource1.hm1a;
        }

        /// <summary>
        /// 2つの文字列が同じか調べる
        /// </summary>
        /// <param name="a">文字列1</param>
        /// <param name="b">文字列2</param>
        /// <returns>a と b が同じなら true，それ以外は false</returns>
        internal static bool StrComp( string a, string b )
        {
            return string.Compare( a, b, StringComparison.Ordinal ) is 0;
        }
    }
}