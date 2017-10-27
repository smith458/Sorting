using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //Divides array in half recursively until each piece has one index. Combines them into pairs
    //sorting the pairs. It contines to combine and sort until you have a sorted full array
    public class Merge<T> where T : IComparable
    {
        public static T[] Sort(T[] coll)
        {
            int len = coll.Length;
            if (len > 1)
            {
                T[] first = Sort(coll.Take(len / 2).ToArray());
                T[] last = Sort(coll.Skip(len / 2).Take(len - len / 2).ToArray());

                for (int i = 0; i < len / 2; ++i)
                {
                    coll[i] = first[i];
                }

                for (int i = 0; i < (len - len / 2); ++i)
                {
                    coll[i + len / 2] = last[i];
                }

                return Selection<T>.Sort(coll);
            }
            else
            {
                return coll;
            }
        }
    }
}
