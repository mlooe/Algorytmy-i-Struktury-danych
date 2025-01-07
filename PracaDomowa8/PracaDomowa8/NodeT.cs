using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa8
{
    internal class NodeT
    {
        public NodeT left;
        public NodeT right;
        public NodeT parent;
        public int data;

        public NodeT(int data)
        {
            this.data = data;
            left = null;
            right = null;
            parent = null;
        }

        public class NodeTS : NodeT
        {
            public char symbol;

            public NodeTS(char symbol, int czestosc) : base(czestosc)
            {
                this.symbol = symbol;
            }
        }

        public int GetLiczbaDzieci()
        {
            int wynik = 0;
            if (this.left != null)
            {
                wynik++;
            }
            if (this.right != null)
            {
                wynik++;
            }
            return wynik;
        }
    }

}
