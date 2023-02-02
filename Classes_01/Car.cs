using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_01
{
    internal class Car
    {
        public string Name; 
        public Engine Engine;
        public Wheels Wheels;

        public Car(string name)
        {
            Engine = new Engine(); 
            Name = name;
            Wheels = new Wheels();
        }

        public void Start()
        {
            Engine.Start();
            Wheels.Start();
        }

    }
}
