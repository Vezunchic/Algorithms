using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("начало программы");
            int searchValue = 4;
            int[] number = { 1, 2, 3, 4, 10, 20, 15,22,41,14,151,62,26,26};
           int result = BinarySearch(number, searchValue);
        }
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max) // O(N)
            {
                int mid = (min + max) / 2; //O(n/2)
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])//O(n/2^2) или O(n/2^i) i - количество интераций 
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }//так как после полного заверщения цикла остается 1 число O(n/2^i = 1) или  O(n = 2^i)
        // Сложность бинарного поиска равна log2 (n) = i или log2 (n)
    }
}
