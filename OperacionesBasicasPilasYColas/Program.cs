using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicasPilasYColas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Queue size: " + queue.Size());
            Console.WriteLine("Dequeued elements:");
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine("--------------------------");
            Stack stack = new Stack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Stack size: " + stack.Size());
            Console.WriteLine("Top element: " + stack.Peek());
            Console.WriteLine("Popped elements:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
           Console.ReadKey  ();
        }
    }
}
