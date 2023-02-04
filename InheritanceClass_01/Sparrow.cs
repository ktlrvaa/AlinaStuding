using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClass_01
{
    public class Sparrow : Animal
    {
        public Sparrow() : base("Воробей", 10, 5)
        {
        }

        public override void MakeSounds()
        {
            Console.WriteLine(TypeName + " чирикает.");
        }

        public override void MoveOnTheGround()
        {
            Console.WriteLine(TypeName + " прыгает.");
        }

        public override void TryToEat()
        {
            Console.WriteLine(TypeName + " ест червей.");
        }
        public void Fly()
        {
            Console.WriteLine(TypeName + " летает.");
        }
    }
}
