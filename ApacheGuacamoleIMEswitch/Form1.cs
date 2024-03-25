using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ApacheGuacamoleIMEswitch
{
    public partial class Form1 : Form
    {
        Boolean bIsDisable = false;
        String strURL = "https://guacamole.apache.org/";

        private static ContextMenuStrip contextMenuStrip;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000002");
                var results = ps.Invoke<string>();
                bIsDisable = true;
            }
            /*
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Start-Process").AddArgument("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe").AddArgument(URL.Text.ToString());
                var results = ps.Invoke<string>();
                Console.WriteLine(results.FirstOrDefault());

            }
            */
            Process.Start(new ProcessStartInfo(strURL) { UseShellExecute = true });


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized
            //hide it from the task bar
            //and show the system tray icon (represented by the NotifyIcon control)
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            if (Properties.Settings.Default.URL is null || Properties.Settings.Default.URL.ToString().Trim().Equals(""))
            {
                Properties.Settings.Default.URL = strURL;
                Properties.Settings.Default.Save();
                URL.Text = strURL;
            }
            else
            {
                URL.Text = Properties.Settings.Default.URL.ToString();
                strURL = URL.Text.ToString();
            }

            contextMenuStrip = new ContextMenuStrip();
            ToolStripItem stripItem0 = new ToolStripMenuItem("按此「暫停本機左邊Shift鍵」");
            stripItem0.ForeColor = Color.Red;
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { stripItem0 });
            stripItem0.Click += new EventHandler(MenuItem0);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { stripItem0 });

            ToolStripItem stripItem1 = new ToolStripMenuItem("按此「開啟酪梨醬(遠端連線)」");
            stripItem1.Click += new EventHandler(MenuItem1);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { stripItem1 });

            ToolStripItem line = new ToolStripSeparator();
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { line });

            ToolStripItem stripItem2 = new ToolStripMenuItem("離開本程式");
            stripItem2.Click += new EventHandler(MenuItem3);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { stripItem2 });

            notifyIcon1.ContextMenuStrip = contextMenuStrip;
            restoreLeftShift();

        }

        private void MenuItem0(object Sender, EventArgs e)
        {
            switchNotifyLeftShift();

        }


        private void MenuItem1(object Sender, EventArgs e)
        {
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000002");
                var results = ps.Invoke<string>();
                bIsDisable = true;
                notifyIcon1.ContextMenuStrip.Items[0].Text = "按此「恢復本機左邊Shift鍵」";
                notifyIcon1.ContextMenuStrip.Items[0].ForeColor = Color.Blue;
                notifyIcon1.ContextMenuStrip.Update();

            }
            Process.Start(new ProcessStartInfo(strURL) { UseShellExecute = true });
        }

        private void MenuItem3(object Sender, EventArgs e)

        {
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000001");
                var results = ps.Invoke<string>();
            }
            this.Close();
        }


        private void save_Click(object sender, EventArgs e)
        {
            strURL = URL.Text.ToString();
            Properties.Settings.Default.URL = URL.Text.ToString();
            Properties.Settings.Default.Save();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void switchNotifyLeftShift()
        {

            using (var ps = PowerShell.Create())
            {
                if (!bIsDisable)
                {
                    ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000002");
                    var results = ps.Invoke<string>();
                    bIsDisable = true;
                    notifyIcon1.ContextMenuStrip.Items[0].Text = "按此「恢復本機左邊Shift鍵」";
                    notifyIcon1.ContextMenuStrip.Items[0].ForeColor = Color.Blue;
                    notifyIcon1.ContextMenuStrip.Update();

                }
                else
                {
                    ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000001");
                    var results = ps.Invoke<string>();
                    bIsDisable = false;
                    notifyIcon1.ContextMenuStrip.Items[0].Text = "按此「暫停本機左邊Shift鍵」";
                    notifyIcon1.ContextMenuStrip.Items[0].ForeColor = Color.Red;
                    notifyIcon1.ContextMenuStrip.Update();

                }
            }
        }

        private void restoreLeftShift()
        {
            string subkey = @"Software\\Microsoft\\IME\\15.0\\IMETC";
            RegistryKey localKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            if (localKey.OpenSubKey(subkey) != null)
            {
                if (localKey.OpenSubKey(subkey).GetValue("Left Shift Usage") != null)
                {
                    String value = localKey.OpenSubKey(subkey).GetValue("Left Shift Usage").ToString();

                    if (value.Equals("0x00000001"))
                    {
                        bIsDisable = false;

                    }
                    else
                    {
                        bIsDisable = true;

                    }

                }

            }
            using (var ps = PowerShell.Create())
            {
                if (!bIsDisable)
                {
                  notifyIcon1.ContextMenuStrip.Items[0].Text = "按此「暫停本機左邊Shift鍵」";
                  notifyIcon1.ContextMenuStrip.Items[0].ForeColor = Color.Red;
                    notifyIcon1.ContextMenuStrip.Update();
                }
                else
                {
                    notifyIcon1.ContextMenuStrip.Items[0].Text = "按此「恢復本機左邊Shift鍵」";
                    notifyIcon1.ContextMenuStrip.Items[0].ForeColor = Color.Blue;
                    notifyIcon1.ContextMenuStrip.Update();
                }
            }

        }


        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000001");
                var results = ps.Invoke<string>();
            }

        }

        private void URL_TextChanged(object sender, EventArgs e)
        {

        }

        private void URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            strURL = URL.Text.ToString();
            Properties.Settings.Default.URL = URL.Text.ToString();
            Properties.Settings.Default.Save();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
            else//left or middle click
            {
                //do something here
            }
        }
    }
}