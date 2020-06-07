namespace Graph_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> myGraph = new Graph<string>();

            // Add the Vertexes of our Graph
            myGraph.AddVertex("0");
            myGraph.AddVertex("1");
            myGraph.AddVertex("2");
            myGraph.AddVertex("3");
            myGraph.AddVertex("4");
            myGraph.AddVertex("5");
            myGraph.AddVertex("6");

            // Add the edges of our Graph / Connect our Nodes
            myGraph.AddEdge("3", "1");
            myGraph.AddEdge("3", "4");
            myGraph.AddEdge("4", "2");
            myGraph.AddEdge("4", "5");
            myGraph.AddEdge("1", "2");
            myGraph.AddEdge("1", "0");
            myGraph.AddEdge("0", "2");
            myGraph.AddEdge("6", "5");

            myGraph.ShowConnections();

            /* Output:
             * 0-->1 2
             * 1-->3 2 0
             * 2-->4 1 0
             * 3-->1 4
             * 4-->3 2 5
             * 5-->4 6
             * 6-->5
             */

            /*
             * OUR GRAPH:
             * 3-------4--------5
             * |       |        |
             * |       |        |
             * 1-------2        6
             *  \     /
             *   \   /
             *    \ /
             *     0
             */
        }
    }
}
