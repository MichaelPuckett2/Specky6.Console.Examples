using Specky6;

/* 
 * Note: Specky configurations do not get injected. 
 * The interface is used as a reference for Specky to locate and inject types. 
 */
[SpeckyConfiguration]
interface ISpeckyConfiguration
{
    /* 
     * Method examples
     * Note: the method return type is what gets implemented.
     * Replace ConsoleLog with TraceLog to inject TraceLog.
     * Method names to not matter. 
     */
    [SingletonAs(typeof(ILog))] ConsoleLog GetLog();
    [Singleton] StartUp GetStartUp();

    /* 
     * Property example:
     * Note: the property type is what gets implemented.
     * Property names to not matter. 
     */
    [SingletonAs(typeof(IWorker))] Worker Worker { get; }
}