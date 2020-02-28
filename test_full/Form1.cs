using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace test_full
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            
            
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser2.ScriptErrorsSuppressed = true;
            webBrowser3.ScriptErrorsSuppressed = true;
            webBrowser4.ScriptErrorsSuppressed = true;

            webBrowser1.Refresh();
            webBrowser2.Refresh();
            webBrowser3.Refresh();
            webBrowser4.Refresh();

            /* this is the best I could get
             * try to inspect the page and see what is going on
            webBrowser1.Document.GetElementById("usernameInput").SetAttribute("value", user.username);
            webBrowser1.Document.GetElementById("passwordInput").SetAttribute("value", user.password);
            */

            //SendKeys.Send("{ENTER}");

            //if (MessageBox.Equals("security alert")) ;

            //System.Windows.Forms.SendKeys.Send("Y%");

        }

        /*bool is_sec_page = false;

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!is_sec_page)
            {
                HtmlDocument doc = webBrowser2.Document;
                HtmlElement username = doc.GetElementById("UserName");
                HtmlElement password = doc.GetElementById("Password");
                HtmlElement submit = doc.GetElementById("submit");
                username.SetAttribute("value", "viewer");
                password.SetAttribute("value", "viewe123");
                submit.InvokeMember("click");
                is_sec_page = true;
            }
            else
            {
                //intract with sec page elements with theire ids and so on
            }
        }*/


        /*private void btnTestNoCredentialsDialog_Click(Object sender, EventArgs e)
        {
            // (Fill in the blanks with a Url for a page of choice where 
            // credentials would normally have to be entered manually)
            String sUrl = "";

            if (String.IsNullOrEmpty(sUrl))
            {
                MessageBox.Show(this, "Please provide a Url in the Source Code",
                    "btnTestNoCredentialsDialog_Click(): Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            navigateTo(sUrl);
        }

        private void btnTestNoSecurityAlertDialog_Click(Object sender, EventArgs e)
        {
            // (Fill in the blanks with a Url for a page of choice 
            // where an invalid SSL dialog would normally show)
            String sUrl = "";

            if (String.IsNullOrEmpty(sUrl))
            {
                MessageBox.Show(this, "Please provide a Url in the Source Code",
                    "btnTestNoSecurityAlertDialog_Click(): No URL Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            navigateTo(sUrl);
        }

        private Boolean WindowsInterop_SecurityAlertDialogWillBeShown(Boolean blnIsSSLDialog)
        {
            // Return true to ignore and not show the 
            // "Security Alert" dialog to the user
            return true;
        }

        private Boolean WindowsInterop_ConnectToDialogWillBeShown(ref String sUsername, ref String sPassword)
        {
            // (Fill in the blanks in order to be able 
            // to return the appropriate Username and Password)
            sUsername = "";
            sPassword = "";

            // Return true to auto populate credentials and not 
            // show the "Connect To ..." dialog to the user
            return true;
        }

        private void webBrowser1_DocumentCompleted(Object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Enable the 2 buttons on the form
            this.btnTestNoCredentialsDialog.Enabled = true;
            this.btnTestNoSecurityAlertDialog.Enabled = true;

            this.Cursor = Cursors.Default;
        }



        #region << Private Parts >>

        private void navigateTo(String sUrl)
        {
            this.Cursor = Cursors.WaitCursor;

            this.btnTestNoCredentialsDialog.Enabled = false;
            this.btnTestNoSecurityAlertDialog.Enabled = false;

            this.webBrowser1.Navigate(sUrl);
        }*/


    }

}


