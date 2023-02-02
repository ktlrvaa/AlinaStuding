using System;

namespace Cycles_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 3)
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);
            }
            Console.WriteLine("Произведено {0} итераций", counter);
            Console.ReadLine();
        }
    }
}
