namespace Queue_Implementation__Linked_List_
{
    class Node<T>
    {
        public T value; // Value of the current node
        public Node<T> next; // Pointer to access the next node

        // Constructor
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
