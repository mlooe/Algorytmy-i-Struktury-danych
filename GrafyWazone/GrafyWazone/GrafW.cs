using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GrafyWazone
{
    public class GrafW
    {
        public List<NodeW> nodes = new List<NodeW>();
        public List<Edge> edges = new List<Edge>();

        public GrafW(List<NodeW> nodes, List<Edge> edges)
        {
            this.nodes = nodes;
            this.edges = edges;
        }
        public GrafW() {
        }

        public GrafW(Edge k)
        {
            nodes = new List<NodeW>
            {
                k.start, k.end 
            };

            edges = new List<Edge>
            {
                k
            };
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


        public void AddEdge(Edge k)
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


        public void Join(GrafW g1)
        {
            foreach(var i in g1.edges)
            {
                if (!edges.Contains(i))
                {
                    edges.Add(i);
                }
            }

            foreach(var n in g1.nodes)
            {
                if (!nodes.Contains(n))
                {
                    nodes.Add(n);
                }
            }
        }

        public GrafW AlgorytmKruskala()
        {
            var krawedzie = edges.OrderBy(k => k.weight).ToList();
            var grafy = new List<GrafW>() 
            { 
                new GrafW(krawedzie[0]) 
            };

            //grafy.add(Graf1(krawedzie[0]))

            for (int i = 1; i < krawedzie.Count; i++)
            {
                var k = krawedzie[i];
                var l = -1;
                for (int j = 0; j < grafy.Count; j++)
                {
                    var g = grafy[j];
                    switch (g.IleNowychWezlow(k))
                    {
                        case 2:
                            grafy.Add(new GrafW(k));
                            j = grafy.Count;
                            break;

                        case 0:
                            j = grafy.Count;
                            break;

                        case 1:
                            if (l == -1)
                            {
                                g.AddEdge(k);
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

        public List<Element> PrzygotujTabelke(NodeW start)
        {
            List<Element> tabela = new List<Element>() { new Element(start, 0, null) };
            foreach (NodeW n in nodes.Where(e => e != start))
            {
                tabela.Add(new Element(n, int.MaxValue, null));
            }
            return tabela;
        }

        public List<Element> AlgorytmDijkstry(NodeW start)
        {
            var odwiedzone = new List<NodeW>();
            var tabela = this.PrzygotujTabelke(start);

            while (tabela.Count > odwiedzone.Count)
            {
                var kandydat = tabela.Where(e => !odwiedzone.Contains(e.wezel)).ToList().OrderBy(e => e.dystans).First();

                foreach (Edge e in edges.Where(e => e.start.Equals(kandydat.wezel)))
                {

                    Element wezelKoniec = tabela.FirstOrDefault(f => f.wezel == e.end);

                    if (wezelKoniec != null)
                    {
                        if (wezelKoniec.dystans > kandydat.dystans + e.weight)
                        {
                            wezelKoniec.dystans = kandydat.dystans + e.weight;
                            wezelKoniec.poprzednik = e.start;

                        }
                    }
                }
                odwiedzone.Add(kandydat.wezel);
            }

            return tabela;
        }


    }
}
