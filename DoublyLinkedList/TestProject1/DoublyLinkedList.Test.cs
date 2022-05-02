using DoublyLinkedList_lesson_2;
using NUnit.Framework;
using System.Linq;

namespace TestProject1
{
    public class DoublyLinkedListTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddNode_oneVariableSupplied_newNode()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            int current = 2;
            doublyLinkedList.AddNode(current);

            var result = doublyLinkedList.First();
            Assert.AreEqual(result, current);
        }
        [Test]
        public void AddNode_manyVariableSupplied_newNode()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            int numberRepetitions = 3;
            for (int current = 1; current < numberRepetitions + 1; current++)
            {
                doublyLinkedList.AddNode(current);
            }

            var result = doublyLinkedList.Count<int>();
            Assert.AreEqual(result, numberRepetitions);
        }

        [Test]
        public void FindNode_oneVariableSupplied_searchNode()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddNode(1);
            doublyLinkedList.AddNode(2);
            int current = 2;
            doublyLinkedList.FindNode(current);

            var result = doublyLinkedList.Count<int>();
            Assert.AreEqual(result, current);
        }



        [Test]
        public void AddNodeAfter_oneVariableSupplied_newNode()
        {
            DoublyLinkedList doublyLinkedListFirst = new DoublyLinkedList();
            doublyLinkedListFirst.AddNode(1);
            doublyLinkedListFirst.AddNode(2);
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddNode(1);
            var searchedNode = doublyLinkedList.FindNode(1);
            int current = 2;
            doublyLinkedList.AddNodeAfter(searchedNode, current);
            CollectionAssert.AreEqual(doublyLinkedListFirst, doublyLinkedList);
        }

        [Test]
        public void RemoveNode_oneVariableSupplied_emptyList()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddNode(1);
            int number = 1;
            DoublyLinkedList doublyLinkedListTwo = new DoublyLinkedList();
            doublyLinkedList.RemoveNode(number);

            CollectionAssert.AreEqual(doublyLinkedList, doublyLinkedListTwo);
        }

        [Test]
        public void RemoveNode_oneNodeSupplied_emptyList()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddNode(1);
            int current = 1;
            var item = doublyLinkedList.FindNode(current);
            DoublyLinkedList doublyLinkedListTwo = new DoublyLinkedList();
            doublyLinkedList.RemoveNode(item);

            CollectionAssert.AreEqual(doublyLinkedList, doublyLinkedListTwo);

        }

        [Test]
        public void GetCount_list_manyNumber()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddNode(1);
            doublyLinkedList.AddNode(2);
            int current = 2;
           int result = doublyLinkedList.GetCount();

            
            Assert.AreEqual(result, current);
        }
    }
}