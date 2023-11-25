using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask4.txt");
        int[] numbers = Array.ConvertAll(lines, int.Parse);
        int maxNumber = numbers.Max();
        int sum = numbers.Where(n => Math.Abs(n - maxNumber) == 1).Sum();
        Console.WriteLine("Sum of elements differing from the max by 1: " + sum);
    }
}