using System;

namespace ConsoleApp4
{
    class Program
    {
        public static double Avarge(params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);

        }
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] arr = new int[4];
            for (int i = 0; i < 4; i++)
            {
                arr[i] = rand.Next(10, 20);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Cреднее значение массива: {0}",Avarge(arr));
            short z = 1, e = 12;
            byte v = 107;
            Console.WriteLine(Avarge(z, e, v));
            Console.WriteLine("Cреднее значение массива: {0}", Avarge());

        }
    }
}
