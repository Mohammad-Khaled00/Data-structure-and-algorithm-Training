using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm_course
{
    public class InsertionSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] Array)
        {
            for (int i = 1; i < Array.Length; i++)
            {
                Insert(Array, i - 1, Array[i]);
            }

            Console.WriteLine("The array AFTER Insertion Sorting:");
            for (int i = 0; i < Array.Length; i++)
            {
                if (i != Array.Length - 1)
                    Console.Write(Array[i] + ", ");
                else
                    Console.Write(Array[i] + ".\n");
            }
        }
        private static void Insert(T[] Array, int LeftIndex, T Value)
        {
            int i;
            for (i = LeftIndex; i >= 0 && Array[i].CompareTo(Value) > 0; i--)
            {
                Array[i + 1] = Array[i];
            }
                Array[i + 1] = Value;
        }
    }
}
