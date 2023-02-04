using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClass_01
{
    internal class Mouse : Animal
    {
        public Mouse() : base("Мышь", 20, 10)
        {
        }

        public override void MakeSounds()
        {
            Console.WriteLine(TypeName + " пищит.");
        }

        public override void MoveOnTheGround()
        {
            Console.WriteLine(TypeName + " бегает.");
        }

        public override void TryToEat()
        {
            Console.WriteLine(TypeName + " ест зерно.");
        }
        public void DigHole()
        {
            Console.WriteLine(TypeName + " роет нору.");
        }
    }
}
