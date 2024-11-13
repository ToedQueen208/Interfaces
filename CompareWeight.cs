using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //[Obsolete ("animals now implement IComparable", true)]     //alternate method defines IComparable interface on Animal
    public class CompareWeight : IComparer<Animal>      //this is a generic?
    {
        public bool isAscending { get; set; }
        public CompareWeight(bool asc)
        {
            isAscending = asc;
        }
        public int Compare(Animal a, Animal b)
        {
            if (isAscending) //it works like a subtraction: a - b < 0 indicates a comes before b. We could also have solved this by implementing IComparable directly on fruit. 
            {
                return a.Weight.CompareTo(b.Weight);
            }
            else
            {
                return b.Weight.CompareTo(a.Weight);
            }


        }
    }
}
