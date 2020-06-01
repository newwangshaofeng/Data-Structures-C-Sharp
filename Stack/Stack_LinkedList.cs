namespace Stack_Implementation__Linked_List_
{
    class Stack<T> // LIFO
    {
        // Member variables
        Node<T> top;
        Node<T> bottom;
        int length;

        public bool isEmpty { get { return length == 0; } } // Property that returns true if empty

        // Constructor
        public Stack()
        {
            this.top = null;
            this.bottom = null;
            this.length = 0;
        }

        // Methods
        public T peek() // Get the top element - O(1)
        {
            return this.top.value;
        }

        public void push(T value) // Add a node to the top - O(1)
        {
            Node<T> newNode = new Node<T>(value);

            // If it's the first item, add it to the bottom
            if (isEmpty) {
                // Make the element first
                this.bottom = newNode;
                this.top = newNode;
            } else {
                // Add the new element at the top
                Node<T> holdingPointer = this.top;
                this.top = newNode;
                this.top.next = holdingPointer;
            }

            length++; // Increase the length by 1
        }

        public void pop() // Remove from top - O(1)
        {
            if (this.top == null) return; // If there it no top item, return

            if (this.top == this.bottom) // If only 1 item is remaining, clear the bottom
                this.bottom = null;

            Node<T> holdingPointer = this.top; // Create a reference for our garbage collector
            this.top = this.top.next; // Change the top element
            this.length--; // Decrease the length by 1
        }
    }
}
