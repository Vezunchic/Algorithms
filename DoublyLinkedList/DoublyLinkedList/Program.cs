using System;


namespace DoublyLinkedList_lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало программы");
            DoublyLinkedList newList = new DoublyLinkedList();
            newList.AddNode(121);
           
            newList.AddNode(122);// добавляет значение
            OutputListItem(newList); // выводит на консоль данные списка
            Console.WriteLine($"\n_______________\nдобавляем переменную 123\n");
            newList.AddNode(123); // добавляет значение
            OutputListItem(newList); // выводит на консоль данные списка
            Console.WriteLine($"\n_______________\nищем в список переменную 122\n");
            Node search1 = newList.FindNode(122); // ищет в списке переменную 
            Console.WriteLine($"Нода : {search1.Value} ");
            Console.WriteLine($"\n_______________\n добавдяем в список переменную 124\n");
            newList.AddNodeAfter(search1, 124);//добавляет ноду(переменную) после заданной ноды
            OutputListItem(newList);
            Console.WriteLine($"\n_______________\nищем в список переменную 123\n");
            Node search2 = newList.FindNode(123);
            Console.WriteLine($"Нода : {search2.Value}");
            Console.WriteLine($"\n_______________\n добавдяем в список переменную 125\n");
            newList.AddNodeAfter(search2, 125);
            OutputListItem(newList);
            Console.WriteLine($"\n_______________\nудаляем переменную {search2.Value}\n");
            newList.RemoveNode(search2); // удаляет Ноду(переменную)
            OutputListItem(newList);
            Console.WriteLine($"\n_______________\nСчитаем количество элементов в списке\n");
            var result = newList.GetCount(); // считает количество переменных
            Console.WriteLine($"{result}");
            Console.WriteLine($"\n_______________\nудаляем переменную 120( которой нет)\n");
            newList.RemoveNode(120); // удаляет Ноду(переменную) по значению
            OutputListItem(newList);

            Console.WriteLine("\nНажмите клавишу");
            Console.ReadKey();
        }

        private static void OutputListItem(DoublyLinkedList newList)
        {
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }


        


    }
}
