using System;

namespace Array_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите команду, которую нужно исполнить: \n 1. Вывести все элементы массива. \n 2. Вывести все элементы массива в обратном порядке. \n 3. Вывести четные элементы массива. \n 4. Вывести все элементы массива через 1. \n 5. Вывести все элементы массива пока не встретится элемент -1.");
            string key = Console.ReadLine();
            int[] array = { -2, -1, 0, 1, 2, 3, 4, 6 };
            while (key != "1"
                    && key != "2"
                && key != "3"
                && key != "4"
                && key != "5")
            {
                Console.WriteLine("Вы ввели неверное значение.");
                key = Console.ReadLine();
            }
            switch (key)
            {
                case "1":

                    Console.WriteLine("Все элементы массива: ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(i + ":" + array[i]);
                    }
                    break;
                case "2":
                    Console.WriteLine("Элементы массива в обратном порядке: ");
                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine(i + ":" + array[i]);
                    }
                    break;
                case "3":
                    Console.WriteLine("Чётные элементы массива: ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            Console.WriteLine(i + ":" + array[i]);
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("Элементы массива через 1.");
                    for (int i = 0; i < array.Length; i += 2)
                    {
                        Console.WriteLine(i + ":" + array[i]);
                    }
                    break;
                case "5":
                    Console.WriteLine("Все элементы массива до -1.");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] >= 0)
                        {
                            Console.WriteLine(i + ":" + array[i]);
                        }
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
