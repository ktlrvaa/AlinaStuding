using System;

namespace InheritanceClass_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sparrow sparrow = new Sparrow();
            Mouse mouse = new Mouse();

            Animal animal = sparrow;

            animal.TryToEat();

            Sparrow sparrow1 = (Sparrow)animal;
            sparrow1.Fly();
        }
    }
}
