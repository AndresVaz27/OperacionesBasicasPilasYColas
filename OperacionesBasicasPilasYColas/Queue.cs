using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicasPilasYColas
{
    internal class Queue
    {
        private int capacity;
        private int[] queue;
        private int front;
        private int rear;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            this.queue = new int[capacity];
            this.front = this.rear = -1;
        }

        public bool IsEmpty()
        {
            return front == -1;
        }

        public bool IsFull()
        {
            return (rear + 1) % capacity == front;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot enqueue element.");
                return;
            }
            if (IsEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear = (rear + 1) % capacity;
            }
            queue[rear] = item;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue element.");
                return -1; // or throw an exception
            }
            int item = queue[front];
            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = (front + 1) % capacity;
            }
            return item;
        }

        public int Size()
        {
            if (IsEmpty())
            {
                return 0;
            }
            if (front <= rear)
            {
                return rear - front + 1;
            }
            else
            {
                return capacity - front + rear + 1;
            }
        }
    }

    
}
