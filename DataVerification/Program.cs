using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string patronymic;
            int dateOfBirth;
            int numberPhone;
            int pass;
            Console.WriteLine("Введите своё имя:");
            Console.ReadLine();
            Console.WriteLine("Введите свою фамилию:");
            Console.ReadLine();
            Console.WriteLine("Введите своё отчество:");
            Console.ReadLine();
            Console.WriteLine("Введите дату рождения в формате:ХХХХХХ");
            Console.ReadLine();
            Console.WriteLine("Введите номер телефона, начиная с 8.");
            Console.ReadLine();
            Console.WriteLine("Введите слитно серию и номер паспорта");
            Console.ReadLine();
        }
    }
}
