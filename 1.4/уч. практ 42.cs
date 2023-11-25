using System;
using System.IO;
class Program
{
    static void Main()
    {
        double sumPositive = 0;
        using (StreamReader sr = new StreamReader("numsTask2.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] numbers = line.Split(';');
                foreach (string number in numbers)
                {
                    double num = Convert.ToDouble(number);
                    if (num <= 0)
                    {
                        break;
                    }
                    if (num > 0)
                    {
                        sumPositive += num;
                    }
                }
            }
        }
        Console.WriteLine(sumPositive);
    }
}