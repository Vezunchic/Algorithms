using System;

namespace BinarTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало программы");
            Tree tree =  new Tree();

            
            tree.AddItem(8);
            tree.AddItem(10);
            tree.AddItem(12);
            tree.AddItem(6);
            tree.AddItem(2);
            tree.AddItem(7);
            tree.PrintTree();
            tree.AddItem(7);
            tree.PrintTree();
            Console.WriteLine();
            tree.RemoveItem(6);
            tree.PrintTree();
            Console.WriteLine();
            tree.AddItem(6);
            tree.PrintTree();
            Console.WriteLine();
            tree.RemoveItem(10);
        
            tree.PrintTree();
            Console.WriteLine();
            tree.RemoveItem(7);
            tree.PrintTree();
            Console.WriteLine();
            tree.RemoveItem(6);
            tree.PrintTree();
            Console.WriteLine();
            var result = tree.GetNodeByValue(2);
            var result2 = tree.GetRoot();
            Console.WriteLine("Нажмите клавишу ");
            Console.ReadKey();

        }

       
    }
  
}
