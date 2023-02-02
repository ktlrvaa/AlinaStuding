using System;

namespace Arrays_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] mass = new int[100];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i * 3;
            }

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(i + ": " + mass[i]);
            }*/

            Console.WriteLine("Введите колическо элементов массива:");
            double[] constructor = new double[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < constructor.Length; i++)
            {
                constructor[i] = (double) i/2; 
                Console.WriteLine(constructor[i]);
            }
            Console.ReadLine();
        }
    }
}
