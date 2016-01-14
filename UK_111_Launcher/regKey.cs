using Microsoft.Win32;

    class regKeys
    {
        public static string appPath(string subKey, string pathVal)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(subKey);
            string installpath = null;
            if(regKey != null)
            {
                installpath = regKey.GetValue(pathVal).ToString();
            }

            return installpath;
        }
    }
