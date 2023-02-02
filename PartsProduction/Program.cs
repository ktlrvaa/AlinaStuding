using System;

namespace PartsProduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Details();
            
        }
        static void Details ()
        {
            //Запрос данных
            Console.Write("Сколько деталей рабочий сделал в первый день? Введите количество: ");
            int numberOfDetails = Convert.ToInt32(Console.ReadLine());
            for (int days = 0; days < 6; days++)
            {
                numberOfDetails *= 2;
                Console.WriteLine(numberOfDetails);
            }
        }
    }

}
