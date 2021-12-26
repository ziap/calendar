using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

class Wraper : System.Windows.Forms.Form
{
    Wraper()
    {
        // Initial form configuration
        Width = 450;
        Height = 800;
        Text = "Loading...";
        StartPosition = FormStartPosition.CenterScreen;
        InitWebView();
    }
    
    async void InitWebView() {
        var webView = new WebView2() {Dock = DockStyle.Fill};
        await webView.EnsureCoreWebView2Async();
        #if(DEBUG)
            webView.Source = new Uri("http://localhost:3000");
        #else
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping("0.0.0.0", Application.StartupPath + "wwwroot", CoreWebView2HostResourceAccessKind.Allow);
            webView.Source = new Uri("https://0.0.0.0/index.html");
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
