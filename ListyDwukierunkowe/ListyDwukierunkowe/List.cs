using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyDwukierunkowe
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count;

        public List()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFirst(int data)
        {
            Node n = new Node(data);

            if(head == null)
            {
                head = n;
                tail = n;
            }
            else
            {
                n.next = head;
                head.prev = n;
                head = n;

            }
            count++;
        }

        public void AddLast(int data)
        {
            Node n = new Node(data);

            if (tail == null)
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.next = n;
                n.prev = tail;
                tail = n;
            }
            count++;
        }

        public void RemoveFirst()
        {
            if(head == null)
            {
                return;
            }

            if(head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            count--;
        }

        public void RemoveLast()
        {
            if(tail == null)
            {
                return;
            }

            if(head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            count--;
        }

        public string ToString1()
        {
            Node curr = head;
            string s = "";
            
            while(curr != tail)
            {
                s += curr.data + " ";
                curr = curr.next;
            }
            s += curr.data;
            return s;
        }

        public int Get(int data)
        {
            int index = 0;
            Node curr = head;    

            while (curr != null)
            {
                if (index == data)
                {
                    return curr.data;
                }
                curr = curr.next;
                index++;
            }
            return curr.data;
        }

        public void PrintAll()
        {
            string s = null;
            Node current = head;
            while (current != null)
            {
                s += current.data.ToString() + ", ";
                current = current.next;
            }
            MessageBox.Show(s);
        }


    }
}
