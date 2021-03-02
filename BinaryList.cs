using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryList
    {
        public Node RightNode;
        public Node LeftNode;
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
                if (currentNode.NextNode == null)
                {
                    currentNode.NextNode = nodeToAdd;
                    break;
                }
                else
                {
                    currentNode = currentNode.NextNode;
                }
            }
        }
    }


    public void Search()
    {

    }
}

        
