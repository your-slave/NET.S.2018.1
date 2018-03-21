using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Tests
{
    [TestClass]
    class QuickSortTests
    {
        [TestMethod]
        public void QuickSort_SimpleArrayWithEvenLength_Sorted()
        {
            int[] testData = { 7, 18, 94, 2, 3, 5, 8, 1 };
            int[] expectedData = { 1, 2, 3, 5, 7, 8, 18, 94 };

            Sorting.QuickSort(testData);

            CollectionAssert.AreEqual(testData, expectedData);
        }

        [TestMethod]
        public void QuickSort_SimpleArrayWithOddLength_Sorted()
        {
            int[] testData = { 7, 18, 94, 2, 1, 3, 5, 5, 8 };
            int[] expectedData = { 1, 2, 3, 5, 5, 7, 8, 18, 94 };

            Sorting.QuickSort(testData);

            CollectionAssert.AreEqual(testData, expectedData);
        }

        [TestMethod]
        public void QuickSort_ArrayWithReverseOrderOfSort_Sorted()
        {
            int[] testData = { 94, 18, 8, 7, 5, 5, 3, 2, 1 };
            int[] expectedData = { 1, 2, 3, 5, 5, 7, 8, 18, 94 };

            Sorting.QuickSort(testData);

            CollectionAssert.AreEqual(testData, expectedData);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_NullArray_ExceptionThrown()
        {
            Sorting.QuickSort(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void QuickSort_EmptyArray_ExceptionThrown()
        {
            Sorting.QuickSort(new int[0]);
        }
    }
}
