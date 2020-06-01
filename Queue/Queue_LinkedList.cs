namespace Queue_Implementation__Linked_List_
{
    class Queue<T> // FIFO
    {
        // Member variables
        Node<T> first; // First node
        Node<T> last; // Last node
        int length; // Length of the queue

        public bool isEmpty { get { return length == 0; } } // Property that returns true if empty

        // Constructor
        public Queue()
        {
            this.first = null;
            this.last = null;
            this.length = 0;
        }

        // Methods
        public T peek() // Get the first element - O(1)
        {
            return this.first.value;
        }

        public void enqueue(T value) // Add a node (last) - O(1)
        {
            Node<T> newNode = new Node<T>(value);

            // If it's the first item, add it as both first and last
            if (isEmpty) {
                this.first = newNode;
                this.last = newNode;
            } else { // If not, add it as last
                this.last.next = newNode;
                this.last = newNode;
            }

            length++; // Increase the length by 1
        }

        public void dequeue() // Remove the first - O(1)
        {
            if (this.first == null) return; // If there it no item, return

            if (this.first == this.last) //  If there is only 1 item left, clear the last
                this.last = null;

            Node<T> holdingPointer = this.first; // Create a reference for our garbage collector
            this.first = this.first.next; // Change the first element
            this.length--; // Decrease the length by 1
        }
    }
}
