using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;

                    if (data < current.data)
                    {
                        current = current.left;

                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;

                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void InorderTraversal(Node node)
        {
            if (node != null)
            {
                InorderTraversal(node.left);
                Console.Write(node.data + " ");
                InorderTraversal(node.right);
            }
        }

        public int Size(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return Size(node.left) + 1 + Size(node.right);
            }
        }
    }
}
