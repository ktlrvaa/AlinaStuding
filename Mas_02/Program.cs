using System;
using System.Linq;

namespace Mas_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите массив: ");
            int[] array = Console.ReadLine().Trim().Split(' ').Select(el => Convert.ToInt32(el)).ToArray();

            // Твой код пиши ниже 

            int[] massiv = new int [array.Length];
            for (int i = 0; i < massiv.Length; i++)
            {
                var index = array.Length - 1 - i;
                //massiv[i];
            }


            // array можешь заменить названием другого массива, он выведется в консоль
            DisplayArray(massiv);
        }

        static void DisplayArray(int[] array)
        {
            foreach (var elem in array) Console.Write(elem.ToString() + " ");
        }
    }
}
