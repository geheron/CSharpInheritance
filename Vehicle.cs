﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInheritance
{
    abstract class Vehicle
    {

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; }

        public Vehicle(double speed)
        {
            Speed = speed;
        }

        public virtual void SpeedUp()
        {
            Speed += 5;
        }

        public virtual void SlowDown()
        {
            Speed -= 5;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public abstract string Describe();

    }
}
