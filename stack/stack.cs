using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Stack<T>
    {
        private List<T> stack;
        private int sp; // next object stack pointer
        private int capacity;

        public Stack(int capacity = 10)
        {
            stack = new List<T>();
            sp = 0;
            this.capacity = capacity;
        }

        public int Capacity { get { return capacity; } }

        public bool Push(T obj)
        {
            bool overflow = false;
            if (sp == capacity)
            {
                stack.RemoveAt(0);
                overflow = true;
            }
            else
            {
                sp++;
            }
            stack.Add(obj);
            return overflow;
        }

        public T Peek()
        {
            if (sp == 0)
                throw new Exception("Stack empty");
            return stack[sp - 1];
        }

        public T Pop()
        {
            if (sp == 0)
                throw new Exception("Stack empty");
            T retval = stack[--sp];
            stack.RemoveAt(sp);
            return retval;
        }



    }
}