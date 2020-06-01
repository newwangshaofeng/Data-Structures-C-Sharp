using System.Collections.Generic;


namespace Stack_Implementation__List_
{
    class Stack<T>
    {
        List<T> array; // List that's basically our Stack

        // Constructor
        public Stack()
        {
            this.array = new List<T>();
        }

        // Methods
        public T peek() // Get the top element - O(1)
        {
            return this.array[this.array.Count - 1];
        }

        public void push(T value) // Add a node to the top - O(1)
        {
            this.array.Add(value);
        }

        public void pop() // Remove from top - O(1)
        {
            this.array.Remove(this.array[this.array.Count - 1]);
        }
    }
}
