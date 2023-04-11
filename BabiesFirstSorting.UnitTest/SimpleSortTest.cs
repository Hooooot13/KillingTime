using NUnit.Framework;
using BabiesFirstSorting;
using System.Security.Cryptography.X509Certificates;
using System.Buffers;

namespace BabiesFirstSorting.UnitTest
{
    public class SortTest
    {
        public int[] sortedArrayN10;
        public int[] sortedArrayN100;
        public int[] sortedArrayN1000;
        public int[] sortedArrayN10000;

        public int[] unsortedArrayN10;
        public int[] unsortedArrayN100;
        public int[] unsortedArrayN1000;
        public int[] unsortedArrayN10000;

        public int[] worstArrayN10;
        public int[] worstArrayN100;
        public int[] worstArrayN1000;
        public int[] worstArrayN10000;


        public SortTest()
        {
        }

        [SetUp]
        public void setup()
        {
            var _sortTest = new arrayGenerators();

            sortedArrayN10 = _sortTest.intArrayGen(10);
            sortedArrayN100 = _sortTest.intArrayGen(100);
            sortedArrayN1000 = _sortTest.intArrayGen(1000);
            sortedArrayN10000 = _sortTest.intArrayGen(10000);

            unsortedArrayN10 = _sortTest.arrayUnsorter(sortedArrayN10);
            unsortedArrayN100 = _sortTest.arrayUnsorter(sortedArrayN100);
            unsortedArrayN1000 = _sortTest.arrayUnsorter(sortedArrayN1000);
            unsortedArrayN10000 = _sortTest.arrayUnsorter(sortedArrayN10000);

            worstArrayN10 = _sortTest.arrayInverter(sortedArrayN10);
            worstArrayN100 = _sortTest.arrayInverter(sortedArrayN100);
            worstArrayN1000 = _sortTest.arrayInverter(sortedArrayN1000);
            worstArrayN10000 = _sortTest.arrayInverter(sortedArrayN10000);
        }

        [TestCase(new int[] { 10, 1, 3, 4, 2, 7, 9, 8, 6, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void BubbleSort_GivenUnsortedIntArray_ReturnSortedArray(int[] unsortedArray, int[] expectedResult)
        {
            var uut = new BabiesFirstSorting.BubbleSort();
            uut.Bubblesort(unsortedArray);

            Assert.That(unsortedArray, Is.EqualTo(expectedResult));
        }

        [Test]
        public void BubbleSort_GivenFourRandomlySortedArrays_ReturnfourSortedArrays()
        {
            var uut = new BabiesFirstSorting.BubbleSort();

            int[] testArray10 = new int[unsortedArrayN10.Length];
            int[] testArray100 = new int[unsortedArrayN100.Length];
            int[] testArray1000 = new int[unsortedArrayN1000.Length];
            int[] testArray10000 = new int[unsortedArrayN10000.Length];

            unsortedArrayN10.CopyTo(testArray10, 0);
            unsortedArrayN100.CopyTo(testArray100, 0);
            unsortedArrayN1000.CopyTo(testArray1000, 0);
            unsortedArrayN10000.CopyTo(testArray10000, 0);


            uut.Bubblesort(testArray10);
            uut.Bubblesort(testArray100);
            uut.Bubblesort(testArray1000);
            uut.Bubblesort(testArray10000);


            Assert.That(testArray10, Is.EqualTo(sortedArrayN10));
            Assert.That(testArray100, Is.EqualTo(sortedArrayN100));
            Assert.That(testArray1000, Is.EqualTo(sortedArrayN1000));
            Assert.That(testArray10000, Is.EqualTo(sortedArrayN10000));
        }

        [Test]
        public void BubbleSort_GivenFourWorstArrays_ReturnSortedArrays()
        {
            var uut = new BabiesFirstSorting.BubbleSort();

            int[] testArray10 = new int[unsortedArrayN10.Length];
            int[] testArray100 = new int[unsortedArrayN100.Length];
            int[] testArray1000 = new int[unsortedArrayN1000.Length];
            int[] testArray10000 = new int[unsortedArrayN10000.Length];

            worstArrayN10.CopyTo(testArray10, 0);
            worstArrayN100.CopyTo(testArray100, 0);
            worstArrayN1000.CopyTo(testArray1000, 0);
            worstArrayN10000.CopyTo(testArray10000, 0);

            uut.Bubblesort(testArray10);
            uut.Bubblesort(testArray100);
            uut.Bubblesort(testArray1000);
            uut.Bubblesort(testArray10000);

            Assert.That(testArray10, Is.EqualTo(sortedArrayN10));
            Assert.That(testArray100, Is.EqualTo(sortedArrayN100));
            Assert.That(testArray1000, Is.EqualTo(sortedArrayN1000));
            Assert.That(testArray10000, Is.EqualTo(sortedArrayN10000));
        }

        [TestCase(new int[] { 10, 1, 3, 4, 2, 7, 9, 8, 6, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void quickSort_GivenUnsortedIntArray_ReturnSortedArray(int[] unsortedArray, int[] expectedResult)
        {
            var uut = new BabiesFirstSorting.QuickSort();


            uut.quickSort(unsortedArray, unsortedArray.Length - 1, 0);


            Assert.That(unsortedArray, Is.EqualTo(expectedResult));
        }

        [Test]
        public void QuickSort_GivenFourRandomlySortedArrays_ReturnfourSortedArrays()
        {
            var uut = new BabiesFirstSorting.QuickSort();

            int[] testArray10 = new int[unsortedArrayN10.Length];
            int[] testArray100 = new int[unsortedArrayN100.Length];
            int[] testArray1000 = new int[unsortedArrayN1000.Length];
            int[] testArray10000 = new int[unsortedArrayN10000.Length];

            unsortedArrayN10.CopyTo(testArray10, 0);
            unsortedArrayN100.CopyTo(testArray100, 0);
            unsortedArrayN1000.CopyTo(testArray1000, 0);
            unsortedArrayN10000.CopyTo(testArray10000, 0);

            
            uut.quickSort(testArray10, testArray10.Length - 1, 0);
            uut.quickSort(testArray100, testArray100.Length - 1, 0);
            uut.quickSort(testArray1000, testArray1000.Length - 1, 0);
            uut.quickSort(testArray10000, testArray10000.Length - 1, 0);


            Assert.That(testArray10, Is.EqualTo(sortedArrayN10));
            Assert.That(testArray100, Is.EqualTo(sortedArrayN100));
            Assert.That(testArray1000, Is.EqualTo(sortedArrayN1000));
            Assert.That(testArray10000, Is.EqualTo(sortedArrayN10000));
        }

        [Test]
        public void QuickSort_GivenFourWorstArrays_ReturnSortedArrays()
        {
            var uut = new BabiesFirstSorting.QuickSort();

            int[] testArray10 = new int[unsortedArrayN10.Length];
            int[] testArray100 = new int[unsortedArrayN100.Length];
            int[] testArray1000 = new int[unsortedArrayN1000.Length];
            int[] testArray10000 = new int[unsortedArrayN10000.Length];

            worstArrayN10.CopyTo(testArray10, 0);
            worstArrayN100.CopyTo(testArray100, 0);
            worstArrayN1000.CopyTo(testArray1000, 0);
            worstArrayN10000.CopyTo(testArray10000, 0);


            uut.quickSort(testArray10, testArray10.Length - 1, 0);
            uut.quickSort(testArray100, testArray100.Length - 1, 0);
            uut.quickSort(testArray1000, testArray1000.Length - 1, 0);
            uut.quickSort(testArray10000, testArray10000.Length - 1, 0);


            Assert.That(testArray10, Is.EqualTo(sortedArrayN10));
            Assert.That(testArray100, Is.EqualTo(sortedArrayN100));
            Assert.That(testArray1000, Is.EqualTo(sortedArrayN1000));
            Assert.That(testArray10000, Is.EqualTo(sortedArrayN10000));
        }

        [TestCase(new int[] { 10, 1, 3, 4, 2, 7, 9, 8, 6, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void insertainSort_GivenUnsortedIntArray_ReturnSortedArray(int[] unsortedArray, int[] expectedResult)
        {
            var uut = new BabiesFirstSorting.InsertianSort();


            uut.insertainSort(unsortedArray);


            Assert.That(unsortedArray, Is.EqualTo(expectedResult));
        }

        [Test]
        public void insertainSort_GivenFourRandomlySortedArrays_ReturnfourSortedArrays()
        {
            var uut = new BabiesFirstSorting.InsertianSort();

            int[] testArray10 = new int[unsortedArrayN10.Length];
            int[] testArray100 = new int[unsortedArrayN100.Length];
            int[] testArray1000 = new int[unsortedArrayN1000.Length];
            int[] testArray10000 = new int[unsortedArrayN10000.Length];

            unsortedArrayN10.CopyTo(testArray10, 0);
            unsortedArrayN100.CopyTo(testArray100, 0);
            unsortedArrayN1000.CopyTo(testArray1000, 0);
            unsortedArrayN10000.CopyTo(testArray10000, 0);


            uut.insertainSort(testArray10);
            uut.insertainSort(testArray100);
            uut.insertainSort(testArray1000);
            uut.insertainSort(testArray10000);


            Assert.That(testArray10, Is.EqualTo(sortedArrayN10));
            Assert.That(testArray100, Is.EqualTo(sortedArrayN100));
            Assert.That(testArray1000, Is.EqualTo(sortedArrayN1000));
            Assert.That(testArray10000, Is.EqualTo(sortedArrayN10000));
        }

        [Test]
        public void insertainSort_GivenFourWorstArrays_ReturnSortedArrays()
        {
            var uut = new BabiesFirstSorting.InsertianSort();

            int[] testArray10 = new int[unsortedArrayN10.Length];
            int[] testArray100 = new int[unsortedArrayN100.Length];
            int[] testArray1000 = new int[unsortedArrayN1000.Length];
            int[] testArray10000 = new int[unsortedArrayN10000.Length];

            worstArrayN10.CopyTo(testArray10, 0);
            worstArrayN100.CopyTo(testArray100, 0);
            worstArrayN1000.CopyTo(testArray1000, 0);
            worstArrayN10000.CopyTo(testArray10000, 0);


            uut.insertainSort(testArray10);
            uut.insertainSort(testArray100);
            uut.insertainSort(testArray1000);
            uut.insertainSort(testArray10000);


            Assert.That(testArray10, Is.EqualTo(sortedArrayN10));
            Assert.That(testArray100, Is.EqualTo(sortedArrayN100));
            Assert.That(testArray1000, Is.EqualTo(sortedArrayN1000));
            Assert.That(testArray10000, Is.EqualTo(sortedArrayN10000));
        }

        [TestCase(new int[] { 10, 1, 3, 4, 2, 7, 9, 8, 6, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void timSort_GivenUnsortedIntArray_ReturnSortedArray(int[] unsortedArray, int[] expectedResult)
        {
            var uut = new BabiesFirstSorting.TimSort();


            uut.timSort(unsortedArray, 5);


            Assert.That(unsortedArray, Is.EqualTo(expectedResult));
        }
        [Test]
        public void timSort_GivenFourRandomlySortedArrays_ReturnfourSortedArrays()
        {
            var uut = new BabiesFirstSorting.TimSort();

            int[] testArray10 = new int[unsortedArrayN10.Length];
            int[] testArray100 = new int[unsortedArrayN100.Length];
            int[] testArray1000 = new int[unsortedArrayN1000.Length];
            int[] testArray10000 = new int[unsortedArrayN10000.Length];

            unsortedArrayN10.CopyTo(testArray10, 0);
            unsortedArrayN100.CopyTo(testArray100, 0);
            unsortedArrayN1000.CopyTo(testArray1000, 0);
            unsortedArrayN10000.CopyTo(testArray10000, 0);


            uut.timSort(testArray10, 5);
            uut.timSort(testArray100, 32);
            uut.timSort(testArray1000, 32);
            uut.timSort(testArray10000, 32);


            Assert.That(testArray10, Is.EqualTo(sortedArrayN10));
            Assert.That(testArray100, Is.EqualTo(sortedArrayN100));
            Assert.That(testArray1000, Is.EqualTo(sortedArrayN1000));
            Assert.That(testArray10000, Is.EqualTo(sortedArrayN10000));
        }

        [Test]
        public void timSort_GivenFourWorstArrays_ReturnSortedArrays()
        {
            var uut = new BabiesFirstSorting.TimSort();

            int[] testArray10 = new int[unsortedArrayN10.Length];
            int[] testArray100 = new int[unsortedArrayN100.Length];
            int[] testArray1000 = new int[unsortedArrayN1000.Length];
            int[] testArray10000 = new int[unsortedArrayN10000.Length];

            worstArrayN10.CopyTo(testArray10, 0);
            worstArrayN100.CopyTo(testArray100, 0);
            worstArrayN1000.CopyTo(testArray1000, 0);
            worstArrayN10000.CopyTo(testArray10000, 0);


            uut.timSort(testArray10, 4);
            uut.timSort(testArray100, 32);
            uut.timSort(testArray1000, 32);
            uut.timSort(testArray10000, 32);


            Assert.That(testArray10, Is.EqualTo(sortedArrayN10));
            Assert.That(testArray100, Is.EqualTo(sortedArrayN100));
            Assert.That(testArray1000, Is.EqualTo(sortedArrayN1000));
            Assert.That(testArray10000, Is.EqualTo(sortedArrayN10000));
        }
    }
}