using DFS_BFS__Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_DFS_BFS_Search
{
    [TestClass]
    public class DFS_BFS_SearchTest
    {
        [TestMethod]
        public void TestMethodGetNodeByValueDFS()
        {
            Tree tree = new Tree();

            int current = 2;
            tree.AddItem(current);
            var result = tree.GetNodeByValueDFS(current);
            Assert.AreEqual(result.Value, current);
        }
        [TestMethod]
        public void TestMethodGetNodeByValueBFS()
        {
            Tree tree = new Tree();

            int current = 2;
            tree.AddItem(current);
            var result = tree.BFSSearch(current);
            Assert.AreEqual(result.Value, current);
        }
       
       
        [TestMethod]
        public void TestMethodAddItem()
        {
            Tree tree = new Tree();
            int current = 4;
            tree.AddItem(current);

            var result = tree.GetNodeByValueDFS(current);

            Assert.AreEqual(result.Value, current);

        }

        [TestMethod]
        public void TestMethodGetNodeByValueBranch()
        {
            Tree tree = new Tree();

            int current = 8;
            int quantity = 20;
            for (int i = 0; i < quantity; i++)
            {
                tree.AddItem(current);
            }

            var result = tree.GetNodeByValueDFS(current);
            Assert.AreEqual(result.Value, current);
        }

        [TestMethod]
        public void TestMethodRemoveItemRoot()
        {

            Tree tree = new Tree();
            int current = 4;

            tree.AddItem(current);
            tree.RemoveItem(current);
            var result = tree.GetNodeByValueDFS(current);

            Assert.AreEqual(null, result);

        }





    }
}
