using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryList
    {
        public Node RootNode;


        public BinaryList()
        {

        }


        public void Add(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            else
            {
                Node currentNode = RootNode;
                while (true)
                {
                    if (nodeToAdd.Data > currentNode.Data || currentNode.RightNode == null)
                    {
                        currentNode.RightNode = nodeToAdd;
                        break;


                    }
                    else
                    {
                        if (nodeToAdd.Data < currentNode.Data || currentNode.LeftNode == null)
                        {
                            currentNode.LeftNode = nodeToAdd;
                            break;

                        }
                    }

                }
            }
        }
        public bool Search(int dataToFind)
        {
            int position = 1;
            Node node = RootNode;
            while (node != null)
            {
                if (node.Data != dataToFind)
                {
                    break;
                }
                position++;
                node = RootNode;
            }
            if (node == null)
            {
                Console.WriteLine($"{dataToFind} not found in list");
                return false;
            }
            else
            {
                Console.WriteLine($"{dataToFind} is at position {position}");
                return true;
            }
        }
    }
}


    




















