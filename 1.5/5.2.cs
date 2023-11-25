using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string content = File.ReadAllText("numsTask2.txt");
        string[] numbersStr = content.Split(';');
        double[] numbers = Array.ConvertAll(numbersStr, double.Parse);
        Array.Sort(numbers);
        string sortedContent = string.Join(";", numbers.Select(x => x.ToString()));
        File.WriteAllText("numsTask2.txt", sortedContent);
    }
}