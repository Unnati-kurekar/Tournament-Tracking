using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections = new List<IDataConnection>();

        public static void initialiseConnector(bool database)
        {
            if (database)
            {
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
        }

        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
