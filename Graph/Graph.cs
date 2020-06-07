using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph_Implementation
{
    class Graph<T>
    {
        // Member variables
        private int numberOfNodes;
        private Hashtable adjacentList;

        // Constructor
        public Graph() // Default
        {
            this.numberOfNodes = 0;
            this.adjacentList = new Hashtable();
        }

        // Properties
        int Length { get { return this.numberOfNodes; } }

        // METHODS
        // Add a new Node/Vertex
        public void AddVertex(T node)
        {
            this.adjacentList.Add(node, new List<T>());
            this.numberOfNodes++;
        }

        // Add a connection (Vertice/Edge) between two Nodes/Vertexes
        public void AddEdge(T node1, T node2)
        {
            ((List<T>)this.adjacentList[node1]).Add(node2);
            ((List<T>)this.adjacentList[node2]).Add(node1);
        }

        // Print the whole Graph
        public void ShowConnections()
        {
            // Get the nodes of our graph (sorted)
            var allNodes = this.adjacentList.Keys.Cast<T>().OrderBy(c => c);

            // For every node of our Graph
            foreach (T node in allNodes) {
                // Get the connections
                string connections = string.Empty;

                // Add them in a string
                foreach (T vertex in ((List<T>)this.adjacentList[node]))
                    connections += vertex + " ";

                Console.WriteLine(node + "-->" + connections); // Print the connections
            }
        }
    }
}
