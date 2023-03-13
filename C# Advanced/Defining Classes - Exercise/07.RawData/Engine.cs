﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get { return this.speed; } set { speed = value; } }
        public int Power { get { return this.power; } set { power = value; } }
    }
}
