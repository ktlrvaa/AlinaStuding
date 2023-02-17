using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClass_02
{
    public class GranMother
    {
        public string Name;
        public readonly string ColorEyes;
        public string ColorHair;

        public GranMother(string name, string colorEyes, string colorHair)
        {
            Name = name;
            ColorEyes = colorEyes;
            ColorHair = colorHair;
        }

        public virtual void DayliChores()
        {
            Console.WriteLine(Name + " читает книгу.");
        }
        public virtual void SingSongs()
        {
            Console.WriteLine(Name + " умеет петь.");
        }
        public virtual void TextOutput()
        {
            Console.WriteLine("Расскажем немного об этом члене семьи.\nИмя: " + Name + "\n" + "Цвет глаз: " + ColorEyes + "\n" + "Цвет волос: " + ColorHair);
        }

        public virtual void Role()
        {
            Console.WriteLine($"Роль Клавдии в семье - быть бабушкой.");
        }
    }
}
