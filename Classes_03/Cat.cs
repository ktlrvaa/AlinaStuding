using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_03
{
    public class Cat
    {
        public readonly string Name;
        public Cat(string name)
        {
            Name = name;
        }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Некорректный возраст.");
                }
            }
        }

        /*       public string Name
               {
                   get
                   {

                   }
                   set
                   {
                   }
               }*/
    }





}


