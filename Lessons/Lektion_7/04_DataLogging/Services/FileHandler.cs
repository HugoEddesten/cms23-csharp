using _04_DataLogging.Interfaces;
using System.Linq.Expressions;

namespace _04_DataLogging.Services;

public class FileHandler : IFileHandler
{
    public IEnumerable<string> ReadFromFile(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
                return File.ReadAllLines(filePath);
        }
        catch { }
        return null!;
    } 

    public void SaveToFile(string filePath, string content) 
    {
        
    }
}
