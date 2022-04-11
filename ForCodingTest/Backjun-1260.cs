using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1260
    {
        static void Main()
        {
            // https://www.acmicpc.net/problem/1260
            string[] inputStr = Console.ReadLine().Split(' ');
            int nodecnt = int.Parse(inputStr[0]);
            int linkcnt = int.Parse(inputStr[1]);
            int startNode = int.Parse(inputStr[2]);

            Dictionary<int, List<int>> nodes = new Dictionary<int, List<int>>();

            for (int i = 0; i < linkcnt; i++)
            {
                string[] thisinput = Console.ReadLine().Split(' ');
                int thisnode = int.Parse(thisinput[0]);
                int nextnode = int.Parse(thisinput[1]);

                if (thisnode > nodecnt || nextnode > nodecnt)
                    continue;

                if (! nodes.ContainsKey(thisnode))
                    nodes.Add(thisnode, new List<int>());
                if (! nodes.ContainsKey(nextnode))
                    nodes.Add(nextnode, new List<int>());

                nodes[thisnode].Add(nextnode);
                nodes[nextnode].Add(thisnode);
            }

            Dictionary<int, List<int>> secNodes = new Dictionary<int, List<int>>();
            secNodes = copyDictionary(nodes);

            // BFS는 시작노드에서 방문할 수 있는 노드를 먼저 선출력 후 방문 마치면 그 다음 노드로 이동
            List<int> listDFS = DFS(nodes, startNode);
            List<int> listBFS = BFS(secNodes, startNode);

            Console.WriteLine(String.Join(" ", listDFS));
            Console.WriteLine(String.Join(" ", listBFS));
        }

        public static List<int> BFS(Dictionary<int, List<int>> originNodes, int startNode)
        {
            List<int> visitedNode = new List<int>();
            var nodes = originNodes.ToDictionary(x => x.Key, x => x.Value);

            visitedNode.Add(startNode);
            int stdNode = startNode;

            while (visitedNode.Count < nodes.Keys.Count)
            {
                List<int> thisVisitedNode = new List<int>();

                nodes[stdNode].Sort();
                int nextStdNode = nodes[stdNode][0];
                visitedNode.AddRange(nodes[stdNode]);
                nodes[stdNode].ForEach(node => { 
                    nodes[node].Remove(stdNode);
                });
                nodes.Remove(stdNode);

                stdNode = nextStdNode;
            }
            
            return visitedNode;

        }
        public static List<int> DFS(Dictionary<int, List<int>> originNodes, int startNode)
        {
            List<int> visitedNode = new List<int>();
            var nodes = originNodes.ToDictionary(x => x.Key, x => x.Value);

            visitedNode.Add(startNode);
            int stdNode = startNode;

            while (visitedNode.Count < nodes.Keys.Count)
            {
                nodes[stdNode].Sort();
                var node = nodes[stdNode][0];
                if (!visitedNode.Contains(node)) { visitedNode.Add(node); stdNode = node; }
                nodes[node].Remove(stdNode); 
                nodes[stdNode].Remove(node);
            }

            return visitedNode;
        }

        public static Dictionary<int, List<int>> copyDictionary(Dictionary<int, List<int>> dict)
        {
            Dictionary<int, List<int>> newDict = new Dictionary<int, List<int>>();
            List<KeyValuePair<int, List<int>>> pairs = dict.ToList();
            pairs.ForEach(pair => newDict.Add(pair.Key, pair.Value));
            //foreach (var key in dict.Keys) -> 이 방법은 return dictionary가 그대로 dict를 참조하므로 fail임
            //    newDict.Add(key, dict[key]);
            return newDict;
        }
    }
}
