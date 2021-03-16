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
            RootNode = null;
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
                    if (nodeToAdd.Data > currentNode.Data)
                    {
                        if (currentNode.RightNode == null)
                        {
                            currentNode.RightNode = nodeToAdd;
                            break;

                        }
                        else if (currentNode.RightNode != null)
                        {
                            currentNode.RightNode = currentNode;
                        }

                    }
                    else
                    {
                        if (nodeToAdd.Data < currentNode.Data)
                        {
                            if (currentNode.LeftNode == null)
                            {
                                currentNode.LeftNode = nodeToAdd;
                                break;
                            }
                            else if (currentNode.LeftNode != null)
                            {
                                currentNode.LeftNode = currentNode;
                            }

                        }
                    }
                }
            }
        }
        public bool Search(int dataToFind)
        {
            bool isFound = false;
            Node currentNode = RootNode;
            while (currentNode != null && isFound == false)
            {
                if (currentNode.Data == dataToFind)
                {
                    isFound = true;
                }
                if (dataToFind < currentNode.Data)
                {
                    if (currentNode.LeftNode == null)
                    {
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.LeftNode;
                    }
                }
                if (dataToFind > currentNode.Data)
                {
                    if (currentNode.RightNode == null)
                    {
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.RightNode;
                    }
                }
            }
            if (isFound == true)
            {
                Console.WriteLine("Found it!");
                return true;
            }
            else
            {
                Console.WriteLine("Didn't find it");
                return false;
            }
        }
    }
}
    
    
    



    




















