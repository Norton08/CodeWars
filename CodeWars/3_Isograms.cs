public class Isograms
{
    public static void RunTests()
    {
        Console.WriteLine(IsIsogram("Dermatoglyphics"));
        Console.WriteLine(IsIsogram("moose"));
        Console.WriteLine(IsIsogram("aba"));
    }

    public static bool IsIsogram(string str)
    {
        foreach (var s in str.ToCharArray())
        {
            int i = 0, j = str.IndexOf(s);

            while(i <= str.Length - 1)
            {
                if (char.ToLower(s) == char.ToLower(str[i]) && i != j)
                    return false;
                i++;
            }
            j++;
        }
        return true;
    }
}