namespace Data_structure_and_algorithm_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            BinarySearch search = new();
            search.DoBinarySearch(primes, 71);
            search.DoBinarySearch(primes, 17);
            search.DoBinarySearch(primes, 55);
        }
    }
}