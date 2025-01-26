using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BinarySeachTree
{
    public class Tree
    {
        public NodeT korzen;

        public Tree()
        {
            korzen = null;
        }


        public NodeT ZnajdzRodzica(NodeT dziecko)
        {
            var temp = this.korzen;
            while (true)
            {
                if (dziecko.data < temp.data)
                {
                    if (temp.lewe == null)
                    {
                        return temp;
                    }
                    else
                    {
                        temp = temp.lewe;
                    }
                }
                else
                {
                    if (temp.prawe == null)
                    {
                        return temp;
                    }
                    else
                    {
                        temp = temp.prawe;
                    }
                }
            }
        }

        public NodeT FindNode(int data)
        {
            NodeT temp = korzen;
            while (temp != null)
            {
                if (data < temp.data)
                {
                    temp = temp.lewe;
                }
                else if (data > temp.data)
                {
                    temp = temp.prawe;
                }
                else
                    return temp;
            }
            return null;
        }

        public NodeT Add(int liczba)
        {
            var dziecko = new NodeT(liczba);
            if (this.korzen == null)
            {
                this.korzen = dziecko;
            }
            else
            {
                var rodzic = this.ZnajdzRodzica(dziecko);
                if (dziecko.data < rodzic.data)
                {
                    rodzic.PolaczLewe(dziecko);
                }
                else
                {
                    rodzic.PolaczPrawe(dziecko);
                }
            }
            return dziecko;
        }

        public NodeT Znajdz(int data)
        {
            NodeT temp = korzen;

            while (temp != null)
            {
                if (data < temp.data)
                {
                    temp = temp.lewe;
                }
                else if (data > temp.data)
                {
                    temp = temp.prawe;
                }
                else
                {
                    return temp;
                }
            }
            return null;
        }

        private NodeT FindMinNode(NodeT node)
        {
            NodeT wynik = node;
            while (wynik.lewe != null)
            {
                wynik = wynik.lewe;
            }
            return wynik;
        }



        private void RemoveElement0(NodeT n)                      //1) odwiązywanie od góry (brak dzieci)
        {
            if (this.korzen == n)
            {
                this.korzen = null;
            }
            else
            {
                var rodzic = n.rodzic;

                if (rodzic.lewe == n)
                    rodzic.lewe = null;

                else if (rodzic.prawe == n)
                    rodzic.prawe = null;
            }
        }



        private void RemoveElement1(NodeT n)                      //2) jedno dziecko
        {
            NodeT dziecko = null;
            if (n.lewe != null)
                dziecko = n.lewe;

            else
                dziecko = n.prawe;
            this.RemoveElement0(dziecko);
            var rodzic = n.rodzic;
            this.RemoveElement0(n);

            dziecko.rodzic = rodzic;

            if (rodzic != null)
            {
                if (rodzic.data > dziecko.data)
                    rodzic.lewe = dziecko;
                else
                    rodzic.prawe = dziecko;
            }
            else
                this.korzen = dziecko;
        }


        public void Remove(int data)
        {
            NodeT remove = Znajdz(data);

            if (remove == null)
            {
                return;
            }


            switch (remove.GetLiczbaDzieci())
            {
                case 0:
                    this.RemoveElement0(remove);
                    break;

                case 1:
                    this.RemoveElement1(remove);
                    break;

                case 2:
                    var k = this.FindMinNode(remove.prawe);
                    remove.data = k.data;
                    if (k.rodzic.lewe == k)
                    {
                        k.rodzic.lewe = k.prawe;
                    }
                    else
                    {
                        k.rodzic.prawe = k.prawe;
                    }
                    if (k.prawe != null)
                    {
                        k.prawe.rodzic = k.rodzic;
                    }
                    break;
            }

        }

        public void TraversePreOrder(NodeT korzen)
        {
            if (korzen == null)
            {
                return;
            }
            Console.WriteLine(korzen.data);
            TraversePreOrder(korzen.lewe);
            TraversePreOrder(korzen.prawe);
        }


        public void TraverseInOrder(NodeT korzen)
        {
            if (korzen == null)
            {
                return;
            }
            TraverseInOrder(korzen.lewe);
            Console.WriteLine(korzen.data);
            TraverseInOrder(korzen.prawe);
        }


        public void TraversePostOrder(NodeT korzen)
        {
            if (korzen == null)
            {
                return;
            }
            TraversePostOrder(korzen.lewe);
            TraversePostOrder(korzen.prawe);
            Console.WriteLine(korzen.data);
        }




        public void PrintBST(NodeT node, string prefix = "", bool isLeft = true)                 // wizualizacja drzewa binarnego BST (użyto pomocy naukowej)
        {
            if (node != null)
            {
                Console.WriteLine(prefix + (isLeft ? "├── " : "└── ") + node.data);
                PrintBST(node.lewe, prefix + (isLeft ? "│   " : "    "), true);
                PrintBST(node.prawe, prefix + (isLeft ? "│   " : "    "), false);
            }
        }



    }
}
