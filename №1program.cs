using System;
using System.Threading;

public delegate void TimerAction();

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Timer timer1 = new Timer(PrintMessage1, 1); 
        Timer timer2 = new Timer(PrintMessage2, 5); 

        timer1.Start();
        timer2.Start();

        Console.WriteLine("Натисніть будь-яку клавішу, щоб зупинити таймери...");
        Console.ReadKey();

        timer1.Stop();
        timer2.Stop();
    }
    static void PrintMessage1()
    {
        Console.WriteLine($"Таймер 1: {DateTime.Now}");
    }

    static void PrintMessage2()
    {
        Console.WriteLine($"Таймер 2: {DateTime.Now}");
    }
}
