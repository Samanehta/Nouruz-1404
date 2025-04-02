internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("please enter number 1 : ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter number 2 : ");
        b = int.Parse(Console.ReadLine());
        for (int i = a + 1; i <= b - 1; i++)
            if (i % 5 == 0)
                Console.WriteLine("javab : " + i);
        Console.ReadKey();
    }
}