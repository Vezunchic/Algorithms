using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList_lesson_2
{
    public class DoublyLinkedList : ILinkedList, IEnumerable<int>
    {


        private Node head = null;
        private Node tail = null;


        public void AddNode(int value)// добавляет новый элемент списка
        {
            Node newNode = new Node() { Value = value };
            if (head == null)
            {
                head = newNode;
                head.NextNode = tail;
                return;
            }
            if (tail == null)
            {
                tail = newNode;
                tail.PrevNode = head;
                head.NextNode = newNode;
            }
            else
            {
                tail.NextNode = newNode;
                newNode.PrevNode = tail;
                tail = newNode;
            }
        }


        public void AddNodeAfter(Node node, int value)// добавляет новый элемент списка после определённого элемента

        {
            var item = head;
            while (item.NextNode != null && item != node)
            {
                item = item.NextNode;
            }
            if (item.NextNode == null)
            {
                Console.WriteLine("такого элемента нет, значение добавлено в конец списка");
                AddNode(value);
            }
            else
            {
                Node newNode = new Node() { Value = value };// создается новый элемент
                var nextItem = node.NextNode;

                node.NextNode = newNode; // в искомый элемент перезаписываем путь на новый элемент
                newNode.NextNode = nextItem;// в новый элемент записываем путь от искомого к следующему
                nextItem.PrevNode = newNode;

                newNode.PrevNode = node;
            }
        }

        public Node FindNode(int searchValue)// ищет элемент по его значению
        {
            Node nextItem = head;
            while (nextItem.NextNode != null && nextItem.Value != searchValue)
            {
                nextItem = nextItem.NextNode;
            }
            if (nextItem.Value == searchValue)
            {
                return nextItem;
            }
            else
            {
                return null;
            }
        }

        public int GetCount()// возвращает количество элементов в списке
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.NextNode;

            }
            return count;
        }



        public IEnumerator GetEnumerator()
        {
            var curren = head;
            while (curren != null)
            {

                yield return curren.Value;
                curren = curren.NextNode;
            }

        }

        public void RemoveNode(int index) // удаляет элемент по порядковому номеру
        {

            Node current = head;

            while (current != null && current.Value != index)
            {
                current = current.NextNode;

            }
                       
            if (current != null && current.Value == index)
            {
                RemoveNode(current);// удаляет указанный элемент
            }
            else
            {
                Console.WriteLine($"Такого элемента с индексом:{index} нет в списке ");
            }
        }



        public void RemoveNode(Node node)// удаляет указанный элемент
        {
            var nextItem = node.NextNode;
            var prevItem = node.PrevNode;
            if (node.NextNode == null)
            {
                tail = node.PrevNode;
            }
            else
            {
                node.NextNode.PrevNode = node.PrevNode;
            }
            if (node.PrevNode == null)
            {
                head = node.NextNode;
            }
            else
            {

                nextItem.PrevNode = prevItem;
                prevItem.NextNode = nextItem;
            }

        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            var curren = head;
            while (curren != null)
            {

                yield return curren.Value;
                curren = curren.NextNode;
            }

        }
    }
}
