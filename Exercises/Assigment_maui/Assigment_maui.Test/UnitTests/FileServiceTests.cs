using Assigment_maui.Services;


namespace Assigment_maui.Test.UnitTests;

public class FileServiceTests
{
    [Fact]
    public void SaveToFile_Should_ReturnFalse_IfFileDoesNotExist()
    {
        // Arrange
        FileService fileService = new FileService();
        string fakePath = @"c:/fakepath/fakefile.txt";
        string content = "testContent";

        // Act
        bool result = FileService.SaveToFile(content, fakePath);

        // Assert
        Assert.False(result);
    }
}
