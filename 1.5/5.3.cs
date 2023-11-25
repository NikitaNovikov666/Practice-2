using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask3.txt");
        int[] numbers = Array.ConvertAll(lines, int.Parse);
        int minIndex = Array.IndexOf(numbers, numbers.Min());
        double average = numbers.Take(minIndex).Average();
        Console.WriteLine("Average of numbers before the minimum: " + average);
    }
}