using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] tokens = File.ReadAllText("numsTask4.txt").Split(' ');
        int count = 0;
        for (int i = 1; i < tokens.Length; i++)
        {
            if (tokens[i] == tokens[i - 1])
            {
                count++;
            }
        }
        Console.WriteLine("Количество одинаковых рядом стоящих чисел: " + count);
    }
}