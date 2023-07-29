namespace Data_structure_and_algorithm_course
{
    /* The main Idea is to either Write the index of the location in the array,
       eliminate half of the array,
       or Write not Found if the array did not contain the target value */
    internal class BinarySearch
    {
        public BinarySearch()
        {
            
        }
        public int[] Array { get; set; }
        public int Target { get; set; }
        public void DoBinarySearch(int[] Array, int Target)
        {
            int min = 0;
            int max = Array.Length - 1;
            double guess;
            int targetIndex;
            int time = 0;
            while (min <= max)
            {
                guess = (min + max) / 2;
                targetIndex = (int)Math.Floor(guess);
                time += 1;
                if (Array[targetIndex] == Target) 
                {
                    Console.WriteLine($"The number of steps it took to reach the value is {time}");
                    Console.WriteLine($"The value index is {targetIndex +1}");
                    break;
                }

                else if (Array[targetIndex] < Target) 
                min = targetIndex + 1;

                else
                max = targetIndex - 1;
            }
            if (min > max)
            {
            Console.WriteLine($"The number {Target} is not found");
            }
        }
    }
}
