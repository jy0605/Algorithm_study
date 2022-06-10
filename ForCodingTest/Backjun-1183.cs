using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1183
    {
        static void Main()
        {
            // 2022.6.10 아직 푸는중..
            int N = int.Parse(Console.ReadLine());
            int[] ai = new int[N];
            int[] bi = new int[N];
            int[] diffTime = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] thisInput = Console.ReadLine().Split(' ');
                ai[i] = int.Parse(thisInput[0]);
                bi[i] = int.Parse(thisInput[1]);
                diffTime[i] = ai[i] - bi[i];
            }


        }
    }
}
