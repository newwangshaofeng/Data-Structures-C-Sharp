namespace MaxHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxHeap<int> myHeap = new MaxHeap<int>(22);

            myHeap.Insert(27);
            myHeap.Insert(2);
            myHeap.Insert(84);
            myHeap.Insert(10);
            myHeap.Insert(7);
            myHeap.Insert(3);
            myHeap.Insert(69);
            myHeap.Insert(1);
            myHeap.Insert(9);

            /*
             *               84
             *              /  \
             *             /    \
             *            /      \
             *           69       7
             *          /  \     / \
             *         /    \   2   3
             *        27    10   
             *       / \    /
             *      22  1  9
             */

            myHeap.PrintEachNode();
        }
    }
}
