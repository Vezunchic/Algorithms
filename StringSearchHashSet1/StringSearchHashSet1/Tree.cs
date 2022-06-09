using System;
using System.Collections.Generic;

namespace BinarTree
{
    public class Tree : ITree
    {
        private List<int> listForPrint = new List<int>();
        private TreeNode _head;

        public TreeNode GetRoot() // Получить корень
        {
            TreeNode result = _head;
            return result;
        }

        public void AddItem(int value) // добавление
        {
            
            if (_head == null)
            {
                var test = new TreeNode() { Value = value };
                _head = test;
                return;
            }
            else
            {
                var result = GetNodeByValue(value);
                if (result == null )
                {
                    Add(_head, value);
                    
                }
                else 
                {
                    Console.WriteLine("\nТакое значение уже есть.\n");
                }
            }

        }
        private void Add(TreeNode node, int value) // добавление последующего элемента 
        {

            if (value.CompareTo(node.Value) < 0) // проверка на направление вставки значения
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = new TreeNode() { Value = value };

                }
                else
                {
                    Add(node.LeftChild, value);
                }
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new TreeNode() { Value = value };
                }
                else
                {
                    Add(node.RightChild, value);
                }
               
            }

        }

        public void RemoveItem(int value)
        {
            TreeNode parent, tree;
            
           tree = FindWithParent(value, out parent);

            if (tree == null)
            {
                Console.WriteLine("Узла не существует");
                return;
            }
            //Если нет детей справа,
            //левый ребенок встает на место удаляемого.
            if (tree.RightChild == null)
            {
                if (parent == null)
                {
                    _head = tree.LeftChild;
                }
                else
                {
                    int result = parent.Value.CompareTo(tree.Value);
                    if (result > 0)
                    {
                        //Если значение родителя больше текущего,
                        //левый ребенок текущего узла становится левым ребенком родителя.
                        parent.LeftChild = tree.LeftChild;
                    }
                    else if (result < 0)
                    {
                        //Если значение родителя меньше текущего,
                        // левый ребенок текущего узла становится правым ребенком родителя.
                        parent.RightChild = tree.LeftChild;
                    }
                }
                return;
            }

            //Если у правого ребенка нет детей слева
            //то он занимает место удаляемого узла.

            if (tree.RightChild != null && tree.RightChild.LeftChild == null)
            {
                tree.RightChild.LeftChild = tree.LeftChild;

                if (parent == null)
                {
                    _head = tree.RightChild;

                }
                else
                {
                    int result = parent.Value.CompareTo(tree.Value);
                    if (result > 0)
                    {
                        //Если значение родителя больше текущего,
                        //правый ребенок текущего узла становится левым ребенком родителя.
                        parent.LeftChild = tree.RightChild;
                    }
                    else if (result < 0)
                    {
                        //Если значение родителя меньше текущего,
                        // левый ребенок текущего узла становится правым ребенком родителя.
                        parent.RightChild = tree.RightChild;
                    }
                }
                return;
            }
            //Если у правого ребенка есть дети слева,
            //крайний левый ребенок
            //из правого поддерева заменяет удаляемый узел.
            if (tree.RightChild != null && tree.RightChild.LeftChild != null) // удаляемый узел имеет правого потомка, у которого есть левый   потомок.
            {
                TreeNode leftmost = tree.RightChild.LeftChild;
                TreeNode leftmostParent = tree.RightChild;


                while (leftmost.LeftChild != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.LeftChild;
                }
                //Левое поддерево родителя становится правым поддеревом
                //крайнего левого узла.
                leftmostParent.LeftChild = leftmost.RightChild;
                //Левый и правый ребенок текущего узла становится левым
                //и правым ребенком крайнего левого. leftmost.
                leftmost.LeftChild = tree.LeftChild;
                leftmost.RightChild = tree.RightChild;
                if (parent == null)
                {
                    _head = leftmost;
                }
                else
                {
                    int result = parent.Value.CompareTo(tree.Value);
                    if (result > 0)
                    {
                        parent.LeftChild = leftmost;
                    }
                    else
                    {
                        parent.RightChild = leftmost;
                    }
                }
            }
            return;
        } // удаление

        public TreeNode GetNodeByValue(int value)
        {
            TreeNode parent;
            return FindWithParent(value, out parent);
        } // Поиск

       private TreeNode FindWithParent(int value, out TreeNode parent)
        {
            TreeNode current = _head;
            parent = null;
            if (current == null)
            {
                Console.WriteLine("Искомого узла в дереве нет");
                return current;
            }
            else
            {
                while (current != null)
                {
                                     
                    if (value.CompareTo(current.Value) < 0)//Если искомое значение меньше, идет налево.
                    {
                        parent = current;
                        current = current.LeftChild;
                    }
                    else if (value.CompareTo(current.Value) > 0)//Если искомое значение больше, идет направо.
                    {
                        parent = current;
                        current = current.RightChild;
                    }
                    else
                    {
                      break;
                    }

                }
               
                return current;
            }
        }
        public void PrintTree()
        {
            PostOrderTraversal(_head); // древо списком
            _head.GetResultTree( "", true); // построение дерева
        }  // вывод на консоль

        private void PostOrderTraversal(TreeNode node) // обход дерева и запись его в лист
        {
            if (node == null)
            {
                return;
            }

            PostOrderTraversal(node.LeftChild);
            listForPrint.Add(node.Value);

            if (node.RightChild != null)
            {
                PostOrderTraversal(node.RightChild);
            }
          
        }
    }
}



