using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa6
{
    internal class Graf1
    {
        public List<NodeG1> nodes = new List<NodeG1>();
        public List<Edge> edges = new List<Edge>();

        Graf1(Edge k)          //w konstruktorze użyć metody Add
        {
            
        }

        public int IleNowychWezlow(Edge k)   //sprawdzanie który przypadek     
        {
            
        }

        public void Add(Edge k)                  //podobna ma być do IleNowychWezlow
        {
            
        }

        public void Join(Graf1 g1) 
        {
            for(int i =0; i< g1.edges.Count; i++)
            {
                this.Add(g1.edges[i]);
            }
        }




    }
}
