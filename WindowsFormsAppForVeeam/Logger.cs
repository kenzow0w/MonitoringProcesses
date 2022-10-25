using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormMonitoring
{
    public static class Logger
    {
        public static void WriteLog(String message)
        {
            string logPath = ConfigurationManager.AppSettings["logPath"];

            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"{DateTime.Now} : {message}");
            }

        }

    }
}
