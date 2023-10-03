using System.Reflection.PortableExecutable;

namespace Assignment_ConsoleApp.Services;

internal class FileService
{
    public void SaveToFile(string filePath, string contentAsJson)
    {
        using StreamWriter writer = new StreamWriter(filePath);
        writer.Write(contentAsJson);
    }

    public string ReadFromFile(string filePath)
    {
        try 
        {
            using StreamReader reader = new StreamReader(filePath);
            return reader.ReadToEnd();
        } catch (Exception) 
        { 
            Console.WriteLine("File does not exist");
            return null!;
        } 
        
        
    }
}