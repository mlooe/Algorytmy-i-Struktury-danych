using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa5
{
    public class Tree
    {
        public NodeT root;

        public NodeT ZnajdzRodzica(NodeT dziecko)
        {
            var temp = this.root;
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


        public NodeT Add(int liczba)                      //dodawanie elementu do BST
        {
            var dziecko = new NodeT(liczba);
            if (this.root == null)
            {
                this.root = dziecko;
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


        public string TraverseInOrder(NodeT korzen, string s1)      //przechodzenie drzewa in-order
        {
            if (korzen == null)
            {
                return s1;
            }

            s1 = TraverseInOrder(korzen.lewe, s1);
            s1 += korzen.data.ToString() + ", ";
            s1 = TraverseInOrder(korzen.prawe, s1);

            return s1;
        }



        public string ToString()                    //zamienienie "TraverseInOrder" na string  
        {
            string s1 = "";
            return TraverseInOrder(root, s1);
        }

        public void Remove(int value)
        {
            root = RemoveFromTree(root, value);
        }



        private NodeT RemoveFromTree(NodeT node, int value)
        {
            if (node == null) 
                return null;


            if (value < node.data)
            {
                node.lewe = RemoveFromTree(node.lewe, value);
            }

            else if (value > node.data)
            {
                node.prawe = RemoveFromTree(node.prawe, value);
            }
            else
            {

                if (node.lewe == null && node.prawe == null)      //1) 
                {
                    return null;
                }


                if (node.lewe == null)                        //2) 
                {
                    return node.prawe;
                }

                else if (node.prawe == null)
                {
                    return node.lewe;
                }                                                //3) 

                NodeT minNode = FindMinNode(node.prawe);
                node.data = minNode.data;
                node.prawe = RemoveFromTree(node.prawe, minNode.data);
            }

            return node;
        }

        //private void RemoveElement0(NodeT n)                      //1) odwiązywanie od góry (brak dzieci)
        //{
            //if(this.root == n)
            //{
                //this.root = null;
            //}

            //else
            //{
                //var rodzic = n.rodzic;
                //if (rodzic.lewe == n)
                    //rodzic.lewe = null;
                
                //else if(rodzic.prawe == n)
                    //rodzic.prawe = null;
            //}


        //}



        //private void RemoveElement1(NodeT n)                      //2) jedno dziecko
        //{
            //NodeT dziecko = null;
            //if (n.lewe != null)
                //dziecko = n.lewe;

            //else
                //dziecko = n.prawe;
            //this.RemoveElement0(dziecko);
            //var rodzic = n.rodzic;
            //this.RemoveElementO(n);

            //dziecko.rodzic = rodzic;

            //if(rodzic != null)
            //{
                //if(rodzic.data > dziecko.data)
                    //rodzic.lewe = dziecko;
                //else
                    //rodzic.prawe = dziecko;
            //}

            //else
                //this.root = dziecko;
        //}


        //private void RemoveElement2(NodeT n)                  //3) dwoje dzieci
        //{
            //switch(n.GetLiczbaDzieci)
            //{
                //case 0;
                    //this.RemoveElement0(n);
                    //break;
                //case 1;
                    //this.RemoveElement1(n);
                    //break;
                //case 2;
                    //var k = this.FindMinNode(n.prawe);
                    //this.RemoveElement(k);


                    //k.lewe = n.lewe;
                    //n.lewe = null;

                    //k.prawe = n.prawe;
                    //n.prawe = null;

                    //k.rodzic = n.rodzic;
                    //n.rodzic = null;

                    
                        
                        

                    
                    //break


        //}




        private NodeT FindMinNode(NodeT node)                //znajdujemy najmniejszy wezel w danym poddrzewie
        {
            var wynik = node;
            while (wynik.lewe != null)
            {
                wynik = wynik.lewe;
            }
            return wynik;
        }



        //Tree view (kontrolka, użyć aby zwizualizować drzewo)

    }
}
