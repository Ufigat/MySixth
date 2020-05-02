using System;

namespace ConsoleApp3
{
    class Example
    {
        public int x, y;
        public static void Zad3(double value, out int sign, out bool isInt, out double abs, out double sqr)
        {
            sign = Math.Sign(value);
            isInt = (value % 1 == 0) ? true : false;
            abs = Math.Abs(value);
            sqr = value * value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a = 42, b = -12.67;
            double c, d;
            int i;
            bool check;
            Example.Zad3(a, out i, out check, out c, out d);
            Console.WriteLine("Число: {0}\nЗнак: {1}\nЦелое число: {2}\nМодуль: {3}\nКвадрат числа: {4}\n", a, i, check, c, d);
            Example.Zad3(b, out i, out check, out c, out d);
            Console.WriteLine("Число: {0}\nЗнак: {1}\nЦелое число: {2}\nМодуль: {3}\nКвадрат числа: {4}\n", b, i, check, c, d);

        }
    }
}
