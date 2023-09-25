namespace _04_DataLogging.Interfaces;

internal interface IDataLogger
{
    void Run();
    void LogMessage(string message);
    IEnumerable<string> Messages();  
}