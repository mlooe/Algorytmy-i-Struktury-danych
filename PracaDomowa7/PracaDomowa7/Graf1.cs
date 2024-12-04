using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa7
{
    public class Graf1
    {
        public List<NodeG1> nodes = new List<NodeG1>();                        //wierzchołki
        public List<Edge> edges = new List<Edge>();                            //krawędzie


        public Graf1(Edge k)                                 //w konstruktorze użyć metody Add
        {
            Add(k);
        }


        public int IleNowychWezlow(Edge k)
        {
            int count = 0;
            
            if (!nodes.Contains(k.start))
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

            if (!nodes.Contains(k.end))
            {
                nodes.Add(k.end);
            }

            edges.Add(k);
        }


        public void Join(Graf1 g1)
        {
            for (int i = 0; i < g1.edges.Count; i++)
            {
                this.Add(g1.edges[i]);
            }

        }

        public Graf1 AlgorytmKruskala()
        //this
        {
            var krawedzie = this.edges.OrderBy(k => k.weight).ToList();
            var grafy = new List<Graf1>() {new Graf1(krawedzie[0])};
            //grafy.add(Graf1(krawedzie[0]))

            for(int i = 1; i < krawedzie.Count; i++)
            {
                var k = krawedzie[i];
                var l = -1;
                for(int j = 0; i < grafy.Count; j++)
                {
                    var g = grafy[j];
                    switch (g.IleNowychWezlow(k))
                    {
                        case 2:
                            grafy.Add(new Graf1(k));
                            j = grafy.Count;
                            break;

                        case 0:
                            j = grafy.Count;
                            break;

                        case 1:
                            if (l == -1)
                            {
                                g.Add(k);
                                l = j;
                            }

                            else
                            {
                                grafy[l].Join(g);
                                grafy.RemoveAt(j);
                                j = grafy.Count;
                            }
                            break;
                    }
                }

            }

            return grafy[0];
        }

        List<Element> AlgorytmDijkstry(NodeG1 start)
        {
            //int.MaxValue - nieskończoność
            //var tabelka = this.PrzygotujTabelke(start);
            //var zbS = new List<NodeG1>();

            //var kandydaci = tabelka.Where(e => !zbS.Contains(e.wezel)
            //var kandydat = kandydaci.OrderBy(e => e.dystans).First();
            //this.edges.Where(k => k.start == kandydat.wezel).ToList();             //dodać and i warunek kandydaci
            
        }
    






    }

}
