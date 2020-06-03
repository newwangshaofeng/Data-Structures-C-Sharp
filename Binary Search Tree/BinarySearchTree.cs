using System.Collections.Generic;

namespace BinarySearchTree
{
    class BinarySearchTree<T>
    {
        // Member Variables
        Node<T> root; // Root node

        // Default Constructor
        public BinarySearchTree()
        {
            this.root = null;
        }


        // METHODS
        // Insert the provided value in the right place in the tree
        public void insert(T value) // O(logN)
        {
            Node<T> newNode = new Node<T>(value); // We create a new node

            // If it's the first inserted node, we just make it root
            if (this.root == null) {
                this.root = newNode;
                return;
            }

            // If root already exists...
            Node<T> currentNode = this.root; // We start from the root
            
            while (true)
                // If value < current.value
                if (Comparer<T>.Default.Compare(value, currentNode.value) < 0) { // LEFT
                    // If there is no left child, insert there the new node
                    if (currentNode.left == null) { 
                        currentNode.left = newNode;
                        return; // exit loop
                    } // Else, continue
                    currentNode = currentNode.left;
                } else { // If value >= current.value - RIGHT
                    // If there is no right child, insert there the new node
                    if (currentNode.right == null) { 
                        currentNode.right = newNode;
                        return; // exit loop
                    } // Else, continue
                    currentNode = currentNode.right;
                }
        }

        /* Search for the provided value in the tree and return a Dyck path which means 
         * that it returns the steps we had to take to reach the node with the specified 
         * value (1: left, 0: right)*/
        public string lookup(T value) // O(logN)
        {
            if (this.root == null) // If the tree is empty
                return "Tree is empty.";

            // Else
            Node<T> currentNode = this.root; // We start from the root
            string result = string.Empty;

            while (currentNode != null) // Until 
                // If value < current.value
                if (Comparer<T>.Default.Compare(value, currentNode.value) < 0) { // LEFT
                    currentNode = currentNode.left;
                    result += "1";
                } // Else if value > current.value
                else if (Comparer<T>.Default.Compare(value, currentNode.value) > 0) { // RIGHT
                    currentNode = currentNode.right;
                    result += "0";
                } else // If found
                    return result;

            // If the node was not found
            return string.Format("Value '{0}' was not found.", value);
        }
        
        // Remove the node with the value specified from our Tree
        public void remove(T value) // O(logN)
        {
            if (this.root == null) // If the tree is empty
                return;

            // Else
            Node<T> currentNode = this.root; // We start from the root
            Node<T> parentNode = null;

            while (currentNode != null)
                // If value < current.value
                if (Comparer<T>.Default.Compare(value, currentNode.value) < 0) { // LEFT
                    parentNode = currentNode;
                    currentNode = currentNode.left;
                } // Else if value > current.value
                else if (Comparer<T>.Default.Compare(value, currentNode.value) > 0) { // RIGHT
                    parentNode = currentNode;
                    currentNode = currentNode.right;
                } else { // If found
                    if (currentNode.right == null) // If there is no right child
                        if (parentNode == null) // If it's root (has no parent)
                            this.root = currentNode.left;
                        else {
                            // If currentNode.value < parentNode.value
                            if (Comparer<T>.Default.Compare(currentNode.value, parentNode.value) < 0)
                                parentNode.left = currentNode.left;
                            // Else if currentNode.value > parentNode.value
                            else if (Comparer<T>.Default.Compare(currentNode.value, parentNode.value) > 0)
                                parentNode.right = currentNode.left;
                        }
                    // If there is right child but it does not have a left child
                    else if (currentNode.right.left == null)
                        if (parentNode == null) // If it's root (has no parent)
                            this.root = currentNode.left;
                        else {
                            // If currentNode.value < parentNode.value
                            if (Comparer<T>.Default.Compare(currentNode.value, parentNode.value) < 0)
                                parentNode.left = currentNode.right;
                            // Else if currentNode.value > parentNode.value
                            else if (Comparer<T>.Default.Compare(currentNode.value, parentNode.value) > 0)
                                parentNode.right = currentNode.right;
                        }
                    // If there is right child that has a left child
                    else {
                        // Find the right child's left most child
                        Node<T> leftmost = currentNode.right.left;
                        Node<T> leftmostParent = currentNode.right;
                        while (leftmost.left != null) {
                            leftmostParent = leftmost;
                            leftmost = leftmost.left;
                        }

                        // Parent's left subtree becomes leftmost's right subtree
                        leftmostParent.left = leftmost.right;
                        leftmost.left = currentNode.left;
                        leftmost.right = currentNode.right;

                        if (parentNode == null)
                            this.root = leftmost;
                        else {
                            // If currentNode.value < parentNode.value
                            if (Comparer<T>.Default.Compare(currentNode.value, parentNode.value) < 0)
                                parentNode.left = leftmost;
                            // Else if currentNode.value > parentNode.value
                            else if (Comparer<T>.Default.Compare(currentNode.value, parentNode.value) > 0)
                                parentNode.right = leftmost;
                        }
                    }
                    return;
                }
        }
    }
}
