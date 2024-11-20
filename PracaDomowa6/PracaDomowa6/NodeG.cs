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
        List<NodeG> sasiedzi = new List<NodeG>();
        int data;

        NodeG(int liczba)
        {
            this.data = liczba;
        }


        public override string ToString()
        {
            return this.data.ToString();
        }

        public void PrzejscieGraf(int data)             // przejscie po sąsiadach, których nie ma w liscie 
        {
            List<int> lista = new List<int>();

            for(int i = 0; i < sasiedzi.Count; i++)
            {
                if (!lista.Contains(data))
                {
                    lista.Add(data);
                }
            }

                                                      //inne przejście po liście (wszerz) | wierzchołek oraz liste jako parametry
        }


    }
}
