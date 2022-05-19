using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace TreesHashSet

{
    [JsonExporterAttribute.Full]
    public class BechmarkClass
    {

        private readonly List<LineClass> lineArray;
        private Random _random = new Random(); // для создания случайной строки
        private readonly HashSet<RandomName> hashSet;

        public BechmarkClass()
        {
            lineArray = new List<LineClass>();
            hashSet = new HashSet<RandomName>();

            int quantity = 1000000;


            for (int i = 0; i < quantity; i++)
            {
                lineArray.Add(new LineClass { _line = RandomString() });
                hashSet.Add(new RandomName() { FirstName = RandomString(), SecondName = RandomString() });
            }

            // что бы понимать что искать
            hashSet.Add(new RandomName() { FirstName = "Barbara", SecondName = "Santa" });
            lineArray.Add(new LineClass { _line = "Barbara" });
        }


        public string RandomString() // создает рандомную строку
        {
            string str = "abcdefghijklmnopqrstuvwxyz";
            int size = 5; // сколько символов в строке
            string ran = "";

            for (int i = 0; i < size; ++i)
            {
                int x = _random.Next(26);
                ran = ran + str[x];
            }
            return ran;
        }

        [Benchmark]
        public void PresenceString()
        {

            for (int i = 0; i < lineArray.Count - 1; i++)
            {
                if (lineArray[i]._line == "Barbara")
                {
                    return;
                }
            }
        }
        [Benchmark]
        public void PresenceStringHashSet()
        {
            var searchName = new RandomName()
            {
                FirstName = "Barbara",
                SecondName = "Santa"
            };
            Console.WriteLine($" { hashSet.Contains(searchName) }");

        }

    }

}