using System;

namespace Stack_Implementation__Linked_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();

            myStack.push("Google");
            myStack.push("Udemy");
            myStack.push("Discord");
            Console.WriteLine(myStack.peek());
            myStack.pop();
            myStack.pop();
            Console.WriteLine(myStack.peek());
        }
    }
}
