using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClass_02
{
    internal class Daughter : GranMother
    {
        public Daughter(string name, string colorEyes, string colorHair) : base(name, colorEyes, colorHair)
        {
        }

        public override void SingSongs()
        {
            base.SingSongs();
            Console.WriteLine("А ещё иногда поёт песни в поп-группе.");
        }

        public override void DayliChores()
        {
            Console.WriteLine(Name + " ходит на работу в офис.");
        }

        public override void Role()
        {
            Console.WriteLine($"Роль {Name} в семье - быть дочерью и мамой для сына.");
        }
    }
}
