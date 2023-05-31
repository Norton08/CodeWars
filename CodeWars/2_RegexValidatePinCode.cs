
public class RegexValidatePinCode
{
    public static void RunTests()
    {
        Console.WriteLine(ValidatePin("1234"));
        Console.WriteLine(ValidatePin("12345"));
        Console.WriteLine(ValidatePin("a234"));
    }

    public static bool ValidatePin(string pin)
    {
        return pin.All(n => char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
    }
}
