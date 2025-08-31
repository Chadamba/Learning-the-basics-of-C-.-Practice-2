using System.Threading.Channels;

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
        int result = EvenAndNotDivisibleThree(sum);

        int difference = 0;
        int result = Difference(difference);

        double arithmeticMean = 0;
        double result = AverageValueOfSequence(arithmeticMean);

        int numberElements = 0;
        int result = MoreThanPreviousOne(numberElements);*/
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

    static int Difference(int difference)
    {
        int number = int.Parse(Console.ReadLine());
        int sumPositiveOnes = 0;
        int sumNegativeOnes = 0;


        while (number != 0)
        {
            if (number > 0)
            {
                sumPositiveOnes++;
                number = int.Parse(Console.ReadLine());

            }
            else if (number < 0)
            {
                sumNegativeOnes++;
                number = int.Parse(Console.ReadLine());

            }

        }
        difference = sumPositiveOnes - sumNegativeOnes;
        Console.WriteLine(difference);
        return difference;
    }

    static double AverageValueOfSequence(double arithmeticMean)
    {
        double number = double.Parse(Console.ReadLine());
        double sum = 0;
        double quantity = 0;
   
        while (number != 0)
        {
            sum += number;
            quantity++;
            number = double.Parse(Console.ReadLine());
        }
        arithmeticMean = sum/quantity;
        Console.WriteLine(arithmeticMean);
        return arithmeticMean;
    }

    static int MoreThanPreviousOne(int numberElements)
    {
        int number = int.Parse(Console.ReadLine());
        numberElements = 0;

        while (number != 0)
        {
            
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberTwo > number)
            {
                numberElements++;
            }
            number = numberTwo;
        }
        
        Console.WriteLine(numberElements);
        return numberElements;
    }

    static int ChangingSign(int numberOfSignChanges)
    {
        int current = Convert.ToInt32(Console.ReadLine());
        int previous = current;
        int count = 0;
        while (current != 0)
        {
            current = Convert.ToInt32(Console.ReadLine());
            if (current * previous < 0)
            {
                count++;
            }
            previous = current;
        }

        Console.WriteLine(count);
        return numberOfSignChanges;
    }

}