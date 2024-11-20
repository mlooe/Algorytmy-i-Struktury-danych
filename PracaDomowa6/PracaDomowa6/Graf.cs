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

        public void dodajSasiada(NodeG sasiad)
        {
            if (!this.nodes.Contains(sasiad))
            {
                this.nodes.Add(sasiad);
            }     
            
        }




    }

}
