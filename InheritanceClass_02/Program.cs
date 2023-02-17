using System;

namespace InheritanceClass_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GranMother granMother = new GranMother("Клавдия", "Зелёные", "Седой");
            granMother.Role();
            granMother.TextOutput();
            granMother.DayliChores();
            granMother.SingSongs();

            Daughter daughter = new Daughter("Валерия", "Голубой", "Рыжий");
            daughter.Role();
            daughter.TextOutput();
            daughter.DayliChores();
            daughter.SingSongs();

            Child child = new Child("Максим", "Серо-голубые", "Светло-русый");
            child.Role();
            child.TextOutput();
            child.DayliChores();
            child.SingSongs();
            Console.ReadKey();
        }
        
    }

}
