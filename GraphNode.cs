using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_3

{
    internal class GraphNode
    {

        private string name; // data stored in the node. 

        private LinkedList<string> adjacencyList; // list of the IDs of the nodes that are adjacent

        public GraphNode(string name)
        {
            this.name = name;
            adjacencyList = new LinkedList<string>();
        }


        // set and get the data stored in the node 
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public void AddEdge(GraphNode to)
        {
            adjacencyList.AddLast(to.name);
        }



        // return the adjacent list of the node
       public LinkedList<string> GetAdjacencyList(){
            return adjacencyList;
        }


    }
}

