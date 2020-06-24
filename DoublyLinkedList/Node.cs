namespace DoublyLinkedList
{
    // Node of the Doubly Linked list / Chain
    class Node<T>
    {
        // Member variables ~~~~~~~~~~~
        private T value;
        private Node<T> next;
        private Node<T> previous;
        // ~~~~~~~~~~~

        // Constructors ~~~~~~~~~~~
        public Node(T value)
        {
            this.value = value;
            this.next = null;
            this.previous = null;
        }
        // ~~~~~~~~~~~

        // Properties ~~~~~~~~~~~

        // Getter for Value
        public T Value { get { return this.value; } }

        // Getter for next and previous nodes
        public Node<T> Next 
        { 
            get { return this.next; }
            set { this.next = value; }
        }
        public Node<T> Previous 
        { 
            get { return this.previous; } 
            set { this.previous = value; }
        }
        // ~~~~~~~~~~~
    }
}
