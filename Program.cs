namespace Day15BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);

            Console.WriteLine("Inorder Traversal of BST:");
            bst.InorderTraversal(bst.root);
        }
    }
}