public class ConsoleLog : ILog
{
    public void Log(string message) => Console.WriteLine(message);
}
