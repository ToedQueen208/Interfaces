using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Tiger : PatheraBigCat, IHunt
    {
        public Tiger(float weight) : base(weight)
        { }

        public void Move()
        {
            Console.WriteLine("Tiger is moving");
        }

        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + " is hunting on land");
        }
    }
}
