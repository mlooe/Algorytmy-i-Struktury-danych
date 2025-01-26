using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafyZadanie
{
    public class NodeG
    {
        public List<NodeG> sasiedzi = new List<NodeG>();
        int data;

        public NodeG(int liczba)
        {
            this.data = liczba;
        }

        

        public void DodajSasiada(NodeG sasiad1, NodeG sasiad2)
        {
            if (!sasiad1.sasiedzi.Contains(sasiad2))       
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
            return this.data.ToString();
        }


        // przejście wszerz (BFS)
        public List<NodeG> PrzejscieGrafBFS(NodeG start)
        {
            List<NodeG> not_visited = new List<NodeG>();
            List<NodeG> visited = new List<NodeG>();
            not_visited.Add(start);

            while (not_visited.Count > 0)
            {
                NodeG current = not_visited[0];
                not_visited.RemoveAt(0);
                if (!visited.Contains(current))
                {
                    visited.Add(current);
                    foreach (var sasiad in current.sasiedzi)
                    {
                        if (!visited.Contains(sasiad) && !not_visited.Contains(sasiad))
                        {
                            not_visited.Add(sasiad);
                        }
                    }
                }
            }
            return visited;

        }

        // przejście w głąb (DFS)
        public List<NodeG> PrzejscieGrafDFS(NodeG start)
        {
            List<NodeG> visited = new List<NodeG>();
            return PrzejscieGrafDFS(start, visited);
        }

        public List<NodeG> PrzejscieGrafDFS(NodeG start, List<NodeG> visited)
        {
            if (!visited.Contains(start))
            {
                visited.Add(start);
                foreach (var sasiad in start.sasiedzi)
                {
                    PrzejscieGrafDFS(sasiad, visited);
                }
                return visited;
            }
            else
            {
                return visited;
            }
        }
    }
}
