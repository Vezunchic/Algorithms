using System;

namespace DFS_BFS__Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало программы");
            Tree tree = new Tree();


            tree.AddItem(8);
            Console.WriteLine();
            tree.AddItem(10);
            Console.WriteLine();
            tree.AddItem(12);
            Console.WriteLine();
            tree.AddItem(14);
            Console.WriteLine();
            tree.AddItem(6);
            Console.WriteLine();
            tree.AddItem(2);
            Console.WriteLine();
            tree.AddItem(7);
            Console.WriteLine();
            tree.AddItem(9);
            Console.WriteLine();
            tree.PrintTree();
            var result1 = tree.GetNodeByValueDFS(7);
            Console.WriteLine();
            var result2 = tree.GetNodeByValueDFS(14);
            Console.WriteLine();
            var result5 = tree.GetNodeByValueDFS(10);
            Console.WriteLine();
            var result4 = tree.BFSSearch(15);
            Console.WriteLine();
            var result3 = tree.BFSSearch(7);
            Console.WriteLine();
            var result7= tree.BFSSearch(14);
            Console.WriteLine();
            var result6 = tree.BFSSearch(10);
            tree.PrintTree();
            tree.RemoveItem(12);
            tree.PrintTree();
            tree.RemoveItem(9);
            tree.PrintTree();
            tree.RemoveItem(6);
            tree.PrintTree();
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();
        }
    }
}
