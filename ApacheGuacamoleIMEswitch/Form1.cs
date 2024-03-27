using IWshRuntimeLibrary;
using Microsoft.Win32;
using Namotion.Reflection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ApacheGuacamoleIMEswitch
{
    public partial class Form1 : Form
    {
        Boolean bIsDisable = false;
        String strURL = "https://remote.hlmt.com.tw";
        String strRDP = null;
        String strUID = null;
        String strPWD = null;
        String strPORT = "3389";
        Boolean bFirstTime = true;

        private static ContextMenuStrip contextMenuStrip;
        public Form1()
        {
            InitializeComponent();
        }

        /*

        protected override void SetVisibleCore(bool value)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
                value = false;
            }

            base.SetVisibleCore(value);
        }
        */

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

        protected override void OnLoad(EventArgs e)
        {
            string subkey2 = @"Software\\ApacheGuacamoleIMEswitch";
            RegistryKey localKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            if (localKey2.OpenSubKey(subkey2) != null)
            {
                if (localKey2.OpenSubKey(subkey2).GetValue("FirstTime") != null)
                {
                    String value = localKey2.OpenSubKey(subkey2).GetValue("FirstTime").ToString();
                    //MessageBox.Show(value);
                    if (value.Equals("1"))
                    {
                        bFirstTime = true;

                    }
                    else
                    {
                        bFirstTime = false;

                    }

                }

            }


            if (!bFirstTime)
            {
                Visible = false; // Hide form window.
                ShowInTaskbar = false; // Remove from taskbar.
                Opacity = 0;
            }
            else
            {
                if (localKey2.OpenSubKey(subkey2) != null)
                {
                    localKey2.OpenSubKey(subkey2, true).SetValue("FirstTime", "0");
                    bFirstTime = false;
                }

            }


            base.OnLoad(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Rectangle resolutionRect = System.Windows.Forms.Screen.FromControl(this).Bounds;
            if (this.Width >= resolutionRect.Width || this.Height >= resolutionRect.Height)
            {
                this.WindowState = FormWindowState.Maximized;
            }

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

            if (Properties.Settings.Default.RDP != null && !Properties.Settings.Default.RDP.ToString().Trim().Equals(""))
            {
                RDP.Text = Properties.Settings.Default.RDP.ToString();
                strRDP = RDP.Text.ToString();
            }

            if (Properties.Settings.Default.UID != null && !Properties.Settings.Default.UID.ToString().Trim().Equals(""))
            {
                UID.Text = Properties.Settings.Default.UID.ToString();
                strUID = UID.Text.ToString();
            }

            if (Properties.Settings.Default.PWD != null && !Properties.Settings.Default.PWD.ToString().Trim().Equals(""))
            {
                PWD.Text = Properties.Settings.Default.PWD.ToString();
                strPWD = PWD.Text.ToString();
            }

            if (Properties.Settings.Default.PORT != null && !Properties.Settings.Default.PORT.ToString().Trim().Equals(""))
            {
                PORT.Text = Properties.Settings.Default.PORT.ToString();
                strPORT = PORT.Text.ToString();
            }
            else
            {
                PORT.Text = strPORT;
                Properties.Settings.Default.PORT = strPORT;
                Properties.Settings.Default.Save();
            }

            contextMenuStrip = new ContextMenuStrip();

            ToolStripItem stripItem1 = new ToolStripMenuItem("開啟「網頁」遠端連線");
            stripItem1.Image = ApacheGuacamoleIMEswitch.Properties.Resources.Guacamole_icon;
            stripItem1.Click += new EventHandler(MenuItem1);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { stripItem1 });

            ToolStripItem stripItemRDP = new ToolStripMenuItem("開啟「遠端桌面連線」");
            stripItemRDP.Image = ApacheGuacamoleIMEswitch.Properties.Resources.rdp;
            stripItemRDP.Click += new EventHandler(MenuItemRDP);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { stripItemRDP });


            ToolStripItem line = new ToolStripSeparator();
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { line });

            ToolStripMenuItem stripItem0 = new ToolStripMenuItem("「暫停本機左邊Shift鍵」");
            stripItem0.ForeColor = Color.Red;
            stripItem0.Click += new EventHandler(MenuItem0);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { stripItem0 });


            ToolStripItem line2 = new ToolStripSeparator();
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { line2 });

            ToolStripItem stripItem2 = new ToolStripMenuItem("離開本程式");
            stripItem2.Click += new EventHandler(MenuItem3);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { stripItem2 });

            notifyIcon1.ContextMenuStrip = contextMenuStrip;
            restoreLeftShift();
            if (!Properties.Settings.Default.CreateStartupLink)
            {
                WshShell wshShell = new WshShell();
                IWshRuntimeLibrary.IWshShortcut shortcut;
                string startUpFolderPath =
                  Environment.GetFolderPath(Environment.SpecialFolder.Startup);

                // Create the shortcut
                shortcut =
                  (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(
                    startUpFolderPath + "\\" +
                    Application.ProductName + ".lnk");

                shortcut.TargetPath = Application.ExecutablePath;
                shortcut.WorkingDirectory = Application.StartupPath;
                shortcut.Description = "Launch My Application";
                // shortcut.IconLocation = Application.StartupPath + @"\App.ico";
                shortcut.Save();
                Properties.Settings.Default.CreateStartupLink = true;
                Properties.Settings.Default.Save();
            }

        }

        private void MenuItem0(object Sender, EventArgs e)
        {
            switchNotifyLeftShift();

        }

        private void MenuItemRDP(object Sender, EventArgs e)
        {
            if (strRDP == null || strRDP.Length == 0)
            {
                MessageBox.Show("請先設定遠端桌面連線IP");
                Visible = true; // Hide form window.
                ShowInTaskbar = true; // Remove from taskbar.
                Opacity = 100;

                this.Show();

                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
            else
            {
                Process rdcProcess = new Process();
                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
                String strCMDKEYargu = "/generic:\"" + strRDP + "\"";
                if (strUID != null && !strUID.Trim().Equals(""))
                {
                    strCMDKEYargu += " /user:\"" + strUID + "\"";
                    if (strPWD != null && !strPWD.Trim().Equals(""))
                    {
                        strCMDKEYargu += " /pass:\"" + strPWD + "\"";
                    }

                }
                rdcProcess.StartInfo.Arguments = strCMDKEYargu;
                rdcProcess.Start();

                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
                rdcProcess.StartInfo.Arguments = "/v:" + strRDP + ":" + strPORT;
                rdcProcess.Start();
            }
        }

        private void MenuItem1(object Sender, EventArgs e)
        {
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000002");
                var results = ps.Invoke<string>();
                bIsDisable = true;
                notifyIcon1.ContextMenuStrip.Items[3].Text = "「恢復本機左邊Shift鍵」";
                notifyIcon1.ContextMenuStrip.Items[3].ForeColor = Color.Blue;
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
            if (strRDP != null && !strRDP.Trim().Equals(""))
            {
                Process rdcProcess = new Process();
                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
                String strCMDKEYargu = "/delete:\"" + strRDP + "\"";
                rdcProcess.StartInfo.Arguments = strCMDKEYargu;
                rdcProcess.Start();

            }
            if (strUID != null && !strUID.Trim().Equals(""))
            {
                Properties.Settings.Default.PWD = "";
                Properties.Settings.Default.Save();
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
                    notifyIcon1.ContextMenuStrip.Items[3].Text = "「恢復本機左邊Shift鍵」";
                    notifyIcon1.ContextMenuStrip.Items[3].ForeColor = Color.Blue;
                    notifyIcon1.ContextMenuStrip.Update();

                }
                else
                {
                    ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000001");
                    var results = ps.Invoke<string>();
                    bIsDisable = false;
                    notifyIcon1.ContextMenuStrip.Items[3].Text = "「暫停本機左邊Shift鍵」";
                    notifyIcon1.ContextMenuStrip.Items[3].ForeColor = Color.Red;
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
                    notifyIcon1.ContextMenuStrip.Items[3].Text = "「暫停本機左邊Shift鍵」";
                    notifyIcon1.ContextMenuStrip.Items[3].ForeColor = Color.Red;
                    notifyIcon1.ContextMenuStrip.Update();
                }
                else
                {
                    notifyIcon1.ContextMenuStrip.Items[3].Text = "「恢復本機左邊Shift鍵」";
                    notifyIcon1.ContextMenuStrip.Items[3].ForeColor = Color.Blue;
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
            Visible = true; // Hide form window.
            ShowInTaskbar = true; // Remove from taskbar.
            Opacity = 100;

            this.Show();

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            /*

            if (!bFirstTime)
            {
                this.Hide();
                string subkey2 = @"Software\\ApacheGuacamoleIMEswitch";
                RegistryKey localKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                if (localKey2.OpenSubKey(subkey2) != null)
                {
                    localKey2.OpenSubKey(subkey2,true).SetValue("FirstTime", "0");
                    bFirstTime = false;
                }
            }
            */

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            strRDP = RDP.Text.ToString();
            Properties.Settings.Default.RDP = RDP.Text.ToString();
            Properties.Settings.Default.Save();

            strPORT = PORT.Text.ToString();
            Properties.Settings.Default.PORT = PORT.Text.ToString();
            Properties.Settings.Default.Save();

            if (UID != null)
            {
                strUID = UID.Text.ToString();
                Properties.Settings.Default.UID = UID.Text.ToString();
                Properties.Settings.Default.Save();

            }

            if (PWD != null)
            {
                strPWD = PWD.Text.ToString();
                Properties.Settings.Default.PWD = PWD.Text.ToString();
                Properties.Settings.Default.Save();

            }


        }

        private void RDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            strRDP = RDP.Text.ToString();
            Properties.Settings.Default.RDP = RDP.Text.ToString();
            Properties.Settings.Default.Save();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}