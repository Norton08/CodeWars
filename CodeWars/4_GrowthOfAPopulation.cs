public class GrowthOfAPopulation
{
    public static void RunTests()
    {
        Console.WriteLine(NbYear(1000, 2, 50, 1200));
        Console.WriteLine(NbYear(1500, 5, 100, 5000));
        Console.WriteLine(NbYear(1500000, 2.5, 10000, 2000000));
        Console.WriteLine(NbYear(1500000, 0.25, 1000, 2000000));
    }

    public static int NbYear(int p0, double percent, int aug, int p)
    {
        int pAcress = p0;
        int year;

        for (year = 0; pAcress < p; year++) {
            pAcress += (int)(pAcress * (percent / 100) + aug);
        }

        return year;
    }
}
