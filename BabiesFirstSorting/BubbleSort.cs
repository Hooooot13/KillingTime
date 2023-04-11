using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabiesFirstSorting
{
    public class BubbleSort
    {
        public void Bubblesort(int[] array)
        {
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] <= array[j + 1]) continue;
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    swapped = true;
                }
            }
        }
    }
}
