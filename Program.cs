namespace Assessed_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Graph graph = new Graph();


            // add nodes to the graph

            graph.AddNode("Dave");
            graph.AddNode("Anwar");
            graph.AddNode("Haniy");
            graph.AddNode("Rob");
            graph.AddNode("Peggy");
            graph.AddNode("Rabia");

            graph.AddEdge("Anwar", "Dave");
            graph.AddEdge("Anwar", "Rob");
            graph.AddEdge("Rob", "Haniy");
            graph.AddEdge("Dave", "Peggy");
            graph.AddEdge("Peggy", "Rob");
            graph.AddEdge("Peggy", "Rabia");
            graph.AddEdge("Rabia", "Anwar");

            Console.WriteLine("Number of nodes in the graph: " + graph.GetNumberOfNodes());
            Console.WriteLine("Number of edges in the graph: " + graph.GetNumberOfEdges());

            List<string> bfsResult = graph.BreadthFirstSearch("Dave");
            Console.WriteLine("BFS starting from Dave: " + string.Join(", ", bfsResult));

            // Test path existence
            Console.WriteLine("Is there a path from Dave to Peggy? " + graph.IsPathExists("Dave", "Peggy"));
            Console.WriteLine("Is there a path from Peggy to Dave? " + graph.IsPathExists("Peggy", "Dave"));
            Console.WriteLine("Is there a path from Dave to Rabia? " + graph.IsPathExists("Dave", "Rabia"));
            Console.WriteLine("Is there a path from Rabia to Dave? " + graph.IsPathExists("Rabia", "Dave"));
            Console.WriteLine("Is there a path from Dave to Anwar? " + graph.IsPathExists("Dave", "Anwar"));
            Console.WriteLine("Is there a path from Anwar to Dave? " + graph.IsPathExists("Anwar", "Dave"));
            Console.WriteLine("Is there a path from Dave to Haniy? " + graph.IsPathExists("Dave", "Haniy"));
            Console.WriteLine("Is there a path from Haniy to Dave? " + graph.IsPathExists("Haniy", "Dave"));
            Console.WriteLine("Is there a path from Dave to Rob? " + graph.IsPathExists("Dave", "Rob"));
            Console.WriteLine("Is there a path from Rob to Dave? " + graph.IsPathExists("Rob", "Dave"));


            Console.ReadKey();

        }
    }
}
