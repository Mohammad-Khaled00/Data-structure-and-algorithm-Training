using System.Reflection;

namespace Data_structure_and_algorithm_course
{
    public class EnhancedQuickSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                Sort(array, left, pivot - 1);
                Sort(array, pivot + 1, right);
            }
        }

        public static int Partition(T[] array, int left, int right)
        {
            // the median of three elements from the subarray

            if ((array[(left+right)/2].CompareTo(array[left]) > 0 && array[(left + right) / 2].CompareTo(array[right]) < 0) || (array[(left + right) / 2].CompareTo(array[left]) < 0 && array[(left + right) / 2].CompareTo(array[right]) > 0))
                (array[right], array[(left + right) / 2]) = (array[(left + right) / 2], array[right]);

            else if ((array[left].CompareTo(array[(left + right) / 2]) > 0 && array[left].CompareTo(array[right]) < 0) || (array[left].CompareTo(array[(left + right) / 2]) < 0 && array[left].CompareTo(array[right]) > 0))
                (array[left], array[right]) = (array[right], array[left]);


            int pivot = left;
            int i;
            for (i = left; i < right; i++)
            {
                if (array[i].CompareTo(array[right]) <= 0)
                {
                    (array[pivot], array[i]) = (array[i], array[pivot]);
                    pivot++;
                }
            }
            (array[pivot], array[i]) = (array[i], array[pivot]);
            return pivot;
        }
    }
}
