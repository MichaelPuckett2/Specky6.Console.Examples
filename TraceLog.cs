using System.Diagnostics;

public class TraceLog : ILog
{
    public void Log(string message) => Trace.WriteLine(message);
}
