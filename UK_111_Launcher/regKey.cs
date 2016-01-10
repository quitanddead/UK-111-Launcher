using Microsoft.Win32;

    class regKey
    {
        public static string steamPath()
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");
            string installpath = null;
            if(regKey != null)
            {
                installpath = regKey.GetValue("SteamPath").ToString();
            }

            return installpath;
        }
    }
