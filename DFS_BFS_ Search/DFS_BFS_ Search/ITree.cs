namespace DFS_BFS__Search
{
    interface ITree
    {
        void AddItem(int value); // добавить узел
        void RemoveItem(int value); // удалить узел по значению
        TreeNode GetNodeByValueDFS(int value); //получить узел дерева в глубину
        TreeNode BFSSearch(int value); //получить узел дерева в ширину
        void PrintTree();//вывести дерево в консоль

    }
}
