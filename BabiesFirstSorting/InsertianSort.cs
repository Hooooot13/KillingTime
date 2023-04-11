using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabiesFirstSorting
{
    public class InsertianSort
    {
        public void insertainSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j-1] > array[j])
                    {
                        (array[j], array[j-1]) = (array[j-1], array[j]);
                    }
                }
            }
        }
        public void insertainSort(int[] array, int startIndex, int stopIndex)
        {
            for (int i = startIndex; i < stopIndex; i++)
            {
                for (int j = i; j > startIndex; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    }
                }
            }
        }

    }
}
