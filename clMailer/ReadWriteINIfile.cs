using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace caAutoMailing
{
    public class ReadWriteINIfile : IDisposable
    {
        public string path;
        
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string name, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public ReadWriteINIfile(string iniPath)
        {
            path = iniPath;
        }

        public void WriteINI(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, this.path);
        }

        public string ReadINI(string section, string key)
        {
            StringBuilder sb = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", sb, 255, this.path);
            return sb.ToString();
        }

        public void Dispose(){}
    }
}
