public class StartUp
{
    private readonly IWorker worker;
    private readonly ILog log;

    public StartUp(IWorker worker, ILog log)
    {
        this.worker = worker;
        this.log = log;
    }

    public void Start()
    {
        log.Log("Start");
        worker.DoWork(() => Console.WriteLine("App has started"));
        log.Log("End");
    }
}
