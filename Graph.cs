using System;
using System.Collections.Generic;
using System.Linq;


namespace Graph
{
    public class Graph
    {
        public void BFSUsingAdjacencyMatrix_Queue(int vertex, int[,] adjacentMatrix, int sizeOfMatrix)
        {
            Console.WriteLine("BFS starting from node {0}\n", vertex);
            Queue<int> queue = new Queue<int>();
            
            var visited = new HashSet<int>();

            // Initial -  Mark given vertex as Visited Vertex and display that vertex and Enqueue in the STACK
            Console.Write("{0}\t", vertex); 
            visited.Add(vertex); 
            queue.Enqueue(vertex);

            // Explore
            while (queue.Any())
            {
                int exploringVertex = queue.Peek();  // Vertex for exploring
                queue.Dequeue();

                for (int adjacentVertex = 0; adjacentVertex < sizeOfMatrix; adjacentVertex++) // Adjacent vertices of vertex u
                {  
                    if (adjacentMatrix[exploringVertex,adjacentVertex] == 1 && !visited.Contains(adjacentVertex)) // Adjacent vertex and not visited
                    {
                       // Mark the adjacent vertex as Visited Vertex and display that vertex and Enqueue in the STACK

                        Console.Write("{0}\t",adjacentVertex);  
                        visited.Add(adjacentVertex); // Mark as Visited vertex and display
                        queue.Enqueue(adjacentVertex); //Add that vertex on a queue 
                    }
                }
            }

        }

        public void BFSUsingAdjacencyList_Queue(int vertex, LinkedList<int>[] adjacencyList, int size)
        {
            Console.WriteLine("\n\nArray of LinkedList: \nBFS starting from node {0}\n", vertex);

            Queue<int> queue = new Queue<int>();
            var visited = new HashSet<int>();

            // Initial -  Mark given vertex as Visited Vertex and display that vertex and Enqueue in the STACK
            Console.Write("{0}\t", vertex);
            visited.Add(vertex);
            queue.Enqueue(vertex);


            foreach (var adList in adjacencyList)
            {
                foreach (var aL in adList)
                {
                    if (!visited.Contains(aL)) {
                        // Mark the adjacent vertex as Visited Vertex and display that vertex and Enqueue in the STACK

                        Console.Write("{0}\t", aL);
                        visited.Add(aL); // Mark as Visited vertex and display
                        queue.Enqueue(aL); //Add that vertex on a queue 
                    }
                        
                }
                }

        }

        public void DFSUsingAdjacencyMatrix_Stack(int vertex, int[,] adjacenyMatrix, int size)
        {
            Console.WriteLine("\nDFS starting from node {0}\n", vertex);

            // Initialize visit tracking array and stack
            int[] visited = new int[8] { 0,0,0,0,0,0,0,0};
            Stack<int> stk = new Stack<int>();
            stk.Push(vertex);

            // Visit start vertex u
            Console.Write("{0}\t", vertex); 
            visited[vertex] = 1;  // Visited vertex u

            // Initial Adjacent vertex
            int adjacentVertex = 0;

            while (stk.Any())
            {
                while (adjacentVertex < size)
                {
                    if (adjacenyMatrix[vertex,adjacentVertex] == 1 && visited[adjacentVertex] == 0)
                    {
                        stk.Push(adjacentVertex); // Suspend exploring current vertex 
                        vertex = adjacentVertex;  // Update current vertex as the next adjacent vertex

                        // Visit current vertex u
                        Console.Write("{0}\t", vertex);
                        visited[vertex] = 1;
                        adjacentVertex = -1;  // Increment will make this 0
                    }
                    adjacentVertex++;
                }
                adjacentVertex = vertex;  // Can set v = 0 but setting v = u is better
                vertex = stk.Peek();  // Return to previous suspended vertex
                stk.Pop();
            }
        }
    }
}
