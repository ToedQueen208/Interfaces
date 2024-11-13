using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class PatheraBigCat : Mammal
    {

        public PatheraBigCat(float weight) : base(weight) 
        {
        
        }

        public override sealed void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " roars!");
        }


    }
}
