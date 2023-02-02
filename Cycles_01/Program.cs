using System;
using System.Linq;

namespace Cycles_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiple();
            Subsequence();
            Multiplication();
            Convert.ToInt32(1);

        }

        //Метод к заданию 1.
        static void Multiple ()
        {
            for (int i = 10; i< 100; i++)
            {
                if (i % 5 == 0)
                {
                    
                        Console.Write("{0} ", i);
                }

}
        }
        //Метод к заданию 2.
        static void Subsequence()
        {
            Console.WriteLine();
            int number = 0;
            do
            {
                number -= 20;
                Console.WriteLine(number);
            }
            while (number > -100);
        }

        // Метод к заданию 3.

        static void Multiplication ()
        {
            Console.WriteLine();
            int multiplication = 1;
            for (int i = 2; i <= 16; i++)
            {
                multiplication *= i;
            }
            Console.WriteLine(multiplication);
        }
    }
}
