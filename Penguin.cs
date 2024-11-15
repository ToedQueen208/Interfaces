﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Penguin : Bird, IHunt, ISwim
    {
        public Penguin(float weight): base(weight)
        {
        }

        public void Move()
        {
            Console.WriteLine("Penguin is moving!");
        }
        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " squawks!");
        }
        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + " is hunting in the water");
        }
        public void Swim()
        {
            Console.WriteLine(this.GetType().Name + " is swimming");
        }
    }
}
