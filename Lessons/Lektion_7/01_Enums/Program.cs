using _01_Enums.Services;


var urlCheckerService = new UrlCheckerService();
await urlCheckerService.Run("https://google.com");
