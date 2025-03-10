using System;
using System.Linq;

class Program
{
    delegate bool IsMultipleOfK(int number, int k);
    static int[] FilterArray(int[] array, int k, IsMultipleOfK isMultipleOfK)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (isMultipleOfK(array[i], k))
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (isMultipleOfK(array[i], k))
            {
                result[index++] = array[i];
            }
        }
        return result;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть кількість елементів масиву:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Введіть елементи масиву:");
        string[] data = Console.ReadLine().Trim().Split();
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(data[i]);
        }

        Console.WriteLine("Введіть число k:");
        int k = int.Parse(Console.ReadLine());

        IsMultipleOfK isMultipleOfK = delegate (int number, int k)
        {
            if (number % k == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        };

        var result1 = array.Where(x => isMultipleOfK(x, k)).ToArray();

        Console.WriteLine("Масив після фільтрації (метод Where):");
        foreach (var item in result1)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        int[] result2 = FilterArray(array, k, isMultipleOfK);

        Console.WriteLine("Масив після фільтрації (власна реалізація):");
        foreach (var item in result2)
        {
            Console.Write(item + " ");
        }
    }
}
