using System;

namespace Queue_Implementation__Linked_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            myQueue.enqueue("google");
            myQueue.enqueue("discord");
            Console.WriteLine(myQueue.peek());
            myQueue.dequeue();
            Console.WriteLine(myQueue.peek());
        }
    }
}
