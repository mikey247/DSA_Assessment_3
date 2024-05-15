using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_3
{
    internal class Graph
    {

        private LinkedList<GraphNode> nodes;

        public Graph(){
            nodes = new LinkedList<GraphNode>();
        }

        public int GetNumberOfNodes(){
            return nodes.Count;
        }

        public void AddNode(string name){
            nodes.AddLast(new GraphNode(name));
        }

        public GraphNode GetNodeByName(string name){
            foreach (GraphNode n in nodes)
            {
                if (name == n.Name)
                    return n;
            }
            return null;
        }

        public void AddEdge(string from, string to){
            GraphNode n1 = GetNodeByName(from);

            GraphNode n2 = GetNodeByName(to);

            n1.AddEdge(n2);
        }

        public int GetNumberOfEdges(){
            int count = 0;
            foreach (GraphNode node in nodes) {
                count += node.GetAdjacencyList().Count;
            }
            return count;
        }

        public List<string> BreadthFirstSearch(string startName){
            List<string> visited = new List<string>();
            Queue<GraphNode> queue = new Queue<GraphNode>();
            GraphNode startNode = GetNodeByName(startName);

            if (startNode == null)
                return visited;

            queue.Enqueue(startNode);

            while (queue.Count > 0){
                GraphNode currentNode = queue.Dequeue();
                if (!visited.Contains(currentNode.Name)){
                    visited.Add(currentNode.Name);
                    foreach (string neighborName in currentNode.GetAdjacencyList()){
                        GraphNode neighborNode = GetNodeByName(neighborName);
                        if (neighborNode != null && !visited.Contains(neighborNode.Name)){
                            queue.Enqueue(neighborNode);
                        }
                    }
                }
            }

            return visited;
        }

        public bool IsPathExists(string startName, string endName){
            List<string> visited = BreadthFirstSearch(startName);
            return visited.Contains(endName);
        }


    }
}

