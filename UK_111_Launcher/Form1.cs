using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\arma2oa.exe", "-mod=@DayZOverwatch;@DayZ_Epoch; -skipintro -noSplash -connect=151.80.33.151 -port=2302");
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

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\arma2oa.exe", "-mod=@DayZOverwatch;@DayZOrigins;@DayZ_Epoch; -skipintro -noSplash -connect=151.80.33.151 -port=4302");
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

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\arma2oa.exe", "-mod=@DayZOverwatch;@DayZ_Epoch; -skipintro -noSplash -connect=151.80.33.151 -port=3302");
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/13245986"); // Sukkaed
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/11501618"); // Sen
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/6043327"); // QCube
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/12568683"); // Storm
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/13303500"); // Daedalus
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/495463"); // Chimpa
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/3541710"); // Delta
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/13400809"); // almighty
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/13342505"); // inf
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/9562369"); // Joseph
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/12976258"); // BaltazaR
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/1491356"); // Doggers
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/11086313"); // Jason
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/3252733"); // Ked
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/169852"); // Semps
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/14689004"); // pkefal
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/10571598"); // Xuqi
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uk111.uk/profile/15067002"); // Lilly
        }
        
        // Set Arma 2 Directory
        private void nsButton9_Click(object sender, EventArgs e)
        {
            A2Directory a2dir = new A2Directory();
            a2dir.Show();
        }

        // Set Arma 3 Directory
        private void nsButton10_Click(object sender, EventArgs e)
        {
            A3Directory a3dir = new A3Directory();
            a3dir.Show();
        }

        static void CopyDirectory(DirectoryInfo source, DirectoryInfo destination)
        {
            if (!destination.Exists)
            {
                destination.Create();
            }

            // Copy all files.
            FileInfo[] files = source.GetFiles();
            foreach (FileInfo file in files)
            {
                file.CopyTo(Path.Combine(destination.FullName,
                    file.Name));
            }

            // Process subdirectories.
            DirectoryInfo[] dirs = source.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                // Get destination directory.
                string destinationDir = Path.Combine(destination.FullName, dir.Name);

                // Call CopyDirectory() recursively.
                CopyDirectory(dir, new DirectoryInfo(destinationDir));
            }
        }

        private void nsButton11_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();
                Console.WriteLine("Steam Directory: " + installpath);

                DirectoryInfo sourceDir = new DirectoryInfo(installpath + "\\steamapps\\common\\Arma 2\\Addons\\");
                DirectoryInfo destinationDir = new DirectoryInfo(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\Addons\\");

                CopyDirectory(sourceDir, destinationDir);

                Console.WriteLine("File transfer completed!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();
                Console.WriteLine("Steam Directory: " + installpath);
                // Exile
                if (Directory.Exists(installpath + "\\steamapps\\common\\Arma 3\\@Exile"))
                {
                    nsOnOffBox1.Checked = true;
                    nsButton12.Visible = false;
                } else
                {
                    Console.WriteLine("Failed to find the directory for Exile!");
                }
                // Epoch
                if (Directory.Exists(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\@DayZ_Epoch"))
                {
                    nsOnOffBox2.Checked = true;
                    nsButton13.Visible = false;
                }
                else
                {
                    Console.WriteLine("Failed to find the directory for Epoch!");
                }
                // Overwatch
                if(Directory.Exists(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\@DayzOverwatch"))
                {
                    nsOnOffBox3.Checked = true;
                    nsButton14.Visible = false;
                }
                else
                {
                    Console.WriteLine("Failed to find the directory for Overwatch!");
                }
                // Origins
                if(Directory.Exists(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\@DayzOrigins"))
                {
                    nsOnOffBox4.Checked = true;
                    nsButton15.Visible = false;
                }
                else
                {
                    Console.WriteLine("Failed to find the directory for Origins!");
                }
            }
        }

        // Fix Exile
        private void nsButton12_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 3\\");
            }
        }

        // Fix Epoch
        private void nsButton13_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\");
            }
        }

        // Fix Overwatch
        private void nsButton14_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\");
            }
        }

        // Fix Origins
        private void nsButton15_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string installpath = regKey.GetValue("SteamPath").ToString();

                System.Diagnostics.Process.Start(installpath + "\\steamapps\\common\\Arma 2 Operation Arrowhead\\");
            }
        }
    }
}
