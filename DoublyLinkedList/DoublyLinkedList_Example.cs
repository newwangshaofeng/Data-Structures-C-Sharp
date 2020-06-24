namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> myList = new DoublyLinkedList<int>(1); // Create the Doubly Linked List / Chain

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

            // Output the whole chain
            myList.DisplayChain();
            myList.DisplayReverseChain(); 
        }
    }
}
