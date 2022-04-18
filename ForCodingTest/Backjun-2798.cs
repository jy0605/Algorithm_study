using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_2798
    {
        static void Main_()
        {
            // 브루트포스(Brute force) 알고리즘
            // 해가 존재할 것으로 예상되는 모든 영역을 전체 탐색하는 방법
            // DFS, BFS, 순차탐색

            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

        }

        public static int combinationByDfsWithMemoization(int[][] array, int n, int r)
        {
            if (array[n][r] > 0)
            {
                return array[n][r];
            }
            if (n == r || r == 0)
            {
                return 1;
            }
            else
            {
                return array[n][r] = combinationByDfsWithMemoization(array, n - 1, r - 1) + combinationByDfsWithMemoization(array, n - 1, r);
            }
        }
    }
}
