using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1645
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arrK = new int[N + 1];

            for (int i = 0; i < N; i++)
            {
                int thisStudent = int.Parse(Console.ReadLine());
                arrK[thisStudent]++;
            }

            int minNumberOfStudent = 0;
            for (int i = 1; i < N + 1; i++)
            {
                if (arrK[i] == (i + 1))
                {
                    minNumberOfStudent = i + 1;
                    break;
                }
            }

            Console.WriteLine(minNumberOfStudent);


        }
    }
}
