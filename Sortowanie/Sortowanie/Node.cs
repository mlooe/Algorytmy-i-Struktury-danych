using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    public class Node
    {
        public Node next;
        public Node prev;
        public int data;

        public Node(int data)
        {
            this.data = data;
        }


        // Drzewo vvv




        public class NodeT
        {
            public NodeT lewe;
            public NodeT prawe;
            public NodeT rodzic;
            public int data;
        }

    }
}
