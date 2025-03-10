using System;

class Program
{
    public delegate double SeriesTerm(int n);

    public static double CalculateSeries(SeriesTerm termFormula, double epsilon)
    {
        double sum = 0;
        int n = 0;
        double term;

        do
        {
            term = termFormula(n);  
            sum += term;          
            n++;                   
        }
        while (Math.Abs(term) > epsilon); 

        return sum;
    }

    public static double FirstSeriesTerm(int n)
    {
        return 1.0 / Math.Pow(2, n);
    }

    public static double SecondSeriesTerm(int n)
    {
        double factorial = 1;
        for (int i = 1; i <= n + 1; i++)
        {
            factorial *= i;
        }
        return 1.0 / factorial;
    }

    public static double ThirdSeriesTerm(int n)
    {
        double sign;

        if (n % 2 == 0)
        {
            sign = 1;
        }
        else
        {
            sign = -1;
        }
        double term = sign / Math.Pow(2, n);

        return term;

    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double epsilon = 0.0001;

        double sum1 = CalculateSeries(FirstSeriesTerm, epsilon);
        Console.WriteLine($"Сума першого ряду: {sum1}");

        double sum2 = CalculateSeries(SecondSeriesTerm, epsilon);
        Console.WriteLine($"Сума другого ряду: {sum2}");

        double sum3 = CalculateSeries(ThirdSeriesTerm, epsilon);
        Console.WriteLine($"Сума третього ряду: {sum3}");
    }
}
