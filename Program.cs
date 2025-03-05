// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Średnia: " + CalculateAverage(numbers));
    }

    static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0;
        return numbers.Average();
    }
}

