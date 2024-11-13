using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Bat : Mammal, IHunt, IFly
    {

        public Bat(float weight): base(weight) {
        
        }
        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " screeches!");
        }
        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + " is hunting in the air");
        }

        public void Fly()
        {
            Console.WriteLine(this.GetType().Name + " is flying");
        }
    }
}
