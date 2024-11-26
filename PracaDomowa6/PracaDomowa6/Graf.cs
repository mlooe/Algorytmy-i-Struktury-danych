using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa6
{
    public class Graf
    {
        List<NodeG> nodes = new List<NodeG>();

        public void DodajSasiada(NodeG sasiad1, NodeG sasiad2)
        {
            if (!this.nodes.Contains(sasiad1))             //dodanie wierzchołków do listy nodes           15-23
            {
                this.nodes.Add(sasiad1);
            }

            if (!this.nodes.Contains(sasiad2))          
            {
                this.nodes.Add(sasiad2);
            }

            if (!sasiad1.sasiedzi.Contains(sasiad2))       //dodanie połączeń między sasiad1 a sasiad2 (w obie strony)      25-33
            {
                sasiad1.sasiedzi.Add(sasiad2);
            }

            if (!sasiad2.sasiedzi.Contains(sasiad1))
            {
                sasiad2.sasiedzi.Add(sasiad1);
            }

        }

        public override string ToString()
        {
            string str = "";

            foreach (var node in this.nodes)
            {
                str = str + node.ToString() + " ";
            }

            return str;
        }

        public void PrzejscieGraf(NodeG start, List<NodeG> visited)
        {
            if (!visited.Contains(start))
            {
                visited.Add(start);
                MessageBox.Show("Odwiedzono: " + start.data);
                foreach (var sasiad in start.sasiedzi)
                {
                    PrzejscieGraf(sasiad, visited);
                }
            }


        }
        


    }
}       //inne przejście po liście (wszerz) | wierzchołek oraz liste jako parametry