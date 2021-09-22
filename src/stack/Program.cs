using System;
using System.Collections.Generic;
using System.Linq;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and Add items to a stack
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 5; i++)
                stack.Push(i);
            
            Console.Write("Elements of stack: ");
            stack.ToList().ForEach(x => Console.Write($"{x.ToString()} "));
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine("Going to Pop element off stack");

         
            Console.WriteLine($"removed element {stack.Pop().ToString()}");
            
            Console.Write("Elements of Stack: ");
            stack.ToList().ForEach(x => Console.Write($"{x.ToString()} "));
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine("View the head of stack");
            Console.WriteLine($"head of stack- {stack.Peek().ToString()}");
            Console.WriteLine(Environment.NewLine);
            
           
            Console.WriteLine($"Size of stack- {stack.Count}");
            
            Console.WriteLine($"Add element to stack");
            stack.Push(5);
            Console.Write("Elements of Stack: ");
            stack.ToList().ForEach(x => Console.Write($"{x.ToString()} "));
            Console.WriteLine(Environment.NewLine);
        }
    }
}