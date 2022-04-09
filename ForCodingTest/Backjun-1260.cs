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
            // 문제 -- 2022. 4. 9 여기 푸는중! 내일 두문제 올리기!
            // https://www.acmicpc.net/problem/1260
            string[] inputStr = Console.ReadLine().Split(' ');
            int nodecnt = int.Parse(inputStr[0]);
            int linkcnt = int.Parse(inputStr[1]);
            int startNode = int.Parse(inputStr[2]);

            Dictionary<int, List<int>> nodes = new Dictionary<int, List<int>>();

            List<int> visitedNode = new List<int>();

            for (int i = 0; i < linkcnt; i++)
            {
                string[] thisinput = Console.ReadLine().Split(' ');
                int thisnode = int.Parse(thisinput[0]);
                int nextnode = int.Parse(thisinput[1]);

                if (! nodes.ContainsKey(thisnode))
                    nodes.Add(thisnode, new List<int>());   
                nodes[thisnode].Add(nextnode);
            }

            


        }
    }
}
