using System;
using System.Collections.Generic;

namespace List_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productList = new List<Product>();
            Start:
            while (true)
            {
                var product = new Product();
                Console.WriteLine("Наименование товара:");
                product.Name = Console.ReadLine();
                Console.WriteLine("Артикул товара:");
                var inputArticul = Console.ReadLine();
                product.Articul = long.Parse(inputArticul);
                Console.WriteLine("Стоимость товара в формате 00,00:");
                product.Price = Convert.ToDouble(Console.ReadLine());
                productList.Add(product);
                Console.WriteLine("Если вы хотите завершить сканирование, то напишите команду exit.\n" +
                    "Если хотите продолжить сканирование товаров, то напишите команду next.");
                string comand = Console.ReadLine();
                if (comand == "exit")
                {
                    Console.WriteLine("Сканирование завершено.");
                    break;
                }
                if (comand == "next")
                {
                    goto Start;
                }

                Console.WriteLine("Команда введена неверно.");
                
            }
        }
    }
}
