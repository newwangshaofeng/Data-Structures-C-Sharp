using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> myTree = new BinarySearchTree<int>();

            myTree.insert(9);
            myTree.insert(4);
            myTree.insert(6);
            myTree.insert(20);
            myTree.insert(100);
            myTree.insert(15);
            myTree.insert(1);
            myTree.insert(69);

            //        9
            //   4         20
            //1    6    15    100
            //               69

            Console.WriteLine(myTree.lookup(69));

            myTree.remove(20);

            //        9
            //   4         69
            //1    6    15    100

            Console.WriteLine(myTree.lookup(69));
        }
    }
}
