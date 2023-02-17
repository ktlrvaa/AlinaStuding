using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClass_02
{
    internal class Child : Daughter
    {
        public Child(string name, string colorEyes, string colorHair) : base(name, colorEyes, colorHair)
        {
        }
        public override void SingSongs()
        {
            Console.WriteLine(Name + " пока еще не умеет петь.");
        }
        public override void DayliChores()
        {
            Console.WriteLine(Name + " ползает и играет в игрушки.");
        }

        public override void Role()
        {
            Console.WriteLine($"Роль {Name} в семье - быть любимым внуком и сыном.");
        }
    }
}
