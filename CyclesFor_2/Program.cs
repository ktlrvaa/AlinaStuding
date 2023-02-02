using System;

namespace CyclesFor_2
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 0, k = 10; i < k;)
            {
                string input = Console.ReadLine(); 
                if (input == "i")
                {
                    i += 5;
                }
                else
                {
                    k++;
                }
            }
            Console.WriteLine("Hi");
            Console.ReadLine();
        }
    }
}
