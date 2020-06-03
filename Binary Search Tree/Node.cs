namespace BinarySearchTree
{
    class Node<T>
    {
        public Node<T> left; // Left child node
        public Node<T> right; // Right child node
        public T value; // Value of this node

        // Constructor
        public Node(T value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
