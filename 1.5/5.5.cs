using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask5.txt");
        int[] numbers = Array.ConvertAll(lines, int.Parse);
        int min = numbers.Min();
        int max = numbers.Max();
        var betweenMinMax = numbers.Where(n => n > min && n < max).ToArray();
        if (betweenMinMax.Any())
        {
            double average = betweenMinMax.Average();
            Console.WriteLine("Average of numbers between min and max: " + average);
        }
        else
        {
            Console.WriteLine("No elements between min and max.");
        }
    }
}