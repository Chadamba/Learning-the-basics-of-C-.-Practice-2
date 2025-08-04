internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Введите число = ");
        double @base = double.Parse(Console.ReadLine());

        Console.Write("Введите степень = ");
        double pow = double.Parse(Console.ReadLine());

        double result = Power(@base, pow);
        Console.WriteLine($"Результат возведение в степень = {result}");

    }

    static double Power(double @base, double exponent)
    {
        double a = @base;
        for (int i = 1; i < exponent; i++)
        {
            a = a * @base;
        }
        return a;
    }
}