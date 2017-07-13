﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{

    public class MyStack
    {
        /** q1 only keeps last items, q2 keeps others. */
        private Queue<int> q1;
        private Queue<int> q2;

        /** Initialize your data structure here. */
        public MyStack()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            // Empty q1 for push
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }
            q1.Enqueue(x);

        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            int last = q1.Dequeue();
            // swap q1 and q2
            var temp = q2;
            q2 = q1;
            q1 = temp;
            while (q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
            return last;
        }

        /** Get the top element. */
        public int Top()
        {
            return q1.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return q1.Count == 0 && q2.Count == 0;
        }
    }


    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
