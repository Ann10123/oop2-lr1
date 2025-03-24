using System;
using System.Linq;
using System.Diagnostics;

class Program
{
    static int[] GenerateRandomArray(int size, int minValue = 0, int maxValue = 100)
    {
        Random rand = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(minValue, maxValue);
        }

        return array;
    }

    static int[] GetArrayFromUserInput(int size)
    {
        int[] array = new int[size];
        Console.WriteLine("Введіть елементи масиву через пробіл:");

        string[] input = Console.ReadLine().Split(' ');

        if (input.Length != size)
        {
            Console.WriteLine("Невірна кількість елементів.", size);
            return GetArrayFromUserInput(size);
        }

        for (int i = 0; i < size; i++)
        {
            if (!int.TryParse(input[i], out array[i]))
            {
                Console.WriteLine("Невірний ввід. Спробуйте ще раз.");
                return GetArrayFromUserInput(size);
            }
        }
        return array;
    }
    static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }

    static void ShakerSort(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            right--;

            for (int i = right; i > left; i--)
            {
                if (array[i] < array[i - 1])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                }
            }
            left++;
        }
    }

    static void StudentSelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }

    static void StudentShakerSort(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            right--;

            for (int i = right; i > left; i--)
            {
                if (array[i] < array[i - 1])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                }
            }
            left++;
        }
    }

    static long MeasureSortTime(Action<int[]> sortMethod, int[] array)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        sortMethod(array);
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Виберіть метод заповнення масиву(1 - рандомно, 2 - вручну): ");
        string choice = Console.ReadLine();

        int[] array = null;

        if (choice == "1")
        {
            Console.Write("Введіть розмір масиву: ");
            int size = int.Parse(Console.ReadLine());
            array = GenerateRandomArray(size);
            Console.WriteLine("Масив створено рандомно.");
            Console.WriteLine("Початковий масив: " + string.Join(", ", array));
        }
        else if (choice == "2")
        {
            Console.Write("Введіть розмір масиву: ");
            int size = int.Parse(Console.ReadLine());
            array = GetArrayFromUserInput(size);
        }
        else
        {
            Console.WriteLine("Невірний вибір.");
            return;
        }

        int[] arrayForSelectionSort = (int[])array.Clone();
        int[] arrayForShakerSort = (int[])array.Clone();
        int[] arrayForStudentSelectionSort = (int[])array.Clone();
        int[] arrayForStudentShakerSort = (int[])array.Clone();

        long selectionSortTime = MeasureSortTime(SelectionSort, arrayForSelectionSort);
        long shakerSortTime = MeasureSortTime(ShakerSort, arrayForShakerSort);
        long studentSelectionSortTime = MeasureSortTime(StudentSelectionSort, arrayForStudentSelectionSort);
        long studentShakerSortTime = MeasureSortTime(StudentShakerSort, arrayForStudentShakerSort);

        Console.WriteLine("Час виконання сортувань:");
        Console.WriteLine($"Сортування вибором (еталон): {selectionSortTime} мс");
        Console.WriteLine($"Сортування шейкером (еталон): {shakerSortTime} мс");
        Console.WriteLine($"Сортування вибором (студентське): {studentSelectionSortTime} мс");
        Console.WriteLine($"Сортування шейкером (студентське): {studentShakerSortTime} мс");

        Console.WriteLine("\nВисновки:");
        if (studentSelectionSortTime < selectionSortTime)
        {
            Console.WriteLine("Студентське сортування вибором працює швидше за еталонне.");
        }
        else
        {
            Console.WriteLine("Еталонне сортування вибором працює швидше за студентське.");
        }

        if (studentShakerSortTime < shakerSortTime)
        {
            Console.WriteLine("Студентське шейкерне сортування працює швидше за еталонне.");
        }
        else
        {
            Console.WriteLine("Еталонне шейкерне сортування працює швидше за студентське.");
        }

        Console.WriteLine("\nВідсортований масив вибором (еталон):");
        Console.WriteLine(string.Join(", ", arrayForSelectionSort));

        Console.WriteLine("\nВідсортований масив шейкером (еталон):");
        Console.WriteLine(string.Join(", ", arrayForShakerSort));

        Console.WriteLine("\nВідсортований масив вибором (студентське):");
        Console.WriteLine(string.Join(", ", arrayForStudentSelectionSort));

        Console.WriteLine("\nВідсортований масив шейкером (студентське):");
        Console.WriteLine(string.Join(", ", arrayForStudentShakerSort));
    }
}
