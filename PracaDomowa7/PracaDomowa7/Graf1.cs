using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa7
{
    internal class Graf1
    {
        public List<NodeG1> nodes = new List<NodeG1>();
        public List<Edge> edges = new List<Edge>();


        public Graf1(Edge k)                                 //w konstruktorze użyć metody Add
        {
            Add(k);
        }


        public int IleNowychWezlow(Edge k)               
        {
            int count = 0;

            if(!nodes.Contains(k.start))
            {
                count++;
            }

            if (!nodes.Contains(k.end))
            {
                count++;
            }
            return count;
        }


        public void Add(Edge k)                             //podobna ma być do IleNowychWezlow
        {
            if (!nodes.Contains(k.start))
            {
                nodes.Add(k.start);
            }

            if(!nodes.Contains(k.end))
            {
                nodes.Add(k.end);
            }

            edges.Add(k);
        }


        public void Join(Graf1 g1)
        {
            for(int i = 0; i < g1.edges.Count; i++)
            {
                this.Add(g1.edges[i]);
            }

        }







    }
}
