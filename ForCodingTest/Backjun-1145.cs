using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1145
    {
        static void Main()
        {
            // 브루트포스 알고리즘
            // 순차탐색, DFS, BFS(어떤방법으로든 전체탐색으로 문제를 풀었다면 브루트포스 알고리즘)
            // 참고 => https://asadal.github.io

            string[] input = Console.ReadLine().Split(' ');
            int[] arrInt = Array.ConvertAll(input, int.Parse);

            int cnt = 0;
            int minInt = 1;
            while (cnt < 3)
            {
                cnt = 0;
                foreach ( int n in arrInt)
                {
                    if (minInt % n == 0)
                        cnt++;
                    if (cnt == 3)
                        break;
                }
                minInt++;
            }

            Console.WriteLine(minInt-1);

        }
    }
}
