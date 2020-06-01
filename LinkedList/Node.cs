namespace LinkedList
{
    // Node of the Linked list / Chain
    class Node<T>
    {
        // Member variables ~~~~~~~~~~~
        private T value;
        private Node<T> next;
        // ~~~~~~~~~~~

        // Constructors ~~~~~~~~~~~
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
        // ~~~~~~~~~~~

        // Properties ~~~~~~~~~~~

        // Getter for Value
        public T Value { get { return this.value; } }

        // Getter for next node
        public Node<T> Next { get { return this.next; } }
        // ~~~~~~~~~~~

        // Methods ~~~~~~~~~~~

        // Set the value of the next node
        public void SetNextValue(T value)
        {
            this.next = new Node<T>(value);
        }

        // Set the next node
        public void SetNextNode(Node<T> nextNode)
        {
            this.next = nextNode;
        }
        // ~~~~~~~~~~~
    }
}
