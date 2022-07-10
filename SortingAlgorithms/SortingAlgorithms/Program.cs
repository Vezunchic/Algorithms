using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало программы!");
            int[] arr = new int[6];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(-99, 100);
            }    
                
            Console.WriteLine(String.Join(" ", arr));
            BucketSort(arr);
            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();
        }

        public static void BucketSort(int[] arr)
        {
            List<int>[] current = new List<int>[arr.Length];
            int minValue = arr[0];
            int maxValue = arr[0];

            //заполняем масcив массивами(избавляемся от null)
            for (int i = 0; i < current.Length; i++)
            {
                current[i] = new List<int>();
            }


            //находим максимальное и минимальное значение массива
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
                else 
                {
                    if (arr[i] > maxValue)
                    {
                        maxValue = arr[i];
                    }
                }

            }
            if (minValue == maxValue && maxValue == 0) // проверка если массив пустой
            {
                Console.WriteLine("Массив не имеет значений ");
                return;
            }
            //расчитываем разницу между максимальным и минимальным значениями
            double difference = maxValue - minValue;

            for (int i = 0; i < arr.Length; i++)
            {
                //находим подходящюю ячейку массива
                int result = (int)Math.Floor((arr[i]- minValue) / difference * (arr.Length - 1));
                //добавляем значение
                current[result].Add(arr[i]);
            }
            // сортируем значения в каждом отдельном листе
            for (int i = 0; i < current.Length; ++i)
            {
                current[i].Sort();
            }

            //собираем результат в исходный массив
            int idx = 0;
            for (int i = 0; i < current.Length; i++)
            {
                for (int j = 0; j < current[i].Count; j++)
                    arr[idx++] = current[i][j];

            }


        }
    }
}
