namespace Pead.LoggerClasses
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string action, string message)
            => Console.WriteLine($"Console: {action}: {{{message}}}");

        public void LogWithDate(string action, string message)
            => Console.WriteLine($"Console: [{System.DateTime.UtcNow}] {action}: {{{message}}}");
    }
}