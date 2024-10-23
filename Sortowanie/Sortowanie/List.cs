using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
   
    internal class List
    {
        public Node head;
        public Node tail;
        public int count;

        public void AddLast(int liczba)
        {
            Node n = new Node(liczba);
            this.tail.next = n;
            n.prev = this.tail;
            this.count++;
            this.tail = n;
        }


        public void AddFirst(int liczba)
        {
            Node n = new Node(liczba);
            this.tail.prev = n;
            n.next = this.head;
            this.count++;
            this.head = n;
        }


        public void RemoveFirst(int liczba)
        {
            Node n = new Node(liczba);
            this.tail.prev = n;
            n.next = this.head;
            this.count--;
            this.head = n;
        }


        public void RemoveLast(int liczba)
        {
            Node n = new Node(liczba);
            this.tail.next = n;
            n.prev = this.tail;
            this.count--;
            this.tail = n;
        }


        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

    }
    //  AddFirst(int data)
    //  AddLast(int data)
    //  Node/RemoveFirst()
    //  Node/RemovaLast()
    //  int Get(int n)
    //  string toString()

}
