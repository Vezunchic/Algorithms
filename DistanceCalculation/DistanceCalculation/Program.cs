using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using System;

namespace DistanceCalculation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Начало программы");
           
            string path = Environment.CurrentDirectory;
            var result = BenchmarkRunner.Run<BechmarkClass>();
           
       
        }


    }
}
