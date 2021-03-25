using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorithms
{
    public static class InsertionSort
    {
        /// <summary>
        ///     Simple algorithm (Splitter into sorted and unsorted part) - values from the unsorted part of the array are picked and placed into the sorted part of the array
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int[] coppiedArray = (int[])arr.Clone();

            for (int i = 1; i < coppiedArray.Length; i++)
            {
                int num = coppiedArray[i];
                int j = i - 1;
                while (j >= 0 && coppiedArray[j] > num)
                {
                    coppiedArray[j + 1] = coppiedArray[j];
                    j = j - 1;
                }
                coppiedArray[j + 1] = num;
            }

        }
    }
}
