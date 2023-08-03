using System.Diagnostics;

namespace Data_structure_and_algorithm_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            string[] leters = {"e", "i", "o", "p", "q", "r", "t", "u", "w", "y", "z"};
            Stopwatch BinaryStopwatch = new();
            BinaryStopwatch.Start();
            BinarySearch<int>.Search(primes, 71);
            BinarySearch<int>.Search(primes, 55); 
            BinarySearch<string>.Search(leters, "o");
            BinarySearch<string>.Search(leters, "s");
            BinaryStopwatch.Stop();
            Console.WriteLine("Time elapsed using Binary Search: {0}", BinaryStopwatch.Elapsed);

            int[] NumArray = { 22, 11, 99, 88, 9, 7, 42, 25, 74, 36, 45, 77, 0, -3, 28 };
            string[] NameArray = { "Layla", "kamal", "tamer", "Hady", "Zyad", "fady", "dalya", "saad", "ali" };

            //Console.WriteLine("The array BEFORE Sorting:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (i != array.Length - 1)
            //        Console.Write(array[i] + ", ");
            //    else
            //        Console.Write(array[i] + ".\n");
            //}

            Stopwatch InsertionStopwatch = new();
            InsertionStopwatch.Start();
            InsertionSort<int>.Sort(NumArray);
            InsertionSort<string>.Sort(NameArray);
            InsertionStopwatch.Stop();
            Console.WriteLine("Time elapsed using Insertion Sort: {0}", InsertionStopwatch.Elapsed);
        }
    }
}