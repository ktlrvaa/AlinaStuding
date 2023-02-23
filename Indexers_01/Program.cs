using System;

namespace Indexers_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            first:
            Console.WriteLine("Какое слово вы хотите перевети?" +
               "\n1. Бесконечность. \n2. Солнце. \n3. Северное сияние. \n4. Шмель. \n5. Созвездие");
            Console.WriteLine("Введите нужну цифру.");
            string key = Console.ReadLine();
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
                    Console.WriteLine(dictionary["Бесконечность"]);
                    break;
                    case "2":
                    Console.WriteLine(dictionary["Солнце"]);
                    break;
                    case "3":
                    Console.WriteLine(dictionary["Северное сияние"]);
                    break;
                    case "4":
                    Console.WriteLine(dictionary["Шмель"]);
                    break;
                    case "5":
                    Console.WriteLine(dictionary["Созвездие"]);
                    break;
            }
            Console.WriteLine("Вы хотите перевести еще слово?");
            if (Console.ReadLine() == "да".ToLower() || Console.ReadLine() == "yes".ToLower())
                goto first;
        }

    }
}
