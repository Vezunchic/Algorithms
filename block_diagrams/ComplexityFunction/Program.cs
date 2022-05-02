using System;

namespace ComplexityFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        /// <summary>
        /// сложность функции О(N^3) три цикла for, а каждый for = О(N) пересматривает все N элементы массива. if пренебрегаем так как это постоянный множитель согластно 5 правилу.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; // О(1)
            for (int i = 0; i < inputArray.Length; i++) //О(N)
            {
                for (int j = 0; j < inputArray.Length; j++)// O(N)
                {

                    for (int k = 0; k < inputArray.Length; k++)//O(N)
                    {
                        int y = 0; 
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;// O(1)
        }
    }
}
