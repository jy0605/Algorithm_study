using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_10989
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arrInt = new int[10001];

            for (int i = 0; i < N; i++)
            {
                int intThisInput = int.Parse(Console.ReadLine());
                arrInt[intThisInput] += 1;
            }

            for (int i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] == 0)
                    continue;
                for (int j = 0; j < arrInt[i]; j++)
                    Console.WriteLine(i);
                Console.WriteLine(String.Join("\n", Enumerable.Repeat(i, arrInt[i]).ToArray()));
            }
        }
    }
}
