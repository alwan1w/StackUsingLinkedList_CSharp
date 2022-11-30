using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList_CSharp
{
    class Node
    {
        public int info;
        public Node Next;
        public Node(int i, Node n)
        {
            info = i;
            Next = n;
        }
    }

    class Stack
    {
        Node top;

        public Stack()
        {
            top = null;
        }

        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }

        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.Next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed.");
        }
    }
}
