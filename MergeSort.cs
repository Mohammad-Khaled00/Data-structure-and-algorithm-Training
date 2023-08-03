namespace Data_structure_and_algorithm_course
{
    public class MergeSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] Array)
        {
            if (Array.Length <= 1)
            {
                return;
            }

            int middle = Array.Length / 2;

            T[] lowHalf = new T[middle];
            T[] highHalf = new T[Array.Length - middle];

            System.Array.Copy(Array, 0, lowHalf, 0, middle);
            System.Array.Copy(Array, middle, highHalf, 0, Array.Length - middle);

            Sort(lowHalf);
            Sort(highHalf);

            Merge(Array, lowHalf, highHalf);
        }

        private static void Merge(T[] Array, T[] lowHalf, T[] highHalf)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < lowHalf.Length && j < highHalf.Length)
            {
                if (lowHalf[i].CompareTo(highHalf[j]) <= 0)
                {
                    Array[k] = lowHalf[i];
                    i++;
                }
                else
                {
                    Array[k] = highHalf[j];
                    j++;
                }

                k++;
            }

            while (i < lowHalf.Length)
            {
                Array[k] = lowHalf[i];
                i++;
                k++;
            }

            while (j < highHalf.Length)
            {
                Array[k] = highHalf[j];
                j++;
                k++;
            }
        }
    }
}
