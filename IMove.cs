using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces
{
    [Obsolete("This property is obsolete. Use IFly, ISwim or IMove", false)]
    internal interface IMove
    {
     
        void Move();
    }
}
