using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_01
{
    public class Cat
    {
        public string Name;
        public void Voice()
        {
            Console.WriteLine($"{Name}: Мяу!");
        }
        public void Run()
        {
            Console.WriteLine($"{Name} бежит");
        }
    }
}
