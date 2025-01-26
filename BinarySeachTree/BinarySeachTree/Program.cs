using System.Reflection.Emit;
using System.Text;

namespace BinarySeachTree
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Tree t1 = new Tree();

            t1.Add(3);
            t1.Add(2);
            t1.Add(5);
            t1.Add(1);
            t1.Add(6);
            t1.Add(4);
            t1.Add(8);

            Console.WriteLine("Drzewo poczatkowe");
            t1.PrintBST(t1.korzen);

            Console.WriteLine("\n\nTraverse Pre Order");
            t1.TraversePreOrder(t1.korzen);

            Console.WriteLine("\n\nTraverse In Order");
            t1.TraverseInOrder(t1.korzen);

            Console.WriteLine("\n\nTraverse Post Order");
            t1.TraversePostOrder(t1.korzen);


            t1.Remove(8);
            Console.WriteLine("\n\nDrzewo po usunięciu 8: ");
            t1.PrintBST(t1.korzen);

            t1.Remove(4);
            t1.Remove(5);
            Console.WriteLine("\n\nDrzewo po usunięciu 4 oraz 5: ");
            t1.PrintBST(t1.korzen);

            Console.WriteLine("\n\n\n---------------------------");

            
            string text = "INFORMATYKA";

            HuffmanTree huffmanTree = new HuffmanTree();

            string encoded = huffmanTree.Encode(text);
            string decoded = huffmanTree.DecodeLast();

            Console.WriteLine("-> Oryginalny tekst: " + text);
            Console.WriteLine("\nZakodowany tekst: " + encoded);
            Console.WriteLine("\nOdkodowany tekst: " + decoded);




        }
    }
}