internal class Program
{
    private static void Main(string[] args)
    {
        int y1, m1, d1, y2, m2, d2, r, r1, r2, r3;
        Console.WriteLine("please enter first year birth : ");
        y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter first month birth : ");
        m1 = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter first day birth : ");
        d1 = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter second year birth : ");
        y2 = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter second month birth : ");
        m2 = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter second day birth : ");
        d2 = int.Parse(Console.ReadLine());
        if (m1 <= 6)
        {
            r1 = 365 - (m1 - 1) * 31 + d1;
        }
        else
        {
            r1 = 365 - (186 + ((m1 - 7) * 30) + d1);
        }
        if (m2 <= 6)
        {
            r2 = 365 - (m2 - 1) * 31 + d2;

        }
        else
        {
            r2 = 365 - (186 + ((m2 - 7) * 30) + d2);

        }
        r3 = (y2 - y1 - 1) * 365;
        r = r1 + r2 + r3;
        Console.WriteLine("" + r);
        Console.ReadKey();
    }
}