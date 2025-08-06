internal class Program
{
    private static void Main(string[] args)
    {

        /*Console.Write("Введите число = ");
        double @base = double.Parse(Console.ReadLine());

        Console.Write("Введите степень = ");
        double pow = double.Parse(Console.ReadLine());

        double result = Power(@base, pow);
        Console.WriteLine($"Результат возведение в степень = {result}");*/

        Console.Write("Введите число = ");
        int number = int.Parse(Console.ReadLine());
        int result = IsPrime(number);
        
    }

    static double Power(double @base, double pow)
    {
        double a = @base;
        for (int i = 1; i < pow; i++)
        {
            a = a * @base;
        }
        return a;
    }

    static int IsPrime(int number)
    {
        if (number % 2 != 0 || number == 2)
        {
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("");
        }
        return number;
    }
}