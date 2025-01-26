using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySeachTree
{
    public class NodeTS : NodeT
    {
        public char symbol;
        public string kod;
        

        public NodeTS(char symbol, int freq) : base(freq)
        {
            this.symbol = symbol;
            this.kod = string.Empty;
        }
    }
}
