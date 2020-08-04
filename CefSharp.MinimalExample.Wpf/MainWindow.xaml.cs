using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

			Browser.IsBrowserInitializedChanged += (sender, e) =>
			{
				if ((bool)e.NewValue)
					Browser.LoadHtml(
						"<html><body><h1>"
							+ $"CefSharpVersion {Cef.ChromiumVersion}<br>"
							+ $"CefVersion {Cef.CefVersion}<br>"
							+ $"CefSharpVersion {Cef.CefSharpVersion}"
						+ "</h1></body></html>");
			};
		}
    }
}
