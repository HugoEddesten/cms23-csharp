using System.Text.RegularExpressions;

namespace _02_Structs.Structs.Domain_Driven_Design;

public struct Password
{
    private readonly string value;

    public Password(string value)
    {
        if (!Regex.IsMatch(value, @"^(?=.*[az])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}"))
            throw new ArgumentException("Invalid password");
    }
}
