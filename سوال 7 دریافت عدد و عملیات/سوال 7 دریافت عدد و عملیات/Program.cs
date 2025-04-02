internal class Program
{
    private static void Main(string[] args)
    {
        double a, b;
        char c;
        Console.WriteLine("ple enter number 1 : ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("ple enter number 2 : ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your operation : ");
        c = char.Parse(Console.ReadLine());
        if (c == '*')
            Console.WriteLine("result = " + a * b);
        else if (c == '/')
            Console.WriteLine("result = " + a / b);
        else if (c == '+')
            Console.WriteLine("result = " + (a + b));
        else if (c == '-')
            Console.WriteLine("result = " + (a - b));
        Console.ReadKey();
    }
}