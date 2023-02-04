using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClass_01
{
    public abstract class Animal
    {
        public int Health;
        public int FoodLevel;
        public readonly string TypeName;

        protected Animal(string typeName, int health, int foodLevel)
        {
            TypeName = typeName;
            Health = health;
            FoodLevel = foodLevel;
        }

        public abstract void MakeSounds();
        public abstract void TryToEat();
        public abstract void MoveOnTheGround();
    }
}
