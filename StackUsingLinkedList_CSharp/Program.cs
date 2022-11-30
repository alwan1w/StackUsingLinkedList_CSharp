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
}
