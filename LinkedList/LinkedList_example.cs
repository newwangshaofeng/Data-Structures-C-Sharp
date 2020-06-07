namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>(1); // Create the Linked List / Chain

            // Append nodes in the end of the chain
            myList.Append(4);
            myList.Append(3);

            myList.DisplayChain(); // Output the whole chain

            // Prepend nodes in the beginning of the chain
            myList.Prepend(2);
            myList.Prepend(25);

            myList.DisplayChain(); // Output the whole chain

            // Insert nodes in selected index
            myList.Insert(2, 74);
            myList.Insert(6, 58);

            myList.DisplayChain(); // Output the whole chain

            // Delete nodes in selected index
            myList.RemoveAt(7);
            myList.RemoveAt(2);

            myList.DisplayChain(); // Output the whole chain
        }
    }
}
