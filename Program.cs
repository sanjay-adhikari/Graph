using System;
using System.Collections.Generic;


namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new int[,]{
                   {0, 1, 1, 1, 0, 0, 0},
                   {1, 0, 1, 0, 0, 0, 0},
                   {1, 1, 0, 1, 1, 0, 0},
                   {1, 0, 1, 0, 1, 0, 0},
                   {0, 0, 1, 1, 0, 1, 1},
                   {0, 0, 0, 0, 1, 0, 0},
                   {0, 0, 0, 0, 1, 0, 0}
            };

            Graph grp = new Graph();
            //1. Representation in the form of Adjanceny Matrix
            grp.BFSUsingAdjacencyMatrix_Queue(0, A, 7);
            grp.DFSUsingAdjacencyMatrix_Stack(0, A, 7);

            //2. Representation in the form of Adjancy List i.e. Array of LinkedList
            LinkedList<int>[] adjancyList = new LinkedList<int>[7];
            adjancyList[0] = new LinkedList<int>();
            adjancyList[0].AddFirst(1);
            adjancyList[0].AddLast(2);
            adjancyList[0].AddLast(3);

            adjancyList[1] = new LinkedList<int>();
            adjancyList[1].AddFirst(0);
            adjancyList[1].AddLast(2);
            

            adjancyList[2] = new LinkedList<int>();
            adjancyList[2].AddFirst(0);
            adjancyList[2].AddLast(1);
            adjancyList[2].AddLast(3);
            adjancyList[2].AddLast(4);

            adjancyList[3] = new LinkedList<int>();
            adjancyList[3].AddFirst(0);
            adjancyList[3].AddLast(2);
            adjancyList[3].AddLast(4);

            adjancyList[4] = new LinkedList<int>();
            adjancyList[4].AddFirst(5);
            adjancyList[4].AddLast(6);

            adjancyList[5] = new LinkedList<int>();
            adjancyList[6] = new LinkedList<int>();

            grp.BFSUsingAdjacencyList_Queue(0, adjancyList, 7);


            Console.ReadKey();
        }
    }
}
