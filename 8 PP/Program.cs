using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ввод данных
        Console.WriteLine("Введите количество дней:");
        int daysCount = int.Parse(Console.ReadLine());
        double[] temperatures = new double[daysCount];

        for (int i = 0; i < daysCount; i++)
        {
            Console.WriteLine($"Введите температуру для дня {i + 1}:");
            temperatures[i] = double.Parse(Console.ReadLine());
        }

        // Обработка данных
        double averageTemperature = temperatures.Average();
        double maxTemperature = temperatures.Max();
        double minTemperature = temperatures.Min();

        // Вывод результатов
        Console.WriteLine($"Средняя температура: {averageTemperature:F2}");
        Console.WriteLine($"Максимальная температура: {maxTemperature:F2}");
        Console.WriteLine($"Минимальная температура: {minTemperature:F2}");
    }
}
