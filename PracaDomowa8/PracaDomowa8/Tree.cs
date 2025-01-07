using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa8
{
    internal class Tree
    {
        public NodeT root;

        public Tree()
        {
            root = null;
        }

        public void Add(int data)
        {
            NodeT child = new NodeT(data);
            if (root == null)
            {
                root = child;
            }
            else
            {
                NodeT current = root;
                NodeT parent = null;
                while (current != null)
                {
                    parent = current;
                    if (data < parent.data)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
                if (data < parent.data)
                {
                    parent.left = child;
                }
                else
                {
                    parent.right = child;
                }
                child.parent = parent;
            }
        }

        public NodeT FindNode(int data)
        {
            NodeT current = root;
            while (current != null)
            {
                if (data < current.data)
                {
                    current = current.left;
                }
                else if (data > current.data)
                {
                    current = current.right;
                }
                else
                    return current;
            }
            return null;
        }


    }
}
