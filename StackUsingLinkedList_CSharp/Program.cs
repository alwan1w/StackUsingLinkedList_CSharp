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

        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.Next; //Make top point to the next node in sequence
        }

        public void display()
        {
            Node tmp;
            if (empty())    //If stack is empty
                Console.WriteLine("\nStack Empty");
            else
            {
                //Traverse the list from begginning till end
                for (tmp = top; tmp != null; tmp = tmp.Next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
    }
}
