﻿namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions
{
    internal class DuplicatedCode
    {
        public void LogError(string message, DateTime timestamp)
        {
            string formattedMessage = FormatLogMessage("ERROR", message, timestamp);
            Console.WriteLine(formattedMessage);
        }

        public void LogWarning(string message, DateTime timestamp)
        {
            string formattedMessage = FormatLogMessage("WARNING", message, timestamp);
            Console.WriteLine(formattedMessage);
        }

        private string FormatLogMessage(string level, string message, DateTime timestamp)
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            return $"{level}: [{formattedTimestamp}] {message}";
        }
    }
}
