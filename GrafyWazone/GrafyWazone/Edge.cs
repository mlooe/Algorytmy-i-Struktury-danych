using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafyWazone
{
    public class Edge
    {
        public NodeW start;
        public NodeW end;
        public int weight;

        public Edge(NodeW start, NodeW end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }



    }
}
