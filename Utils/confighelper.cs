using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DXApplication4
{
    class confighelper
    {
        private static string readAppSettings_con()
        {

            return System.Configuration.ConfigurationManager.AppSettings["con"].ToString();
        }
        public static string connStr = secret.Decrypt(readAppSettings_con(), "cptbtptp");

        private static string readAppSettings_bbh()
        {
            return System.Configuration.ConfigurationManager.AppSettings["bbh"].ToString();
        }
        public static string bbh = readAppSettings_bbh();
        private static string readAppSettings_lwyz()
        {
            return System.Configuration.ConfigurationManager.AppSettings["bbh"].ToString();
        }
        public static string lwyz = readAppSettings_lwyz();
    }
}
