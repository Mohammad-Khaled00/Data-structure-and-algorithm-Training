using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm_course
{
    internal class ArrayPrinting<T>
    {
        public static void Print(T[] Array)
        {
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
