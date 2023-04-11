using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabiesFirstSorting
{
    public class TimSort
    {
        public InsertianSort insertianSort { get; set; }
        public MergeSort mergeSort { get; set; }
        public RandomJunk junk { get; set; }
        public TimSort()
        {
            insertianSort = new InsertianSort();
            mergeSort = new MergeSort();
            junk = new RandomJunk();
        }
        //TODO: Make it work.
        //There is a problem with the remainder algoithem I think. It doen't completly merge correctly is there is any remainder in the run.
        public void timSort(int[] array, int Run)
        {
            int remainder = array.Length % Run;

            //divide into sub arrays
            for (int j = 0; j < array.Length - remainder; j += Run)
            {
                insertianSort.insertainSort(array, j, j + Run);
            }
            if (remainder > 0)
            {
                insertianSort.insertainSort(array, array.Length - remainder, array.Length - 1);
            }
            junk.arrayPrinter(array);

            //TODO: Merge Runs

        }
    }
}
