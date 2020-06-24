using System;

namespace DoublyLinkedList
{
    class DoublyLinkedList<T>
    {
        // Member variables ~~~~~~~~~~~
        private Node<T> head = null; // First node
        private Node<T> tail = null; // Last node
        private int length = 0; // Length of the chain
        // ~~~~~~~~~~~

        // Constructor ~~~~~~~~~~~
        public DoublyLinkedList(T value)
        {
            this.head = new Node<T>(value);
            this.tail = this.head;
            this.length = 1;
        }
        // ~~~~~~~~~~~

        // Properties ~~~~~~~~~~~

        // Getter for length
        public int Length { get { return this.length; } }

        // Getter for the first node
        public Node<T> Head { get { return this.head; } }

        // Getter for the last node
        public Node<T> Tail { get { return this.tail; } }
        // ~~~~~~~~~~~

        // Methods ~~~~~~~~~~~

        // Diplay the whole chain
        public void DisplayChain() // O(n)
        {
            Node<T> current = this.head;

            while (current != null) {
                Console.Write(" --> ");
                Console.Write(current.Value);
                current = current.Next;
            }
            Console.Write("\n");
        }

        
        // Diplay the whole chain
        public void DisplayReverseChain() // O(n)
        {
            Node<T> current = this.tail;

            while (current != null) {
                Console.Write(current.Value);
                Console.Write(" <-- ");
                current = current.Previous;
            }
            Console.Write("\n");
        }

        // Add the last node of the chain
        public void Append(T value) // O(1)
        {
            this.tail.Next = new Node<T>(value); // Set the last node with the value
            this.tail.Next.Previous = this.tail; // Set the previous node
            this.tail = this.tail.Next;

            this.length++; // Add 1 to Length
        }

        // Add a node and make it head of the chain
        public void Prepend(T value) // O(1)
        {
            Node<T> newFirst = new Node<T>(value); // Create a new node

            // Make it the first of the chain
            newFirst.Next = this.head;
            this.head.Previous = newFirst;
            this.head = newFirst;

            this.length++; // Add 1 to Length
        }

        // Add a node in-between 2 other nodes
        public void Insert(int index,T value) // O(n)
        {
            // If index out of range
            if (index > length)
                throw new IndexOutOfRangeException("Index "+index+" out of range");
            else if (index == 1) { // If index == 1, prepend
                Prepend(value);
                return;
            }

            //Else
            // Start from the first node
            Node<T> current = this.head;
            int counter = 1;

            // Find the one selected
            while (current.Next != null && counter+1 < index) {
                current = current.Next;
                counter++;
            }

            Node<T> restOfChain = current.Next; // Save the rest of the chain
            current.Next = new Node<T>(value); // Create a new node as the next
            current.Next.Previous = current;
            // Attach the rest of the chain to it
            current = current.Next;
            current.Next = restOfChain;
            restOfChain.Previous = current;

            this.length++; // Add 1 to Length
        }

        // Remove node at selected index
        public void RemoveAt(int index) // O(n)
        {
            // If index out of range
            if (index > length)
                throw new IndexOutOfRangeException("Index "+index+" out of range");
            else if (index == 1) { // If index == 1, prepend
                this.head = this.head.Next;
                this.head.Previous = null;
                this.length--; // Subtract 1 from length
                return;
            } else if (index == Length) {
                this.tail = this.tail.Previous;
                this.tail.Next = null;
                this.length--; // Subtract 1 from length
                return;
            }

            //Else
            // Start from the first node
            Node<T> current = this.head;
            int counter = 1;

            // Find the one selected
            while (current.Next != null && counter+1 < index) {
                current = current.Next;
                counter++;
            }

            current.Next.Next.Previous = current.Next.Previous;
            current.Next = current.Next.Next;
            this.length--; // Subtract 1 from length
        }
        // ~~~~~~~~~~~
    }
}
