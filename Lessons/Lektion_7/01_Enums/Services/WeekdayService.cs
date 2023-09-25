using _01_Enums.Enums;

namespace _01_Enums.Services;

internal class WeekdayService
{
    public void Run()
    {
        var weekday = Weekdays.Wednesday;

        switch (weekday)
        {
            case Weekdays.Monday:
                Console.WriteLine("Det är Måndag idag.");
                break;
            case Weekdays.Tuesday:
                Console.WriteLine("Det är Tisdag idag.");
                break;
            case Weekdays.Wednesday:
                Console.WriteLine("Det är Onsdag idag, dvs lill-lördag.");
                break;
            case Weekdays.Thursday:
                Console.WriteLine("Det är Torsdag idag.");
                break;
            case Weekdays.Friday:
                Console.WriteLine("Det är Fredag idag.");
                break;
            case Weekdays.Saturday:
                Console.WriteLine("Det är Lördag idag.");
                break;
            case Weekdays.Sunday:
                Console.WriteLine("Det är Söndag idag.");
                break;
        }
    }
}
