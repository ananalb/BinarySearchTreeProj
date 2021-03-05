using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryList mylist = new BinaryList();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(2);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            mylist.Add(node1);
            mylist.Add(node2);
            mylist.Add(node3);
            mylist.Add(node4);
            mylist.Add(node5);
            mylist.Add(node6);


            mylist.Search(2);
        }
    }
}
