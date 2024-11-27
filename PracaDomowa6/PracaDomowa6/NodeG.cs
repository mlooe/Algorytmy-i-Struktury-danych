using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa6
{
    public class NodeG
    {
        public List<NodeG> sasiedzi = new List<NodeG>();
        public int data;

        public NodeG(int liczba)
        {
            this.data = liczba;
        }


        public override string ToString()
        {
            return this.data.ToString();
        }




    }
}
