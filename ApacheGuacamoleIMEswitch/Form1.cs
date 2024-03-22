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
        Boolean bIsDisable = false;
        String strURL = "https://guacamole.apache.org/";

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
                button2.Text = "按此「啟用本機左邊Shift鍵」";
                button2.ForeColor = Color.Blue;
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

        private void Form1_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.URL is null || Properties.Settings.Default.URL.Trim().Equals(""))
            {
                Properties.Settings.Default.URL = strURL;
                Properties.Settings.Default.Save();
                URL.Text = strURL;
            }
            else URL.Text = Properties.Settings.Default.URL.ToString();


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


        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var ps = PowerShell.Create())
            {
                if (!bIsDisable)
                {
                    ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000002");
                    var results = ps.Invoke<string>();
                    bIsDisable = true;
                    button2.Text = "按此「啟用本機左邊Shift鍵」";
                    button2.ForeColor = Color.Blue;
                }
                else
                {
                    ps.AddCommand("Set-ItemProperty").AddParameter("Path", "HKCU:\\Software\\Microsoft\\IME\\15.0\\IMETC").AddParameter("Name", "Left Shift Usage").AddParameter("Value", "0x00000001");
                    var results = ps.Invoke<string>();
                    bIsDisable = false;
                    button2.Text = "按此「停用本機左邊Shift鍵」";
                    button2.ForeColor = Color.Red;
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
    }
}