using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabiesFirstSorting.UnitTest
{
    internal class arrayGenerators
    {
        public int[] arrayUnsorter(int[] array)
        {
            Random rnd = new Random();

            int newIndex = 0;
            int[] unsortedArray = new int[array.Length];

            array.CopyTo(unsortedArray, 0);

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                newIndex = rnd.Next(unsortedArray.Length);
                (unsortedArray[i], unsortedArray[newIndex]) = (unsortedArray[newIndex], unsortedArray[i]);
            }

            return unsortedArray;
        }

        public int[] intArrayGen(int length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }

            return array;
        }

        public int[] arrayInverter(int[] array)
        {
            int[] newArray = new int[array.Length];
            array.CopyTo(newArray, 0);

            for (int i = 0; i < newArray.Length / 2; i++)
            {
                (newArray[i], newArray[newArray.Length - 1 - i]) = (newArray[newArray.Length - 1 - i], newArray[i]);
            }

            return newArray;
        }
    }
}
