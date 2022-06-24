using Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGraphs
{
    [TestClass]
    public class BFS_DFS_GraphsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Node firstNode = new Node() { Value = 10 };
            Node secondNode = new Node() { Value = 20 };
            Node threeNode = new Node() { Value = 5 };
            Node fourNode = new Node() { Value = 6 };
            int current = 2;
            var result = BFSSearch(current, firstNode);
            Assert.AreEqual(result.Value, current);
        }

    }
}
