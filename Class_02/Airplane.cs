using System;
using System.Collections.Generic;
using System.Text;

namespace Class_02
{
    class Airplane
    {
        public string Name;
        public int Mass;
        public int Power;
        public int Capacity;

        public Airplane(string name, int mass, int power, int capacity)
        {
            Name = name;
            Mass = mass;
            Power = power;
            Capacity = capacity;

            Console.WriteLine($"Экземпляр класса Airplane с именем {Name} создан");
        }

        public void Fly()
        {
            Console.WriteLine(Name + " летит.");
        }

    }
}
