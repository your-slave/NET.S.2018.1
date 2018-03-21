using System;

namespace Sorting
{
    /// <summary>
    /// Impliments static methods of Merge and Quick sort of int arrays
    /// </summary>
    public static class Sorting
    {
        /// <summary>
        /// Impliments Merge sort of int array
        /// </summary>
        /// <param name="arr"></param>
        public static void MergeSort(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));
            if (arr.Length == 0)
                throw new ArgumentException(nameof(arr));
            if (arr.Length == 1)
                return;
            MergeSort(arr, new int[arr.Length], 0, arr.Length - 1);
        }

        /// <summary>
        /// Recursion part of Merge sort algroithm
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="temp"></param>
        /// <param name="leftStart"></param>
        /// <param name="rightEnd"></param>
        private static void MergeSort(int[] arr, int[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
                return;
            int middle = (leftStart + rightEnd) / 2;
            MergeSort(arr, temp, leftStart, middle);
            MergeSort(arr, temp, middle + 1, rightEnd);
            MergeHalves(arr, temp, leftStart, rightEnd);
        }
        /// <summary>
        /// Meirging halves in Merge sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="temp"></param>
        /// <param name="leftStart"></param>
        /// <param name="rightEnd"></param>
        private static void MergeHalves(int[] arr, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;
            int left = leftStart;
            int right = rightStart;
            int index = leftStart;
            while (left <= leftEnd && right <= rightEnd)
            {
                if (arr[left] <= arr[right])
                {
                    temp[index] = arr[left];
                    left++;
                }
                else
                {
                    temp[index] = arr[right];
                    right++;
                }
                index++;
            }
            Array.Copy(arr, left, temp, index, leftEnd - left + 1);
            Array.Copy(arr, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, arr, leftStart, size);
        }

        /// <summary>
        /// Impliments Quick sort of int array
        /// </summary>
        /// <param name="arr"></param>
        public static void QuickSort(int[] arr)
        {
            // check for empty or null array

            if (arr == null)
                throw new ArgumentNullException(nameof(arr));
            if (arr.Length == 0)
                new ArgumentException(nameof(arr));
            if (arr.Length == 1)
                return;

            QuickSort(0, arr.Length - 1, arr);
        }

        /// <summary>
        /// Recursion aprt of Quick sort alorithm
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <param name="arr"></param>
        private static void QuickSort(int low, int high, int[] arr)
        {
            int i = low, j = high;

            int pivot = arr[low + (high - low) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(i, j, arr);
                    i++;
                    j--;
                }
            }

            if (low < j)
                QuickSort(low, j, arr);
            if (i < high)
                QuickSort(i, high, arr);
        }

        /// <summary>
        /// Swaping elements in int array
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="arr"></param>
        private static void Swap(int i, int j, int[] arr)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
