using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //Compares each value with the value after it, and swaps if necessary.
    //Goes through the list until it makes no changes during a pass.
    public class Bubble<T> where T: IComparable
    {
        public static T[] Sort(T[] coll)
        {
            bool sorted = false;
            while (!sorted)
            {
                bool noChanges = true;

                for (int i = 1; i < (coll.Count()); ++i)
                {
                    if (coll[i].CompareTo(coll[i - 1]) < 0)
                    {
                        T temp = coll[i];
                        coll[i] = coll[i - 1];
                        coll[i - 1] = temp;

                        noChanges = false;
                    }
                }

                if (noChanges == true)
                {
                    sorted = true;
                }
            }

            return coll;
        }
    }
}
