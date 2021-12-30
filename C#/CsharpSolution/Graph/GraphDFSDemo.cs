using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSolution.Graph
{
    public class GraphDFSDemo
    {
        public Dictionary<char, List<char>> adjaciencyList = new Dictionary<char, List<char>>();
        public Stack<char> stack = new Stack<char>();
        public GraphDFSDemo()
        {
            adjaciencyList.Add('a', new List<char> { 'b', 'c' });
            adjaciencyList.Add('b', new List<char> { 'd' });
            adjaciencyList.Add('c', new List<char> { 'e' });
            adjaciencyList.Add('d', new List<char> { 'f' });
            adjaciencyList.Add('e', new List<char>());
            adjaciencyList.Add('f', new List<char>());

            DFSIter(adjaciencyList, 'a');
            Console.WriteLine("Recursive");
            DFSRecursive(adjaciencyList, 'a');
        }

        /// <summary>
        /// Iterative Approach
        /// </summary>
        /// <param name="adjaciencyList"></param>
        /// <param name="vertex"></param>
        public void DFSIter(Dictionary<char, List<char>> adjaciencyList,char vertex)
        {
            Console.WriteLine("Iterative");
            stack.Push(vertex);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                Console.WriteLine(current);
                foreach(var neighbor in adjaciencyList[current])
                {
                    stack.Push(neighbor);
                }
            }
        }
        /// <summary>
        /// Recursive Approach
        /// </summary>
        /// <param name="adjaciencyList"></param>
        /// <param name="source"></param>
        public void DFSRecursive(Dictionary<char, List<char>> adjaciencyList, char source)
        {
            Console.WriteLine(source);
            foreach(var neighbor in adjaciencyList[source])
            {
                DFSRecursive(adjaciencyList, neighbor);
            }
        }
    }
}
