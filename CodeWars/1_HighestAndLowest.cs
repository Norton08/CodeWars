public static class HighestAndLowest
{
    public static void Run()
    {
        Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4")); 
        Console.WriteLine(HighAndLow("1 2 3"));
    }

    public static string HighAndLow(string numbers)
    {
        var parsed = numbers.Split().Select(int.Parse);
        return parsed.Max() + " " + parsed.Min();
    }
}