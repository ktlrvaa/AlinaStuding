using System;
using System.Xml.Linq;

namespace Classes_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat tom = new Cat("Tom");
            tom.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: " + tom.Name + "\n" + "Age: " + tom.Age);
            Predator lion = new Predator("Lion");
            lion.Age= Convert.ToInt32(Console.ReadLine());
            JumpPredator(lion);
        }

        private static void JumpPredator(Predator lion)
        {
            Console.WriteLine(Name + " живет в Африке.");
        }
    }
}
