using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваше n");
        int n = Convert.ToInt32(Console.ReadLine());
        int product = 1;
        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }

        Console.WriteLine(product);
    }
}