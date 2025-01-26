using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyDwukierunkowe
{
    internal class Node
    {
        public Node next;
        public Node prev;
        public int data;

        public Node(int data)
        {
            next = null;
            prev = null;
            this.data = data;
        }
    }
}
