using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Tests
{
    [TestClass]
    class MergeSortTests
    {
        [TestMethod]
        public void MergeSort_SimpleArrayWithEvenLength_Sorted()
        {
            int[] testData = { 7, 18, 94, 2, 3, 5, 8, 1 };
            int[] expectedData = { 1, 2, 3, 5, 7, 8, 18, 94 };

            Sorting.MergeSort(testData);

            CollectionAssert.AreEqual(testData, expectedData);
        }

        [TestMethod]
        public void MergeSort_SimpleArrayWithOddLength_Sorted()
        {
            int[] testData = { 7, 18, 94, 2, 1, 3, 5, 5, 8};
            int[] expectedData = { 1, 2, 3, 5, 5, 7, 8, 18, 94};

            Sorting.MergeSort(testData);

            CollectionAssert.AreEqual(testData, expectedData);
        }

        [TestMethod]
        public void MergeSort_ArrayWithReverseOrderOfSort_Sorted()
        {
            int[] testData = { 94, 18, 8, 7, 5, 5, 3, 2, 1 };
            int[] expectedData = { 1, 2, 3, 5, 5, 7, 8, 18, 94 };

            Sorting.MergeSort(testData);

            CollectionAssert.AreEqual(testData, expectedData);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSort_NullArray_ExceptionThrown()
        { 
            Sorting.MergeSort(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MergeSort_EmptyArray_ExceptionThrown()
        {
            Sorting.MergeSort(new int[0]);
        }
    }
}
