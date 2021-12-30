using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

class Wraper : System.Windows.Forms.Form
{
    Wraper()
    {
        // Initial form configuration
        Width = 1024;
        Height = 768;
        Text = "Loading...";
        StartPosition = FormStartPosition.CenterScreen;
        InitWebView();
    }

    async void InitWebView()
    {
        var webView = new WebView2() { Dock = DockStyle.Fill };
        var env = await CoreWebView2Environment.CreateAsync(null, Path.Combine(Application.StartupPath, "userdata"), null);
        await webView.EnsureCoreWebView2Async(env);
#if (DEBUG)
        webView.Source = new Uri("http://localhost:3000");
#else
        webView.CoreWebView2.SetVirtualHostNameToFolderMapping("0.0.0.0", Path.Combine(Application.StartupPath, "wwwroot"), CoreWebView2HostResourceAccessKind.Allow);
        webView.Source = new Uri("https://0.0.0.0/index.html");
        webView.CoreWebView2.Settings.AreDevToolsEnabled = false;
        webView.CoreWebView2.Settings.IsStatusBarEnabled = false;
#endif
        webView.CoreWebView2.DocumentTitleChanged += (sender, e) => Text = webView.CoreWebView2.DocumentTitle;
        Controls.Add(webView);
    }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Wraper());
    }
}
