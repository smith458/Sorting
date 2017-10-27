using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //Looks through the array for the smallest index and swaps earliest unsorted value with the smallest value
    public class Selection<T> where T : IComparable
    {
        public static T[] Sort(T[] coll)
        {
            for (int i = 0; i < coll.Length; ++i)
            {
                T smallestValue = coll[i];
                int smallestIndex = i;

                for (int j = i+1; j < coll.Length; ++j)
                {
                    if (coll[j].CompareTo(smallestValue) < 1)
                    {
                        smallestValue = coll[j];
                        smallestIndex = j;
                    }
                }

                if (smallestIndex != i)
                {
                    coll[smallestIndex] = coll[i];
                    coll[i] = smallestValue;
                }
            }

            return coll;
        }
    }
}
