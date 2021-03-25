using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class RadixSort
    {
        private const int DECIMAL_NUMBER = 10;
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
            Queue<int>[] bucket = new Queue<int>[DECIMAL_NUMBER];
            for (int i = 0; i < DECIMAL_NUMBER; i++)
            {
                bucket[i] = new Queue<int>();
            }
            //The first divider is one and after each loop it is multiplied with 10
            int lastDivider = 1;
            while (lastDivider <= max)
            {
                //Enqueue each element to the respective index in the arrray
                for (int i = 0; i < arr.Length; i++)
                {
                    int index = (arr[i] / lastDivider) % 10;
                    bucket[index].Enqueue(arr[i]);
                }
                //while bucked is non empty, restore the element to the array
                for (int i = 0, index = 0; i < bucket.Length; i++)
                {
                    while(bucket[i].Count > 0)
                    {
                        arr[index] = bucket[i].Dequeue();
                        index++;
                    }
                }
                lastDivider *= 10;

            }                                 
            
        }
        private static void CountingSort(int[] Array, int place)
        {
            int n = Array.Length;
            int[] output = new int[n];

            //range of the number is 0-9 for each place considered.
            int[] freq = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //count number of occurrences in freq array
            for (int i = 0; i < n; i++)
                freq[(Array[i] / place) % 10]++;

            //Change count[i] so that count[i] now contains actual 
            //position of this digit in output[] 
            for (int i = 1; i < 10; i++)
                freq[i] += freq[i - 1];

            //Build the output array 
            for (int i = n - 1; i >= 0; i--)
            {
                output[freq[(Array[i] / place) % 10] - 1] = Array[i];
                freq[(Array[i] / place) % 10]--;
            }

            //Copy the output array to the input Array, Now the Array will 
            //contain sorted array based on digit at specified place
            for (int i = 0; i < n; i++)
                Array[i] = output[i];
        }
    }
}
