using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] numStrings = File.ReadAllText("numsTask3.txt").Split(',');
        int[] numbers = Array.ConvertAll(numStrings, int.Parse);
        int min = int.MaxValue;
        int max = int.MinValue;
        foreach (int num in numbers)
        {
            if (num == 0)
            {
                break;
            }
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }
        if (min == 0 || max == 0)
        {
            Console.WriteLine("No non-zero elements found before encountering 0");
        }
        else
        {
            double ratio = Convert.ToDouble(min) / Convert.ToDouble(max);
            Console.WriteLine(ratio);
        }
    }
}