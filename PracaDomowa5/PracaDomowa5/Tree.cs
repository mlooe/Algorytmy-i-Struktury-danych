using System;
using System.Collections.Generic;
using System.Linq;
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
            while(true)
            {
                if(dziecko.data < temp.data)
                {
                    if(temp.lewe == null)
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
                    if(temp.prawe == null)
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
            if(this.root == null)
            {
                this.root = dziecko;
            }
            else
            {
                var rodzic = this.ZnajdzRodzica(dziecko);
                if(dziecko.data < rodzic.data)
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
            if (node == null) return null; 

            
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
                
                if (node.lewe == null && node.prawe == null)      //1) gdy wezeł nie ma dzieci
                {
                    return null; 
                }

                
                if (node.lewe == null)                        //2) gdy węzel ma jedno dziecko
                {
                    return node.prawe; 
                }

                else if (node.prawe == null)
                {
                    return node.lewe; 
                }                                                //3) gdy wezel ma dwoje dzieci

                NodeT minNode = FindMinNode(node.prawe);
                node.data = minNode.data; 
                node.prawe = RemoveFromTree(node.prawe, minNode.data); 
            }

            return node;
        }

        
        private NodeT FindMinNode(NodeT node)                //znajdujemy najmniejszy wezel w danym poddrzewie
        {
            while (node.lewe != null)
            {
                node = node.lewe;
            }
            return node;
        }



    }

}


