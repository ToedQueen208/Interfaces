using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class CompareWeight : IComparer<Animal>
    {
        public bool isAscending { get; set; }
        public CompareWeight(bool asc)
        {
            isAscending = asc;
        }
        public int Compare(Animal a, Animal b)
        {
            if (isAscending) //it works but i am unsure why flipping it works 
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
