﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Tiger : PatheraBigCat, IMove
    {
        public Tiger(float weight) : base(weight)
        { }

        public void Move()
        {
            Console.WriteLine("Tiger is moving");
        }
    }
}
