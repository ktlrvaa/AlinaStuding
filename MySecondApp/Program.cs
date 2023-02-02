using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Здесь прошу пользователя ввести данные для входа в ЛК
            Console.WriteLine("Введите логин и пароль");
            // Задаю значения пароля и логина
            string userLogin = "vadim34";
            string userPassword = "12345";
            string writedLogin = Console.ReadLine();
            string writedPasswod = Console.ReadLine();
            //Если все введено верно, вывожу окно с результатом
            if (writedLogin == userLogin && userPassword == writedPasswod)
            {
                Console.WriteLine("Вы вошли в свой аккаунт");
            }
            else
            {
                Console.WriteLine("Логин или пароль введен неверно");
            }

            Console.ReadLine();
        }
    }
}
