using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    /// <summary>
    ///     Very fast algorithm(problems occur when the max number in the array is big)
    /// </summary>
    public static class CountingSort
    {
        public static void Sort(int[] arr)
        {
            int[] coppiedArray = (int[])arr.Clone();
            int max = coppiedArray.Max();
            Sort(coppiedArray, max);

            //Uncomment to see the sorted array
            //Console.WriteLine(string.Join(", ", coppiedArray));
        }
        private static void Sort(int[] arr, int max)
        {
            //Create array with length of the maximum integer in the array + 1
            int[] tmpArr = new int[max + 1];
            //Add + 1 on every number to its respective index
            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = arr[i];
                tmpArr[tmp]++;
            }

            int index = 0;
            //restore the elements to the array
            for (int i = 0; i < tmpArr.Length; i++)
            {
                while (tmpArr[i] > 0)
                {
                    arr[index] = i;
                    tmpArr[i]--;
                    index++;
                }
            }
        }
    }
}
