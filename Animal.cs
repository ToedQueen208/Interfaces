using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Animal //: IComparable
    {
        public float Weight { get; set; }

        public Animal(float weight)
        {
            Weight = weight;
        }

        public abstract void MakeSound();

        //public int CompareTo(Object obj)
        //{
        //    int position = -(int)(this.Weight - ((Animal)obj).Weight);
        //    return position;
        //}
        

        
    }
}
