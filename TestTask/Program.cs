using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Прошу пользователя выбрать задачу, которую нужно решить
            Console.WriteLine("Укажите номер задачи, которую нужно решить: \n 1. Найти дискриминант \n 2. Найти гипотенузу по теореме Пифагора \n 3. Извлечь корень из любого числа");
            //Присваиваю каждой задаче свой номер           
            string key = Console.ReadLine();
            while (key != "1"
                && key != "2"
                && key != "3"
                )
            {
                Console.WriteLine("Вы ввели неверное значение!");
                key = Console.ReadLine();
            }

            switch (key)
            {
                case "1":
                    // Прошу пользователя указать значения для вычисления дискриминанта
                    Console.WriteLine("Введите значения для расчета дискриминанта: a, b, c");
                    // Вношу в программу информацию по вычислению дискриминанта
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    double c = Convert.ToDouble(Console.ReadLine());
                    double resultDiscr = (b * b + 4 * a * c);
                    Console.WriteLine(resultDiscr);
                    break;
                case "2":
                    //Прошу пользователя указать значения для расчета гипотенузы
                    Console.WriteLine("Введите значения для расчета гипотенузы:");
                    //Вношу информацию по расчету гипотенузы
                    double d = Convert.ToDouble(Console.ReadLine());
                    double n = Convert.ToDouble(Console.ReadLine());
                    double resultHypot = Math.Sqrt(d * d + n * n);
                    Console.WriteLine(resultHypot);
                    break;
                case "3":
                    //Прошу пользователя внести число для извлечения из него корня
                    Console.WriteLine("Введите значение для вычисления корня из числа");
                    //Указываю информацию для вычисления корня
                    double m = Convert.ToDouble(Console.ReadLine());
                    double resultRoot = Math.Sqrt(m);
                    Console.WriteLine(resultRoot);
                    break;
            }

            Console.WriteLine("Готово!");
            Console.ReadLine();
        }
    }
}
