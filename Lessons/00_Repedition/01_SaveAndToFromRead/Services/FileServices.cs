namespace _01_SaveAndToFromRead.Services;

internal class FileServices
{

    private static readonly string filePath = @"C:\Users\hugoe\Desktop\customers.json";

    public static void SaveToFile(string contentAsJson)
    {
        using var sw = new StreamWriter(filePath);
        sw.Write(contentAsJson);
    }
    public static string ReadFromFile() 
    {
        if (File.Exists(filePath))
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }
        return null!;
    }   



}
