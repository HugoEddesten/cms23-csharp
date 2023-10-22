using System.Diagnostics;

namespace Assigment_maui.Services;

public class FileService
{
// Fields
    private static readonly string _path = @$"{Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..")))))))!}\saves.json";
    
//Methods
    // Takes contentAsJson as input and saves it in a json file
    public static bool SaveToFile(string contentAsJson, string pathForTesting = "defaultPath")
    {
        try
        {
            // if statement for testing. It uses the real path unless you enter a specific one
            if (pathForTesting == "defaultPath")
            {
                using StreamWriter writer = new StreamWriter(_path);
                writer.Write(contentAsJson);
                return true;
            }
            else
            {
                using StreamWriter writer = new StreamWriter(pathForTesting);
                writer.Write(contentAsJson);
                return true;
            }
        } catch (Exception ex) { Debug.WriteLine(ex); return false; }
    }

    // returns all content from the json file if the file exists
    public static string ReadFromFile()
    {
        try
        {
            using StreamReader reader = new StreamReader(_path);
            return reader.ReadToEnd();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return null!;
        }
    }
}
