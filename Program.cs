using System.Diagnostics;

namespace Data_structure_and_algorithm_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            BinarySearch search = new();
            search.DoBinarySearch(primes, 71);
            search.DoBinarySearch(primes, 55);

            int[] array = { 22, 11, 99, 88, 9, 7, 42, 25, 74, 36, 45, 77, 0, -3, 28 };
            Console.WriteLine("The array BEFORE Sorting:");
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                    Console.Write(array[i] + ", ");
                else
                    Console.Write(array[i] + ".\n");
            }

            InsertionSort InSort = new();
            Stopwatch stopwatch = new();
            stopwatch.Start();
            InSort.ISort(array);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed using Insertion sort: {0}", stopwatch.Elapsed);
        }
    }
}