using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK02Duplicated_Code
{
    class Duplicated_Code
    {
            public void LogError(string message, DateTime timestamp)
        {
            string formattedMessage = FormatLogMessage("ERROR",message, timestamp);
            Console.WriteLine(formattedMessage);
        }

        public void LogWarning(string message, DateTime timestamp)
        {
            
            string formattedMessage = FormatLogMessage("WARNING", message, timestamp);
            Console.WriteLine(formattedMessage);
        }
        private string FormatLogMessage(string logLevel, string message, DateTime timestamp)
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            return $"{logLevel}: [{formattedTimestamp}] {message}";
        }
    }
}
