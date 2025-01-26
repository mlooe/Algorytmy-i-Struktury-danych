using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySeachTree
{
    public class HuffmanTree
    {
        public NodeT korzen;
        public Dictionary<char, string> huffCodes = new();
        public List<NodeT> lista = new();
        public string code;


        private void makeList(string input)
        {
            Dictionary<char, int> dict = new();
            foreach (char i in input)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict[i] = 1;
                }
            }

            foreach (var n in dict)
            {
                lista.Add(new NodeTS(n.Key, n.Value));
            }
            lista = lista.OrderBy(e => e.data).ToList();
        }

        private void BuildTree()
        {
            while (lista.Count > 1)
            {
                lista = lista.OrderBy(n => n.data).ThenBy(e => e.GetType() == typeof(NodeT) ? 0 : 1).ToList();

                NodeT left = lista[0];
                NodeT right = lista[1];

                NodeT parent = new NodeT(left.data + right.data)
                {
                    lewe = left,
                    prawe = right
                };

                lista.RemoveAt(0);
                lista.RemoveAt(0);
                lista.Add(parent);
            }
            korzen = lista[0];
        }


        private void GenerateHuffmanCodes(NodeT node, string code)
        {
            if (node == null)
                return;

            if (node is NodeTS leafNode)
            {
                huffCodes[leafNode.symbol] = code;
                return;
            }

            GenerateHuffmanCodes(node.lewe, code + "0");
            GenerateHuffmanCodes(node.prawe, code + "1");
        }


        public string Encode(string input)
        {
            if (input == "")
            {
                return string.Empty;
            }
            makeList(input);
            BuildTree();
            GenerateHuffmanCodes(korzen, "");
            string encoded = "";
            foreach (char c in input)
            {
                encoded += huffCodes[c];
            }
            code = encoded;
            return encoded;
        }


        public string DecodeLast()
        {
            string decoded = "";
            NodeT currentNode = korzen;

            foreach (char bit in code)
            {
                if (bit == '0')
                    currentNode = currentNode.lewe;
                else
                    currentNode = currentNode.prawe;

                if (currentNode is NodeTS leafNode)
                {
                    decoded += leafNode.symbol;
                    currentNode = korzen;
                }
            
            }
            return decoded;
        }

    }
}
