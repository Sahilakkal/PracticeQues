using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MyDataStructures
{
    internal class MyStack<T>
    {
        private T[] arr;
        private int top = -1;
        public MyStack(int size)
        {
            arr = new T[size];
        }

        public T PushIntoStack(T item)
        {
            if (top == arr.Length - 1)
            {
                throw new StackOverflowException();
            }
            arr[++top] = item;
            return item;

        }

        public T PopFromStack()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack Underflow ");
            }

            return arr[top--];

        }

        public T PeekintoStack()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack underflow");
            }
            return arr[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void PrinStack()
        {
            int currentIndex = top;
            while (currentIndex != -1)
            {
                Console.WriteLine($"Element at {currentIndex}th position is {arr[currentIndex]}");
                currentIndex--;
            }
        }

    }

}
