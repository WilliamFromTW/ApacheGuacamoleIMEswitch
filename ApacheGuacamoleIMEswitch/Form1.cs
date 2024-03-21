using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Xml.Linq;

namespace ApacheGuacamoleIMEswitch
{
    public partial class Form1 : Form
    {
        private string strURL;

        public Form1()
        {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            /* working
            strURL = "https://remote.hlmt.com.tw";
            System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", strURL + " --new-window");
            */
            /*
            PowerShell ps = PowerShell.Create();
            ps.AddCommand("Get-Process").AddParameter("Name", "PowerShell");
            ps.AddStatement().AddCommand("powershell").AddArgument("-Command Set-ItemProperty -Path 'HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC' -Name 'Left Shift Usage' -Value 0x00000002\r\n");
            ps.Invoke();

            PowerShell ps2 = PowerShell.Create();
            //ps2.AddCommand("Get-Process").AddParameter("Name", "PowerShell");
            ps2.AddCommand("powershell").AddArgument("-NoProfile -Command Start-Process -passthru xe 'remote.hlmt.com.tw'");
            ps2.Invoke();
            */
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000002");
                var results = ps.Invoke<string>();
                Console.WriteLine(results.FirstOrDefault());
            }
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Start-Process").AddArgument("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe").AddArgument(URL.Text.ToString());
                var results = ps.Invoke<string>();
                Console.WriteLine(results.FirstOrDefault());

            }
            buttonGuacamole.Text = "請關閉所有chrome瀏覽器";
            buttonGuacamole.ForeColor = Color.Red;

            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("powershell").AddArgument("while ((get-process -name chrome).count -ne 0){}");
                var results = ps.Invoke<string>();
                Console.WriteLine(results.FirstOrDefault());
            }

            this.Focus();
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000001");
                var results = ps.Invoke<string>();
                Console.WriteLine(results.FirstOrDefault());
            }
            buttonGuacamole.Text = "開啟酪梨醬(遠端連線)";
            buttonGuacamole.ForeColor = Color.Blue;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000002");
                var results = ps.Invoke<string>();
                Console.WriteLine(results.FirstOrDefault());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000001");
                var results = ps.Invoke<string>();
                Console.WriteLine(results.FirstOrDefault());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.URL is null)
            {
                Properties.Settings.Default.URL = "https://www.google.com";
                Properties.Settings.Default.Save();
            }
            buttonGuacamole.Text = "開啟酪梨醬(遠端連線)";
            buttonGuacamole.ForeColor = Color.Blue;


        }

        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.URL = URL.Text.ToString();
            Properties.Settings.Default.Save();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}