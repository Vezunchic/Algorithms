using BenchmarkDotNet.Running;
using System;

namespace TreesHashSet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Начало программы");
            var result = BenchmarkRunner.Run<BechmarkClass>();
            Console.WriteLine("Нажмите клавишу ");
            Console.ReadKey();
        }
    }
}
