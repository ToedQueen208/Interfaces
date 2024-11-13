using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Sky : SafariEnvironment<IFly>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in this.animalsInEnvironment)
            {
                if (animal is IFly flyingAnimal)
                {
                    flyingAnimal.Fly();
                }
            }
        }
    }
}
