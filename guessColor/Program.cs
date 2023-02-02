using System;

namespace guessColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Угадайте задуманный цвет с пяти попыток.");
            Console.WriteLine("Для выхода из программы введите exit.");

            //Максимальное кол-во попыток
            const int maxAttempt = 5;
            //Счетчик попыток
            int attempt = 0;
            //Загаданный цвет
            string color = "green";
            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Попытка {0}:", attempt);
                //Строка для ввода цвета
                string value = Console.ReadLine();
                //Условие для команды "Выход из игры"
                if (value == "exit")
                {
                    //Завершаем цикл при выходе из игры
                    break;
                }
                //Условие для игры
                if (value != color)
                {
                    //Возвращаем к циклу при неверном вводе цвета
                    continue;
                }
                //Цвет угадан
                Console.WriteLine("Поздравляем, вы угадали цвет с {0} попытки!", attempt);
                //Завершаем цикл
                break;
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
