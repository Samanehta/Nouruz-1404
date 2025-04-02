internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Please enter a number : ");
        num = int.Parse(Console.ReadLine());
        if (num < 10)
            Console.WriteLine("result : " + num);
        else if (num < 100)
            Console.WriteLine("result : " + (num / 10));
        else if (num < 1000)
            Console.WriteLine("result : " + (num / 100));
        else if (num < 10000)
            Console.WriteLine("result : " + (num / 1000));
        else if (num < 100000)
            Console.WriteLine("result : " + (num / 10000));
        else
            Console.WriteLine("Max value 99999");
        Console.ReadKey();
    }
}