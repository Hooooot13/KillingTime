using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabiesFirstSorting
{
    public class QuickSort
    {
        public void quickSort(int[] array, int high, int low)
        {
            if ((low >= high) || (low < 0)) { return; }


            int P = partition(array, high, low);

            quickSort(array, P - 1, low);
            quickSort(array, high, P + 1);


        }

        public int partition(int[] array, int highIndex, int lowIndex)
        {

            int P = array[highIndex];

            int tempPivotindex = lowIndex - 1;
            int placeholder = -1;

            for (int i = lowIndex; i <= highIndex - 1; i++)
            {
                if (array[i] > P) continue;

                tempPivotindex++;
                placeholder = array[i];
                array[i] = array[tempPivotindex];
                array[tempPivotindex] = placeholder;
            }
            tempPivotindex = tempPivotindex + 1;
            array[highIndex] = array[tempPivotindex];
            array[tempPivotindex] = P;

            return tempPivotindex;
        }
    }

}
