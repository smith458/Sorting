using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //First value is already "sorted". Takes the next value and puts it in place, shifting all numbers up
    //to its old index. Continues through the array once.
    public class Insert<T> where T : IComparable
    {
        public static T[] Sort(T[] coll)
        {
            for (int i =  1; i < coll.Count(); ++i)             //Step through array
            {
                if (coll[i].CompareTo(coll[i-1]) < 0)           //Checking if in place
                {
                    for (int j = 0; j < i; ++j)                 //Finding where it should be
                    {
                        if (coll[i].CompareTo(coll[j]) < 0)     //Checking if correct place
                        {
                            T temp = coll[i];                   //Saving current number

                            for (int k = i; k > j; --k)         //Moving numbers up to make room
                            {
                                coll[k] = coll[k - 1];
                            }

                            coll[j] = temp;                     //Putting current number in place
                        }
                    }
                }
            }

            return coll;                                        //Return sorted collection
        }
    }
}
