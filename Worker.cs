public class Worker : IWorker
{
    public void DoWork(Action action) => action.Invoke();
}
