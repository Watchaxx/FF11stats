using System.Reflection;

namespace FF11stats
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            Text = $"{AssemblyTitle} のバージョン情報";
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = $"Version {AssemblyVersion}";
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }

        #region アセンブリ属性アクセサー

        public static string AssemblyTitle
        {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyTitleAttribute ), false );
                if( attributes.Length > 0 ) {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if( titleAttribute.Title != "" ) {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension( Assembly.GetExecutingAssembly().Location );
            }
        }

        public static string AssemblyVersion
        {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyInformationalVersionAttribute ), false );
                return attributes.Length == 0 ? "" : ( (AssemblyInformationalVersionAttribute)attributes[0] ).InformationalVersion;
                //return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static string AssemblyDescription
        {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyDescriptionAttribute ), false );
                return attributes.Length == 0 ? "" : ( (AssemblyDescriptionAttribute)attributes[0] ).Description;
            }
        }

        public static string AssemblyProduct
        {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyProductAttribute ), false );
                return attributes.Length == 0 ? "" : ( (AssemblyProductAttribute)attributes[0] ).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyCopyrightAttribute ), false );
                return attributes.Length == 0 ? "" : ( (AssemblyCopyrightAttribute)attributes[0] ).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes( typeof( AssemblyCompanyAttribute ), false );
                return attributes.Length == 0 ? "" : ( (AssemblyCompanyAttribute)attributes[0] ).Company;
            }
        }
        #endregion
    }
}
