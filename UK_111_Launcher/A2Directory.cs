using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UK_111_Launcher
{
    public partial class A2Directory : Form
    {
        public A2Directory()
        {
            InitializeComponent();
        }

        private void nsButton1_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string steamDir = regKey.GetValue("SteamPath").ToString();
                Console.WriteLine(steamDir);

                string CMDDirText;
                CMDDirText = nsTextBox1.Text;

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + "mklink /J " + "\"" + steamDir + "/steamapps/common/Arma 2 Operation Arrowhead" + "\"" + " " + "\"" + CMDDirText + "\"";
                process.StartInfo = startInfo;
                process.Start();

                this.Close();
            }
        }
    }
}
