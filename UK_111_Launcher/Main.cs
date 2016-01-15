using Custom_Functions;
using Microsoft.Win32;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace UK_111_Launcher
{
    public partial class Main : Form
    {
        private static regKey rK = new regKey();

        private String a2path = "\\steamapps\\common\\Arma 2 Operation Arrowhead\\";
        private String a3path = "\\steamapps\\common\\Arma 3\\";
        public static String a2ip = "151.80.33.151";
        public static String a3ip = "94.23.0.19";
        private String steamPath = rK.appPath(@"Software\Valve\Steam", "SteamPath");
        private String a2params = "-mod=@DayZOverwatch;@DayZ_Epoch; -skipintro -noSplash -connect=";
        private String a3params = "-noLauncher -useBE -mod=@Exile -skipintro -noSplash -connect=";

        private ArrayList ports = new ArrayList();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ports.Add("2302");
            ports.Add("3302");
            ports.Add("4302");
            ports.Add("5302");

            if (steamPath != null)
            {
                // Exile
                if (Directory.Exists(steamPath + a3path + "@Exile"))
                {
                    nsOnOffBox1.Checked = true;
                    nsButton12.Visible = false;
                }

                // Epoch
                if (Directory.Exists(steamPath + a2path + "@DayZ_Epoch"))
                {
                    nsOnOffBox2.Checked = true;
                    nsButton13.Visible = false;
                }

                // Overwatch
                if (Directory.Exists(steamPath + a2path + "@DayzOverwatch"))
                {
                    nsOnOffBox3.Checked = true;
                    nsButton14.Visible = false;
                }

                // Origins
                if (Directory.Exists(steamPath + a2path + "@DayzOrigins"))
                {
                    nsOnOffBox4.Checked = true;
                    nsButton15.Visible = false;
                }
            }
        }

        // Chernarus
        private void joinCherno_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(steamPath + a2path + "arma2oa.exe", a2params + a2ip + " -port=" + ports[0]);
        }

        // Taviana
        private void joinTavi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(steamPath + a2path + "arma2oa.exe", a2params + a2ip + "-port=" + ports[4]);
        }

        // Napf
        private void joinNapf_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(steamPath + a2path + "arma2oa.exe", a2params + a2ip + "-port=" + ports[1]);
        }

        // Exile
        private void joinExile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(steamPath + a3path + "arma3launcher.exe", a3params + a3ip + "-port=" + ports[0]);
        }

        // Chernarus IP
        private void chernoIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(a2ip + ":" + ports[0]);
        }

        // Taviana IP
        private void taviIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(a2ip + ":" + ports[2]);
        }

        // Napf IP
        private void napfIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(a2ip + ":" + ports[1]);
        }

        // Exile IP
        private void exileIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(a3ip + ":" + ports[0]);
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

        // Fix Addon Error
        private void nsButton11_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                string steamPath = regKey.GetValue("SteamPath").ToString();

                DirectoryInfo sourceDir = new DirectoryInfo(steamPath + a2path + "Addons\\");
                DirectoryInfo destinationDir = new DirectoryInfo(steamPath + a2path + "Addons\\");

                CopyDirectory(sourceDir, destinationDir);
            }
        }

        // Fix Exile
        private void nsButton12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(steamPath + a3path);
        }

        // Fix Epoch
        private void nsButton13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(steamPath + a2path);
        }

        // Fix Overwatch
        private void nsButton14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(steamPath + a2path);
        }

        // Fix Origins
        private void nsButton15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(steamPath + a2path);
        }
    }
}