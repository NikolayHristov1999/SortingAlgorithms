using System;
using System.Diagnostics;

namespace Algorithms
{
    public class StartUp
    {
        const int ARRAY_LENGTH = 10_000;
        static void Main(string[] args)
        {
            int[] arr = CreateArray(ARRAY_LENGTH);

            RunSortAlgorithm(BubbleSort.Sort, arr, nameof(BubbleSort));
            RunSortAlgorithm(SelectionSort.Sort, arr, nameof(SelectionSort));
            RunSortAlgorithm(InsertionSort.Sort, arr, nameof(InsertionSort));
            RunSortAlgorithm(MergeSort.Sort, arr, nameof(MergeSort));
            RunSortAlgorithm(QuickSort.Sort, arr, nameof(QuickSort));
            RunSortAlgorithm(RandomQuickSort.Sort, arr, nameof(RandomQuickSort));
            RunSortAlgorithm(CountingSort.Sort, arr, nameof(CountingSort));
            RunSortAlgorithm(RadixSort.Sort, arr, nameof(RadixSort));
        }
        /// <summary>
        ///     Function that invokes the given method for sorting array and measures the time for execution
        /// </summary>
        /// <param name="sortingMethod">The sorting algorithm that takes a massive as parameter</param>
        /// <param name="arr">The array to be sorted</param>
        /// <param name="name">Algorithm's name</param>
        private static void RunSortAlgorithm(Action<int[]> sortingMethod, int[] arr, string name)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            sortingMethod.Invoke(arr);
            stopwatch.Stop();
            Console.WriteLine($"{name} - time elapsed = {stopwatch.ElapsedMilliseconds} ms");

        }
        
        private static int[] CreateArray(int length)
        {
            int[] arr = new int[length];
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(0, length);
            }
            return arr;
        }

    }
}
