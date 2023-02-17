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
            Console.WriteLine("А еще умеет играть на пианино.");
        }

        public override void DayliChores()
        {
            Console.WriteLine(Name + " ходит на работу в офис.");
        }
        public override void TextOutput()
        {
            base.TextOutput();
        }
        public override void Role()
        {
            Console.WriteLine($"Роль Валерии в семье - быть мамой для Максима и дочерью для Клавдии.");
        }
    }
}
