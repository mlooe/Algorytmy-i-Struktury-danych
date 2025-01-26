using System.ComponentModel;

namespace GrafyZadanie
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            NodeG node1 = new NodeG(1);
            NodeG node2 = new NodeG(2);
            NodeG node3 = new NodeG(3);
            NodeG node4 = new NodeG(4);
            NodeG node5 = new NodeG(5);
            

            node1.DodajSasiada(node1, node2);
            node1.DodajSasiada(node1, node3);

            node2.DodajSasiada(node2, node4);
            node2.DodajSasiada(node2, node5);


            List<NodeG> lista = new List<NodeG>(node1.PrzejscieGrafDFS(node1));
            foreach(var node in lista)
            {
                Console.WriteLine(node + " ");
            }

            Console.WriteLine("--------------------------------");


            List<NodeG> lista2 = new List<NodeG>(node1.PrzejscieGrafBFS(node1));
            foreach(var x in lista2)
            {
                Console.WriteLine(x + " ");
            }

        }
    }
}











