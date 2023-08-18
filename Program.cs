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
            BinarySearch<int>.Search(primes, 9);
            BinarySearch<int>.Search(primes, 4);
            BinarySearch<string>.Search(leters, "o");
            BinarySearch<string>.Search(leters, "s");
            BinaryStopwatch.Stop();
            Console.WriteLine($"Time elapsed using Binary Search: {BinaryStopwatch.Elapsed} \n");
            #endregion

            #endregion


            #region Sorting

            #region Testing Arrays
            int[] NumArray = { 22, 11, 99, 88, 9, 7, 42, 25, 74, 36, 45, 77, 0, -3, 28 };
            int[] NearlySorted = { 1, 2, 4, 5, 3, 6, 7, 9, 8, 10, 12, 11, 13, 15, 14 };
            int[] Reversed = { 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] FewUnique = { 1, 5, 8, 1, 5, 5, 1, 8, 1, 8, 8, 5, 1, 8, 1 };
            int[] NumArray2 = new int[NumArray.Length];
            int[] NumArray3 = new int[NumArray.Length];
            int[] NumArray4 = new int[NumArray.Length];
            int[] NearlySorted2 = new int[NumArray.Length];
            int[] NearlySorted3 = new int[NumArray.Length];
            int[] NearlySorted4 = new int[NumArray.Length];
            int[] Reversed2 = new int[NumArray.Length];
            int[] Reversed3 = new int[NumArray.Length];
            int[] Reversed4 = new int[NumArray.Length];
            int[] FewUnique2 = new int[NumArray.Length];
            int[] FewUnique3 = new int[NumArray.Length];
            int[] FewUnique4 = new int[NumArray.Length];
            string[] NameArray = { "Layla", "kamal", "tamer", "Hady", "Zyad", "fady", "dalya", "saad", "ali" };
            string[] NameArray2 = new string[NameArray.Length];
            string[] NameArray3 = new string[NameArray.Length];
            string[] NameArray4 = new string[NameArray.Length];
            Array.Copy(NumArray, NumArray2, NumArray.Length);
            Array.Copy(NumArray, NumArray3, NumArray.Length);
            Array.Copy(NumArray, NumArray4, NumArray.Length);
            Array.Copy(NearlySorted, NearlySorted2, NumArray.Length);
            Array.Copy(NearlySorted, NearlySorted3, NumArray.Length);
            Array.Copy(NearlySorted, NearlySorted4, NumArray.Length);
            Array.Copy(Reversed, Reversed2, NumArray.Length);
            Array.Copy(Reversed, Reversed3, NumArray.Length);
            Array.Copy(Reversed, Reversed4, NumArray.Length);
            Array.Copy(FewUnique, FewUnique2, NumArray.Length);
            Array.Copy(FewUnique, FewUnique3, NumArray.Length);
            Array.Copy(FewUnique, FewUnique4, NumArray.Length);
            Array.Copy(NameArray, NameArray2, NameArray.Length);
            Array.Copy(NameArray, NameArray3, NameArray.Length); 
            Array.Copy(NameArray, NameArray4, NameArray.Length);
            #endregion

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

            #region Quick Sorting
            Stopwatch QuickStopwatch = new();
            QuickStopwatch.Start();
            QuickSort<int>.Sort(NumArray3, 0, NumArray3.Length-1);
            QuickSort<string>.Sort(NameArray3, 0, NameArray3.Length-1);
            QuickStopwatch.Stop();

            Console.WriteLine("The array AFTER Quick Sorting:");
            ArrayPrinting<int>.Print(NumArray3);
            ArrayPrinting<string>.Print(NameArray3);
            Console.WriteLine($"Time elapsed using Quick Sort: {QuickStopwatch.Elapsed} \n");
            #endregion

            #region Enhanced Quick
            Stopwatch EnhancedQuickStopwatch = new();
            EnhancedQuickStopwatch.Start();
            QuickSort<int>.Sort(NumArray4, 0, NumArray4.Length - 1);
            QuickSort<string>.Sort(NameArray4, 0, NameArray4.Length - 1);
            EnhancedQuickStopwatch.Stop();

            Console.WriteLine("The array AFTER Enhanced Quick Sorting:");
            ArrayPrinting<int>.Print(NumArray4);
            ArrayPrinting<string>.Print(NameArray4);
            Console.WriteLine($"Time elapsed using Enhanced Quick Sort: {EnhancedQuickStopwatch.Elapsed} \n");
            #endregion

            #endregion
        }
    }
}