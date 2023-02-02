using System;

namespace Calc_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Введите любое число a и b:");
            float a = (float) Convert.ToDouble(Console.ReadLine());
            float b = (float) Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Что нужно сделать с этими числами? \n 1. Сложить \n 2. Вычесть \n 3. Умножить");
            string key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    Console.WriteLine(calculator.Summ(a, b));
                    break;
                case "2":
                    Console.WriteLine(calculator.Difference(a,b));
                    break;
                case "3":
                    Console.WriteLine(calculator.Complexity(a,b));
                    break;
            }
            Console.ReadLine();

        }
    }
}
