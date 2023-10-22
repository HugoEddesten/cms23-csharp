using System.Reflection.PortableExecutable;

namespace Assignment_ConsoleApp.Services;

internal class FileService
{
    private static readonly string _path = $"{Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..")))))!}\\saves.json";

    public static void SaveToFile(string contentAsJson)
    {
        using StreamWriter writer = new StreamWriter(_path);
        writer.Write(contentAsJson);
    }

    public static string ReadFromFile()
    {
        try 
        {
            using StreamReader reader = new StreamReader(_path);
            return reader.ReadToEnd();
        } catch (Exception) 
        { 
            Console.WriteLine("File does not exist");
            Console.ReadKey();
            return null!;
        } 
        
        
    }
}