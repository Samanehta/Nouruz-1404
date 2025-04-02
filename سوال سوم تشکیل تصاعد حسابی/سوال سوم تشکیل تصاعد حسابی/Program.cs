internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, num3, sum1, sum2;
        Console.Write("Please enter the first number : ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number : ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter the third number : ");
        num3 = int.Parse(Console.ReadLine());
        sum1 = num1 - num2;
        sum2 = num2 - num3;
        if (sum1 == sum2)
            Console.WriteLine("tasaod hesabi ast");
        else
            Console.WriteLine("tasaod hesabi nist");
        Console.ReadKey();
    }
}