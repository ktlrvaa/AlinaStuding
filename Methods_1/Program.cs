using System;

namespace Methods_1
{
    internal class Program
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="a"></param>
       /// <param name="b"></param>
       /// <returns></returns>
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int CalculateForAttempt(int moneyPerDay, int days)
        {
            return moneyPerDay * days;
        }
        static void Main()
        {
            Console.WriteLine(CalculateZP());
        }
        static int CalculateZP()
        {
            int first = CalculateForAttempt(10, 20);
            int second = CalculateForAttempt(15, 30);
            return Add(second, first);
        }
    }
}
