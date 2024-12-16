namespace Pead.LoggerClasses
{
    internal class FileLogger : ILogger
    {
        public void Log(string action, string message)
            => Console.WriteLine($"File: {action}: {{{message}}}");

        public void LogWithDate(string action, string message)
            => Console.WriteLine($"File: [{System.DateTime.UtcNow}] {action}: {{{message}}}");
    }
}