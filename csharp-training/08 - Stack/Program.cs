using System;

namespace _08___Stack
{
    class Program
    {
        static void Main()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Clear();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
