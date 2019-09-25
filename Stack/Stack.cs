using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T>
    {
        private LinkedList<T> linkedList;

        public Stack()
        {
            linkedList = new LinkedList<T>();


            var last = linkedList.Last;


            var enumerator = linkedList.GetEnumerator();

            
        }

        // add item to top of stack
        public void Push(T item)
        {
            linkedList.AddLast(item);
        }

        // return top of stack and remove it.
        public T Pop()
        {
            T topOfStack = linkedList.Last.Value;

            linkedList.RemoveLast();

            return topOfStack;
        }

        // return top of stack.
        public T Peek()
        {
            return linkedList.Last.Value;
        }


        public int Size => linkedList.Count;

    }
}
