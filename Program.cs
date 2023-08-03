using System.Diagnostics;

namespace Data_structure_and_algorithm_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Searching

            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            string[] leters = { "e", "i", "o", "p", "q", "r", "t", "u", "w", "y", "z" };

            #region Binary Search
            Stopwatch BinaryStopwatch = new();
            BinaryStopwatch.Start();
            BinarySearch<int>.Search(primes, 71);
            BinarySearch<int>.Search(primes, 55);
            BinarySearch<string>.Search(leters, "o");
            BinarySearch<string>.Search(leters, "s");
            BinaryStopwatch.Stop();
            Console.WriteLine($"Time elapsed using Binary Search: {BinaryStopwatch.Elapsed} \n");  
            #endregion

            #endregion


            #region Sorting

            int[] NumArray = { 22, 11, 99, 88, 9, 7, 42, 25, 74, 36, 45, 77, 0, -3, 28 };
            string[] NameArray = { "Layla", "kamal", "tamer", "Hady", "Zyad", "fady", "dalya", "saad", "ali" };
            int[] NumArray2 = new int[NumArray.Length];
            string[] NameArray2 = new string[NameArray.Length];
            Array.Copy(NumArray, NumArray2, NumArray.Length);
            Array.Copy(NameArray, NameArray2, NameArray.Length);

            Console.WriteLine("The arrays BEFORE Sorting:");
            ArrayPrinting<int>.Print(NumArray);
            ArrayPrinting<string>.Print(NameArray);
            Console.WriteLine("");

            #region Insertion Sorting

            Stopwatch InsertionStopwatch = new();
            InsertionStopwatch.Start();
            InsertionSort<int>.Sort(NumArray);
            InsertionSort<string>.Sort(NameArray);
            InsertionStopwatch.Stop();

            Console.WriteLine("The array AFTER Insertion Sorting:");
            ArrayPrinting<int>.Print(NumArray);
            ArrayPrinting<string>.Print(NameArray);
            Console.WriteLine($"Time elapsed using Insertion Sort: {InsertionStopwatch.Elapsed} \n");
            #endregion

            #region Merge Sorting

            Stopwatch MergeStopwatch = new();
            MergeStopwatch.Start();
            MergeSort<int>.Sort(NumArray2);
            MergeSort<string>.Sort(NameArray2);
            MergeStopwatch.Stop();

            Console.WriteLine("The array AFTER Merge Sorting:");
            ArrayPrinting<int>.Print(NumArray2);
            ArrayPrinting<string>.Print(NameArray2);
            Console.WriteLine($"Time elapsed using Merge Sort: {MergeStopwatch.Elapsed} \n");
            #endregion

            #endregion
        }
    }
}