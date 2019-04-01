using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFETest
{
    public partial class Main : Form
    {
        ChromiumWebBrowser browser;

        public Main()
        {
            InitializeComponent();
            Text = "CefSharp";
            // WindowState = FormWindowState.Maximized;

            var appStartup = Application.StartupPath;


            //string indexPath = string.Format("{0}/WebApp/index.html", appStartup);
            string indexPath = string.Format("{0}/primeng-quickstart-cli-master/index.html", appStartup);
            

            browser = new ChromiumWebBrowser(indexPath)
            {
                Dock = DockStyle.Fill,   
            };

            BrowserSettings browserSettings = new BrowserSettings();



            browserSettings.FileAccessFromFileUrls = CefState.Enabled;
            browserSettings.UniversalAccessFromFileUrls = CefState.Enabled;

         

            browser.BrowserSettings = browserSettings;
            browser.JavascriptObjectRepository.Register("jsWrapper", new JsWrapper(), true);

            //browser.RegisterJsObject("jsWrapper", new JsWrapper());

            Controls.Add(browser);
          

            browser.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
            //browser.LoadingStateChanged += OnLoadingStateChanged;
            //browser.ConsoleMessage += OnBrowserConsoleMessage;
            //browser.StatusMessage += OnBrowserStatusMessage;
            //browser.TitleChanged += OnBrowserTitleChanged;
            //browser.AddressChanged += OnBrowserAddressChanged;



            var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var version = String.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}, Environment: {3}", Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion, bitness);
            //DisplayOutput(version);
        }

        private void OnIsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            browser.ShowDevTools();
        }
    }
}
