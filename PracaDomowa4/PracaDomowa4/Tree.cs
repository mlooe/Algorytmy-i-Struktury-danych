using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa4
{
    public class Tree
    {
        public NodeT korzen;
        

        public void Add(int liczba)
        {
            NodeT newNode = new(liczba);
            if (this.korzen == null)
            {
                this.korzen = newNode;
                return;
            }
            var rodzic = this.szukajRodzica(newNode, this.korzen);
            newNode.rodzic = rodzic;
            if (newNode.data >= rodzic.data)
            {
                rodzic.prawe = newNode;
            }
            else
            {
                rodzic.lewe = newNode;
            }
        }

        public NodeT szukajRodzica(NodeT dziecko, NodeT rodzic)
        {
            if (dziecko.data < rodzic.data)
            {
                if (rodzic.lewe == null)
                {
                    return rodzic;
                }
                return szukajRodzica(dziecko, rodzic.lewe);
            }
            if (dziecko.data >= rodzic.data)
            {
                if (rodzic.prawe == null)
                {
                    return rodzic;
                }
                return szukajRodzica(dziecko, rodzic.prawe);
            }
            return null;
        }

        public string TraverseInOrder(NodeT korzen, string s1)
        {
            if(korzen == null)
            {
                return s1;
            }

            s1 = TraverseInOrder(korzen.lewe, s1);
            s1 += korzen.data.ToString() + ", ";
            s1 = TraverseInOrder(korzen.prawe, s1);

            return s1;
        }


        public string ijkb()
        {
            string s1 = "";
            return TraverseInOrder(korzen, s1);
           
        }

    }





}
