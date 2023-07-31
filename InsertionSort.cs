using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm_course
{
    internal class InsertionSort
    {
        public InsertionSort() { }
        public int[] Array { get; set; }
        public int Value { get; set; }
        public int LeftIndex { get; set; }

        public void Insert(int[] Array, int LeftIndex, int Value)
        {
            int i;
            for (i = LeftIndex; i >= 0 && Array[i] > Value; i--)
            {
                Array[i + 1] = Array[i];
            }
                Array[i + 1] = Value;
        }
        public void ISort(int[] Array)
        {
            for (int i = 1; i < Array.Length; i++)
            {
                Insert(Array, i-1, Array[i]);
            }

            Console.WriteLine($"The array AFTER Insertion Sorting:");
            for (int i = 0; i < Array.Length; i++)
            {
                if (i != Array.Length - 1)
                    Console.Write(Array[i] + ", ");
                else
                    Console.Write(Array[i] + ".\n");
            }
        }
    }
}
