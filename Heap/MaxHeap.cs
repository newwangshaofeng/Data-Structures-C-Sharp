using System.Collections.Generic;

namespace MaxHeap
{
    class MaxHeap<T>
    {
        // Member Variables
        List<T> heap;
        int currentSize;

        // Constructor - Initialize heap
        public MaxHeap(T value)
        {
            // Initialize the heap into a list
            this.heap = new List<T>() { value };
            this.currentSize = 0;
        }

        // Properties
        private int Left(int i) { return 2 * i + 1; }
        private int Right(int i) { return 2 * i + 2; }
        private int Parent(int i) { return (i - 1) / 2; }

        // Member methods
        private void PercolateUp(int i) // Down -> Top
        {
            if (i <= 0)
                return;

            if (Comparer<T>.Default.Compare(heap[i], heap[Parent(i)]) > 0) {
                T temp = heap[i];
                heap[i] = heap[Parent(i)];
                heap[Parent(i)] = temp;
                PercolateUp(Parent(i));
            }
        }

        private void PercolateDown(int i) // Top -> Down
        {
            int l = Left(i);
            int r = Right(i);
            int max = i;
            bool flag = false;
            if (l < currentSize && Comparer<T>.Default.Compare(heap[i], heap[l]) < 0) {
                max = l;
                flag = true;
            }

            if (r < currentSize && Comparer<T>.Default.Compare(heap[r], heap[max]) > 0) {
                max = r;
                flag = true;
            }

            if (flag) {
                T temp = heap[i];
                heap[i] = heap[max];
                heap[max] = temp;
                PercolateDown(max);
            }
        }

        // Insert x into the max heap
        public void Insert(T x)
        {
            currentSize++;
            heap.Add(x);
            PercolateUp(currentSize - 1);
        }

        // Delete the max value of the Heap
        public void DeleteMax()
        {
            if (currentSize == 0)
                return;

            if (currentSize == 1) {
                currentSize--;
                return;
            }

            heap[0] = heap[currentSize - 1];
            currentSize--;
            PercolateDown(0);
        }

        // We print every node along with it's children
        public void PrintEachNode()
        {
            int i = 0;

            while (i < this.currentSize)
            {
                if (Left(i) <= this.currentSize && Right(i) <= this.currentSize)
                    System.Console.WriteLine(heap[Left(i)] + "<-" + heap[i] + "->" + heap[Right(i)]);
                else if (Left(i) <= this.currentSize)
                    System.Console.WriteLine(heap[Left(i)] + "<-" + heap[i]);
                else if (Right(i) <= this.currentSize)
                    System.Console.WriteLine(heap[i] + "->" + heap[Right(i)]);

                i++;
            }
        }
    }
}
