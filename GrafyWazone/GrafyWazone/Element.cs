using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafyWazone
{
    public class Element
    {
        public NodeW wezel;
        public int dystans;
        public NodeW poprzednik;

        public Element(NodeW wezel, int dystans, NodeW poprzednik)
        {
            this.wezel = wezel;
            this.dystans = dystans;
            this.poprzednik = poprzednik;
        }
    }
}
