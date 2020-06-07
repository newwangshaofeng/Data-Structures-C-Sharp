using System;

namespace Stack_Implementation__List_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.push("google");
            myStack.push("udemy");
            Console.WriteLine(myStack.peek());
            myStack.push("discord");
            myStack.pop();
            myStack.pop();
            Console.WriteLine(myStack.peek());
        }
    }
}
