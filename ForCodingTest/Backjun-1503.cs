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
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            string[] inputs_sec = Console.ReadLine().Split(' ');

            int[] arrS = new int[M];

            for (int i = 0; i < M; i++)
            {
                arrS[i] = int.Parse(inputs_sec[i]);
            }


        }
    }
}
