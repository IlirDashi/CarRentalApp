using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Logic
{
    public static class LogsManager
    {
        private static string _logsDirectory;
        static LogsManager()
        {
            _logsDirectory = Assembly.GetExecutingAssembly().Location;
            _logsDirectory = Path.GetDirectoryName(_logsDirectory);
            _logsDirectory = Path.Combine(_logsDirectory, "Logs");
            if (!Directory.Exists(_logsDirectory))
                Directory.CreateDirectory(_logsDirectory);
        }
        static object _locker = new object();

        public static void LogError(Exception ex)
        {
            lock (_locker)
            {
            }
        }
    }
}
