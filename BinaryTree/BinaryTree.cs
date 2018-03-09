using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        //member variables
        public Node headNode;

        //constructor
        private BinaryTree(int data)
        {
        }

        //member methods
        private void Add(int data)
        {
            if (headNode == null)
            {
                Node nodeToAdd = new Node();
                headNode = nodeToAdd;
                return;
            }
            Node currentNode = headNode;
            bool added = false;
            do
            {
                if (data < currentNode.data)
                {
                    if (currentNode.leftNode == null)
                    {
                        Node newNode = new Node();
                        currentNode.leftNode = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.leftNode;
                    }
                }
                if (data > currentNode.data)
                {
                    if (currentNode.rightNode == null)
                    {
                        Node newNode = new Node();
                        currentNode.rightNode = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.rightNode;
                    }
                }
            } while (!added);
        }

        public bool Search(int data)
        {
            Node currentNode = headNode;

            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    return true;
                }
                else if (currentNode.data < data)
                {
                    currentNode = currentNode.rightNode;
                }
                else if (currentNode.data > data)
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return false;
        }

    }
}