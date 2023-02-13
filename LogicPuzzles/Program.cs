using System;

namespace LogicPuzzles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решите логическую загадку. Вам дано пять попыток.");
            Console.WriteLine("Для выхода из программы введите exit.");

            Console.WriteLine("Загадка: На столе лежат две монеты, в сумме они дают 3 рубля. Одна из них - не 1 рубль. Какие это монеты?");

            //Максимальное кол-во попыток
            const int maxAttempt = 5;
            //Счетчик попыток
            int attempt = 0;
            //Загаданный цвет
            string coinsVarOne = "21";
            string coinsVarTwo = "12";
            string coinsVarFree = "2 и 1";
            string coinsVarFour = "1 и 2";


            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Попытка {0}:", attempt);
                //Строка для ввода ответа
                string value = Console.ReadLine();
                //Условие для команды "Выход из игры"
                if (value == "exit")
                {
                    //Завершаем цикл при выходе из игры
                    break;
                }
                //Условие для игры
                
                if (value == coinsVarOne || value == coinsVarTwo || value == coinsVarFree || value == coinsVarFour)
                { //Загадка решена
                    Console.WriteLine("Поздравляем, вы решили загадку с {0} попытки!\nВ условии сказано, что только одна из монет не 1 рубль.", attempt);
                    //Завершаем цикл
                    break;
                }
                //Возвращаем к циклу при неверном вводе ответа
                continue;
               
            }
            //Попытки закончились 
            if (attempt == maxAttempt)
            {
                Console.WriteLine("Попытки закончились.");

            }
            //Завершаем игру
            Console.WriteLine("Конец игры!");
            Console.ReadLine();
        }
    }

}
