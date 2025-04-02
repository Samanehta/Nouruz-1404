internal class Program
{
    private static void Main(string[] args)
    {
        int y, m, d, r, r1, r2;
        Console.WriteLine("please enter years of birthday : ");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter month of birthday : ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter day of birthday : ");
        d = int.Parse(Console.ReadLine());
        r1 = (1404 - y - 1) * 365;
        if (m <= 6)
            r2 = 365 - ((m - 1) * 31 + d);
        else
            r2 = 365 - (186 + (m - 7) * 30 + d);
        r = r1 + r2;
        y = r / 365;
        m = (r % 365) / 30;
        d = ((r % 365) % 30);
        Console.WriteLine(y + " years and " + m + " month and " + d + " deys");
        Console.ReadKey();
    }
}