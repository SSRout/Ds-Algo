using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Graph
{
    public class GraphBFSDemo
    {
        public Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>();
        public Queue<char> queue = new Queue<char>();
        public GraphBFSDemo()
        {
            graph.Add('a', new List<char> { 'b', 'c' });
            graph.Add('b', new List<char> { 'd' });
            graph.Add('c', new List<char> { 'e' });
            graph.Add('d', new List<char> { 'f' });
            graph.Add('e', new List<char>());
            graph.Add('f', new List<char>());
            Console.WriteLine("Iterative");
            BFSIter(graph, 'a');
            Console.WriteLine("Recursive");
            BFSRecursive(graph, 'a');
        }
        /// <summary>
        /// Iterative
        /// </summary>
        /// <param name="Graph"></param>
        /// <param name="source"></param>
        public void BFSIter(Dictionary<char, List<char>> Graph,char source)
        {
            queue.Enqueue(source);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current);
                foreach(var neighbor in graph[current])
                {
                    queue.Enqueue(neighbor);
                }
            }

        }
        /// <summary>
        /// </summary>
        /// <param name="Graph"></param>
        /// <param name="source"></param>
        public void BFSRecursive(Dictionary<char, List<char>> Graph, char source)
        {
            Console.WriteLine(source);
            foreach (var neighbor in graph[source])
            {
                BFSRecursive(Graph, neighbor);
            }
        }
    }
}
