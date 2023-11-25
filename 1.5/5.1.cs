using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask1.txt");
        int[] numbers = Array.ConvertAll(lines, int.Parse);
        int minIndex = Array.IndexOf(numbers, numbers.Min());
        int product = 1;
        for (int i = minIndex + 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        Console.WriteLine("Product of numbers after the minimum: " + product);
    }
}