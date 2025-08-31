internal class Program
{
    private static void Main(string[] args)
    {

        /*Console.Write("Введите число = ");
        double @base = double.Parse(Console.ReadLine());

        Console.Write("Введите степень = ");
        double pow = double.Parse(Console.ReadLine());

        double result = Power(@base, pow);
        Console.WriteLine($"Результат возведение в степень = {result}");

        Console.Write("Введите число = ");
        int number = int.Parse(Console.ReadLine());
        int result = IsPrime(number);

        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        var ageDictionary = new Dictionary<string, int>();
        ageDictionary.Add(name, age);
        ageDictionary.Keys.ToArray();
        Console.WriteLine(name + " " + ageDictionary[name]);

        Console.WriteLine("Введите число месяца = ");
        int number = int.Parse(Console.ReadLine());
        int result = Months(number);

        int sum = 0;
        int result = EvenAndNotDivisibleThree(sum);*/
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

    static int Months(int number)
    {
        switch (number)
        {
            case 1: Console.WriteLine(31);
                break;
            case 2: Console.WriteLine(28); 
                break;
            case  3: Console.WriteLine(31); 
                break;
            case  4: Console.WriteLine(30); 
                break;
            case 5: Console.WriteLine(31); 
                break;
            case 6: Console.WriteLine(30);
                break;
            case 7: Console.WriteLine(31);
                break;
            case 8: Console.WriteLine(31);
                break;
            case 9: Console.WriteLine(30);
                break;
            case 10: Console.WriteLine(31);
                break;
            case 11: Console.WriteLine(30);
                break;
            case 12: Console.WriteLine(31);
                break;
        }
        return number;
    }

    static int EvenAndNotDivisibleThree(int sum)
    {
        int number = int.Parse(Console.ReadLine());
        sum = 0;

        while (number != 0)
        {
            if (number % 2 == 0 && number % 3 != 0)
            {
                sum = sum + number;
                number = int.Parse(Console.ReadLine());
            }
            else
            {
                number = int.Parse(Console.ReadLine());
            }

        }
        Console.WriteLine(sum);
        return sum;
    }
}