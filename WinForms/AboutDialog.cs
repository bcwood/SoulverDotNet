using System.Reflection;
using System.Windows.Forms;

namespace SoulverDotNet.WinForms
{
	partial class AboutDialog : Form
	{
		public AboutDialog()
		{
			InitializeComponent();

			this.Text = string.Format("About {0}", AssemblyProduct);
			this.lblProductVersion.Text = string.Format("{0}, Version {1}", AssemblyProduct, AssemblyVersion);
			this.lblCopyright.Text = AssemblyCopyright;
		}

		#region Assembly Attribute Accessors

		public string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				return attributes.Length > 0 ? ((AssemblyProductAttribute) attributes[0]).Product : string.Empty;
			}
		}

		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				return attributes.Length > 0 ? ((AssemblyCopyrightAttribute) attributes[0]).Copyright : string.Empty;
			}
		}

		#endregion
	}
}
