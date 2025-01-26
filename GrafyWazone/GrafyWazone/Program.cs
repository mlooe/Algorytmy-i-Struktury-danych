namespace GrafyWazone
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<NodeW> nodes = new List<NodeW>
            {
                new NodeW(0),
                new NodeW (1),
                new NodeW (2),
                new NodeW (3),
                new NodeW (4),
                new NodeW (5),

            };

            List<Edge> edges = new List<Edge>
            {
                new Edge(nodes[0], nodes[1], 1),
                new Edge(nodes[4], nodes[5], 2),
                new Edge(nodes[5], nodes[3], 3),
                new Edge(nodes[0], nodes[2], 4),
                new Edge(nodes[3], nodes[1], 5),
                new Edge(nodes[1], nodes[2], 6),
                new Edge(nodes[2], nodes[5], 6),
                new Edge(nodes[0], nodes[4], 7),
                new Edge(nodes[4], nodes[3], 8),
                new Edge(nodes[0], nodes[5], 9)
            };

            GrafW graf = new GrafW(nodes, edges);
            var result = graf.AlgorytmKruskala();

            Console.WriteLine("Algorytm Kruskala: ");
            foreach(var edge in result.edges)
            {
                Console.WriteLine(edge.start.data + " -- " + edge.end.data + ", Weight = " + edge.weight);
            }


            List<NodeW> nodes2 = new List<NodeW>
            {
                new NodeW(0),
                new NodeW(1),
                new NodeW(2),
                new NodeW(3),
                new NodeW(4),
                new NodeW(5)
            };

            List<Edge> edges2 = new List<Edge>
            {
                new Edge(nodes2[0], nodes2[1], 3),
                new Edge(nodes2[1], nodes2[4], 3),
                new Edge(nodes2[1], nodes2[2], 1),
                new Edge(nodes2[2], nodes2[3], 3),
                new Edge(nodes2[3], nodes2[4], 1),
                new Edge(nodes2[4], nodes2[5], 1)
            };

            GrafW graf2 = new GrafW(nodes2, edges2);
            var result2 = graf2.AlgorytmDijkstry(nodes2[0]);
            Console.WriteLine("\n\nAlgorytm Dijsktry: ");

            foreach(var x in result2)
            {
                Console.WriteLine("Wezel: " + x.wezel.data + ", Dystans: " + x.dystans);
            }


            



        }


    }
}
