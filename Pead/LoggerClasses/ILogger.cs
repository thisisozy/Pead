namespace Pead.LoggerClasses
{
    public interface ILogger
    {
        void Log(string action, string message);
        void LogWithDate(string action, string message);
    }
}