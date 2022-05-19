using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1503
    {
        static void Main()
        {
            // N의 범위가 1000 이하이므로 완전탐색으로 풀이를 진행한다.
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            string[] inputs_sec = Console.ReadLine().Split(' ');

            int[] arrS = new int[1002];

            for (int i = 0; i < M; i++)
            {
                int thisnum = int.Parse(inputs_sec[i]);
                arrS[thisnum] = 1;
            }

            int result = int.MaxValue;
            for (int i = 1; i < 1002; i++)
            {
                if (arrS[i] == 1)
                    continue;
                for (int j = i; j < 1002; j++)
                {
                    if (arrS[j] == 1)
                        continue;
                    for(int k = j; k < 1002; k++)
                    {
                        if (arrS[k] == 1)
                            continue;
                        result = Math.Min(result, Math.Abs(N - i * j * k));
                    }
                }
                if (result == 0)
                    break;
            }

            Console.WriteLine(result);


        }
    }
}
