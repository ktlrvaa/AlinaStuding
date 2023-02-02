using System;
using System.Linq;

namespace Mas_01
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите массив: ");
            int[] array = Console.ReadLine().Trim().Split(' ').Select(el => Convert.ToInt32(el)).ToArray();

            // Твой код пиши ниже 
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
            Console.ReadLine();

            // array можешь заменить названием другого массива, он выведется в консоль
            //foreach (var elem in array) Console.Write(elem.ToString() + " ");



        }
    }
}
