using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Метод рекурсии:  {FibonacciRecursion(number)}");

            Console.WriteLine($"Метод цикла: {Fibonacci(number)}");
        }



        private static int FibonacciRecursion(int number)
        {

            if (number <= 1)
            {
                return number;
            }

            return FibonacciRecursion(number - 1) + FibonacciRecursion(number - 2);
        }
        private static int Fibonacci(int number)
        {
            int fibonacсi = 0;
            int fibonacсi1 = 1;
            int fibonacсi2 = 0;
            if (number == 0)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }
            for (int i = 2; i <= number; i++)
            {

                fibonacсi = fibonacсi1 + fibonacсi2;
                fibonacсi2 = fibonacсi1;
                fibonacсi1 = fibonacсi;

            }
            return fibonacсi;
        }

    }
}
