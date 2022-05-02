using System;

namespace Block_diagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Введите число");
             int number = int.Parse(Console.ReadLine()); // задается число которое будет проверятся

             string result = ComparingNumbers(number); // метод определяющий просто или не простое число
             Console.WriteLine($"{result}");*/


            var test = new Test()
            {
                number = 2,
                Expected = "Простое",
                ExpectedException = null
            };
            var test2 = new Test()
            {
                number = 3,
                Expected = "Простое",
                ExpectedException = null
            };
            var test3 = new Test()
            {
                number = 5,
                Expected = "Простое",
                ExpectedException = null
            };
            var test4 = new Test()
            {
                number = -2,
                Expected = "Не простое",
                ExpectedException = null
            };
            var test5 = new Test()
            {
                number = 1,
                Expected = "Не простое",
                ExpectedException = null
            };
            TestSum(test);
            TestSum(test2);
            TestSum(test3);
            TestSum(test4);// с ошибкой, так как простые числа не могут быть отрицательными 
            TestSum(test5); // с ошибкой, так как в блок схеме нет исключения для 1
            Console.WriteLine();
            Console.WriteLine("нажмите клавишу");
            Console.ReadKey();
        }



        public static string ComparingNumbers(int number)
        {
            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {

                return "Простое";
            }
            else
            {
                return "Не простое";

            }


        }

        public class Test
        {
            public int number { get; set; }
            public string Expected { get; set; }
            public Exception ExpectedException { get; set; }

        }
        static void TestSum(Test test)
        {
            try
            {
                var actual = ComparingNumbers(test.number);
                if (actual == test.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }


            }
            catch (Exception ex)
            {
                if (test.ExpectedException != null)
                {
                    Console.WriteLine($"VALID TEST {ex.Message}");
                }
                else
                {
                    Console.WriteLine($"INVALID TEST {ex.Message}");

                }
            }

        }


    }

}
