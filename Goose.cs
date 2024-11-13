using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Goose : Bird, IFly, ISwim
    {
        public Goose(float weight) : base(weight) 
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " HONKS!");
        }
        public void Fly()
        {
            Console.WriteLine(this.GetType().Name + " is flying");
        }

        public void Swim()
        {
            Console.WriteLine(this.GetType().Name + " is swimming");
        }

    }
}
