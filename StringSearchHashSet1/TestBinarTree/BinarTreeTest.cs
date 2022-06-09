using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarTree;


namespace TestBinarTree
{

    [TestClass]
    public class BinarTreeTest
    {
        [TestMethod]
        public void TestMethodGetNodeByValueRoot()
        {
            Tree tree = new BinarTree.Tree();

            int current = 2;
            tree.AddItem(current);
            var result = tree.GetNodeByValue(current);
            Assert.AreEqual(result.Value, current);
        }
        [TestMethod]
        public void TestMethodGetNodeByValueBranch()
        {
            Tree tree = new BinarTree.Tree();

            int current = 8;
            int quantity = 20;
            for (int i = 0; i < quantity; i++)
            {
                tree.AddItem(current);
            }
            
            var result = tree.GetNodeByValue(current);
            Assert.AreEqual(result.Value, current);
        }

        [TestMethod]
        public void TestMethodGetRoot()
        {
            Tree tree = new BinarTree.Tree();

            int current = 0;
            int quantity = 20;
            for (int i = 0; i < quantity; i++)
            {
                tree.AddItem(current);
            }

            var result = tree.GetRoot();
            Assert.AreEqual(result.Value, current);
        }

        [TestMethod]
        public void TestMethodAddItem()
        {
            Tree tree = new BinarTree.Tree();
            int current = 4;
            tree.AddItem(current);

            var result = tree.GetNodeByValue(current);

            Assert.AreEqual(result.Value, current);

        }
        [TestMethod]
        public void TestMethodRemoveItemRoot()
        {
            
            Tree tree = new BinarTree.Tree();
            int current = 4;
            
            tree.AddItem(current);
            tree.RemoveItem(current);
            var result = tree.GetNodeByValue(current);
            
            Assert.AreEqual(null, result);

        }


        

    }
}
