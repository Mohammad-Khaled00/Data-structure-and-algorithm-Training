namespace Data_structure_and_algorithm_course
{
    /* The main Idea is to either Write the index of the location in the array,
       eliminate half of the array,
       or Write not Found if the array did not contain the target value */
    public class BinarySearch<T> where T : IComparable<T>
    {
        public static void Search(T[] Array, T Target)
        {
            int min = 0;
            int max = Array.Length - 1;
            int time = 0;
            int guess = 0;
            while (min <= max)
            {
                guess = (min + max) / 2;
                time += 1;
                if (Array[guess].CompareTo(Target) == 0) 
                {
                    Console.WriteLine($"The number of steps it took to reach the value {Target} is {time} steps.");
                    Console.WriteLine($"The value's position is {guess + 1}. \n");
                    break;
                }

                else if (Array[guess].CompareTo(Target) < 0) 
                min = guess + 1;

                else
                max = guess - 1;
            }
            if (min > max)
            {
            Console.WriteLine($"The value {Target} was not found, but it can be added at index {guess + 1}. \n");
            }
        }
    }
}
