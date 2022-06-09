using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS__Search
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        public override bool Equals(object obj)

        {
            var node = obj as TreeNode;
            if (node == null)
                return false;
            return node.Value == Value;

        }
        internal void GetResultTree(string indent, bool last)
        {

            Console.Write(indent);

            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }
            Console.WriteLine(this.Value);


            var listTreePrint = new List<TreeNode>();

            if (this.LeftChild != null)
            {
                listTreePrint.Add(this.LeftChild);
            }
            if (this.RightChild != null)
            {
                listTreePrint.Add(this.RightChild);
            }

            for (int i = 0; i < listTreePrint.Count; i++)
            {
                listTreePrint[i].GetResultTree(indent, i == listTreePrint.Count - 1);
            }

        }


    }
}
