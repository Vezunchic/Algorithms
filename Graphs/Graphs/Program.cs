using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало программы");
            Node firstNode = new Node() { Value = 10 };
            Node secondNode = new Node() { Value = 20 };
            Node threeNode = new Node() { Value = 5 };
            Node fourNode = new Node() { Value = 6 };
            Node fiveNode = new Node() { Value = 7 };
            Node sixNode = new Node() { Value = 25 };

            firstNode.Edges = new List<Edge>();
            firstNode.Edges.Add(new Edge()
            {
                Node = secondNode,
                Weight = 5
            }
            );
            firstNode.Edges.Add(new Edge()
            {
                Node = threeNode,
                Weight = 5
            }
           );
            secondNode.Edges = new List<Edge>()
            {
            new Edge()
            {
            Node = fourNode,
            Weight = 5
            }
            };
            threeNode.Edges = new List<Edge>()
            {
            new Edge()
            {
            Node = fourNode,
            Weight = 10
            }
            };
            threeNode.Edges.Add(new Edge()
            {
                Node = fiveNode,
                Weight = 5
            });
            fourNode.Edges = new List<Edge>()
            {
            new Edge()
            {
            Node = sixNode,
            Weight = 5
            }
            };
            fiveNode.Edges = new List<Edge>()
            {
            new Edge()
            {
            Node = fourNode,
            Weight = 5
            }
            };
            Console.WriteLine("Поиск в ширину");
            var result1 = BFSSearch(25, firstNode);
            Console.WriteLine($"Результат: {result1.Value}\n");
         
            var result2 = BFSSearch(5, firstNode);
            Console.WriteLine($"Результат: {result2.Value}\n");
       
            var result3 = BFSSearch(0, firstNode);
            Console.WriteLine();

            Console.WriteLine("Поиск в глубину");
           var result4 = DFSSearch(6, firstNode);
            Console.WriteLine($"Результат: {result4.Value}\n");
            
            var result5 = DFSSearch(20, firstNode);
            Console.WriteLine($"Результат: {result5.Value}\n");
            
            var result6 = DFSSearch(0, firstNode);
            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();
        }

        private static Node BFSSearch(int value, Node firstNode)
        {

            Node current = firstNode;
            var queue = new Queue<Node>();


            if (current == null)
            {
                Console.WriteLine("Искомого узла в дереве нет");
                return current;
            }

            while (current != null && current.Value != value)
            {
                Console.WriteLine($"{current.Value}");

                if (current.Edges != null)
                {
                    for (int i = 0; i < current.Edges.Count; i++)
                    {
                        if (queue.Contains(current.Edges[i].Node)) //проверяет наличие элемента в очереди
                        {
                            continue;
                        }
                        else
                        {
                            queue.Enqueue(current.Edges[i].Node);
                        }
                    }
                }
                
                if (queue.Count != 0)
                {
                    current = queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Нет такого значения");
                    return current = null;
                }
            }
            return current;


        } // поиск в ширину

        private static Node DFSSearch(int value, Node firstNode)
        {
            Node current = firstNode;
            var steсk = new Stack<Node>();

            if (current == null)
            {
                Console.WriteLine("Искомого узла в дереве нет");
                return current;
            }

            while (current != null && current.Value != value)
            {
                Console.WriteLine($"{current.Value}");
                if (current.Edges != null)
                {
                    for (int i = 0; i < current.Edges.Count; i++)
                    {
                        if (steсk.Contains(current.Edges[i].Node))//проверяет наличие элемента в стеке
                        {
                            continue;
                        }
                        else
                        {
                            steсk.Push(current.Edges[i].Node);
                        }
                    }
                }
                if (steсk.Count != 0)
                {
                   
                    current = steсk.Pop();
                }
                else
                {
                    Console.WriteLine("Нет такого значения");
                    return current = null;
                }
            }
            return current;
        } // поиск в глубину
    }
}

