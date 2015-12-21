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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Chernarus
        private void nsButton1_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();
                Console.WriteLine("Steam Directory: " + installpath);
                Console.WriteLine("Launching Game!");

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\arma2oa.exe", "-mod=@DayZ_Epoch;@DayZOverwatch; -skipintro -noSplash -connect=151.80.33.151 -port=2302");
            }
        }

        // Taviana
        private void nsButton3_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();
                Console.WriteLine("Steam Directory: " + installpath);
                Console.WriteLine("Launching Game!");

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\arma2oa.exe", "-mod=@DayZ_Epoch;@DayZOverwatch;@DayZOrigins; -skipintro -noSplash -connect=151.80.33.151 -port=4302");
            }
        }

        // Napf
        private void nsButton4_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();
                Console.WriteLine("Steam Directory: " + installpath);
                Console.WriteLine("Launching Game!");

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\arma2oa.exe", "-mod=@DayZ_Epoch;@DayZOverwatch; -skipintro -noSplash -connect=151.80.33.151 -port=3302");
            }
        }

        // Exile
        private void nsButton5_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();
                Console.WriteLine("Steam Directory: " + installpath);
                Console.WriteLine("Launching Game!");

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 3\\arma3launcher.exe", "-noLauncher -useBE -mod=@Exile -skipintro -noSplash -connect=151.80.33.151 -port=5302");
            }
        }

        // Chernarus IP
        private void nsButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("151.80.33.151:2302");
        }

        // Taviana IP
        private void nsButton6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("151.80.33.151:4302");
        }

        // Napf IP
        private void nsButton7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("151.80.33.151:3302");
        }

        // Exile IP
        private void nsButton8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("94.23.0.19:2302");
        }
    }
}
