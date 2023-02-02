using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesForText_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Получаем фразу, которую нужновывести на экран n кол-во раз
            Console.WriteLine("Введите фразу, которую вы хотите вывести на экран:");
            string phraseUser = Console.ReadLine();
            // Узнаем, сколько раз нужно вывести фразу
            Console.WriteLine("Сколько раз вы хотите её повторить?");
            int qantity = Convert.ToInt32(Console.ReadLine());
            // Если кол-во > 0
            if (qantity > 0)
            {
                //Выполняем цикл
                for (int i = 0; i < qantity; i++)
                {
                    Console.WriteLine(phraseUser);
                }
            }
            // Delay
            Console.ReadKey();
        }
    }
}
