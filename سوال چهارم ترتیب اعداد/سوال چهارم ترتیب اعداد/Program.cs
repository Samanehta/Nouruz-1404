internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c, d;
        Console.WriteLine("please enter number 1 : ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter number 2 : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter number 3 : ");
        c = int.Parse(Console.ReadLine());
        if (a > b)
        {
            d = a;
            a = b;
            b = d;
        }
        if (a > c)
        {
            d = a;
            a = c;
            c = d;
        }
        if (b > c)
        {
            d = a;
            a = c;
            c = d;
        }
        Console.WriteLine(c + ">" + b + ">" + a + "");
        Console.ReadLine();
    }
}