using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicasPilasYColas
{
    internal class Stack
    {
        private int capacity;
        private int[] stack;
        private int top;

        public Stack(int capacity)
        {
            this.capacity = capacity;
            this.stack = new int[capacity];
            this.top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == capacity - 1;
        }

        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full. Cannot push element.");
                return;
            }
            top++;
            stack[top] = item;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot pop element.");
                return -1; // or throw an exception
            }
            int item = stack[top];
            top--;
            return item;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot peek element.");
                return -1; // or throw an exception
            }
            return stack[top];
        }

        public int Size()
        {
            return top + 1;
        }
    }
}
