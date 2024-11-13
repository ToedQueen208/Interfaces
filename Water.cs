using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Water : SafariEnvironment<ISwim>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in this.animalsInEnvironment)
            {
                if (animal is ISwim swimmingAnimal)
                {
                    swimmingAnimal.Swim();
                }
            }
        }
    }
}
