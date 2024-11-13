using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class HuntingGround : SafariEnvironment<IHunt>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in this.animalsInEnvironment)
            {
                if ((animal is ISwim  && animal is IHunt ))
                {
                    Console.WriteLine(animal.GetType().Name +  " is hunting in the water of the hunting ground");
                }
                else if ((animal is IFly && animal is IHunt))
                {
                    Console.WriteLine(animal.GetType().Name + " is hunting in the sky of the hunting ground");
                }
                else if (animal is IHunt)
                {
                    Console.WriteLine(animal.GetType().Name + " is hunting on land in the hunting ground");
                }
                else
                {
                    Console.WriteLine(animal.GetType().Name + " is not a hunter");
                }
            }
        }
    }
}
