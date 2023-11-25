using System;

class Program
{
    static bool IsInsideTriangle(double x, double y, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Расчет площади треугольника по координатам его вершин
        double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

        double p = (a + b + c) / 2; // Полупериметр треугольника
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Формула Герона для вычисления площади треугольника

        // Проверка, что точка внутри треугольника
        return area >= 0;
    }

    static void Main()
    {
        double x1 = 0, y1 = 2;
        double x2 = 2, y2 = -3;
        double x3 = -2, y3 = -3;
        Console.WriteLine("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        bool isInside = IsInsideTriangle(x, y, x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Принадлежит ли точка треугольнику: " + isInside);
    }
}