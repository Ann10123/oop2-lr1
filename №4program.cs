using System;

class Program
{
    private static readonly Func<double, double>[] functions =
    {
        x => Math.Sqrt(Math.Abs(x)),
        x => -Math.Pow(x, 3),
        x => x + 3.5
    };

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            try
            {
                Console.WriteLine("Введіть номер функції, яку потрібно виконати (0,1,2) та значення через пробіл: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                string[] parts = input.Split(' ');
                if (parts.Length != 2)
                {
                    Console.WriteLine("Помилка вводу. Спробуйте ще раз.");
                    continue;
                }

                int funcIndex = int.Parse(parts[0]);
                double value = double.Parse(parts[1]);

                if (funcIndex < 0 || funcIndex >= functions.Length)
                {
                    Console.WriteLine("Невірний індекс функції. Спробуйте ще раз.");
                    continue;
                }

                double result = functions[funcIndex](value);
                Console.WriteLine($"Результат: {result}");
            }
            catch
            {
                Console.WriteLine("Помилка введення. Бажаємо всього найкращого!");
                break;
            }
        }
    }
}
