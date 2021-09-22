using System;
using System.Collections.Generic;
using System.Linq;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            // Adds elements {0, 1, 2, 3, 4} to queue
            for (int i = 0; i < 5; i++)
                queue.Enqueue(i);

            // Print out Elements of the Queue
            Console.Write("Elements of Queue: ");
            queue.ToList().ForEach(x => Console.Write($"{x.ToString()} "));
            Console.WriteLine(Environment.NewLine);
            
            // To remove the head of queue.
            // In this the oldest element '0' will be removed
            Console.WriteLine("Going to Dequeue element");

         
            Console.WriteLine($"removed element {queue.Dequeue().ToString()}");

            Console.Write("Elements of Queue: ");
            queue.ToList().ForEach(x => Console.Write($"{x.ToString()} "));
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("View the head of queue");
           Console.WriteLine($"head of queue- {queue.Peek().ToString()}");
            Console.WriteLine(Environment.NewLine);
            
           
            Console.WriteLine($"Size of queue- {queue.Count}");
            
            //Add another item to queue
            Console.WriteLine("Add new element to queue");
            queue.Enqueue(5);
            
            Console.Write("Elements of Queue: ");
            queue.ToList().ForEach(x => Console.Write($"{x.ToString()} "));
            Console.WriteLine(Environment.NewLine);
        }
    }
}