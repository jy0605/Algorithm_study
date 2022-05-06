using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1105
    {
        public static void Main_()
        {
            string[] inputLine = Console.ReadLine().Split(' ');

            string L = inputLine[0];
            string R = inputLine[1];

            // padLeft 과정을 해주지 않으면 채점 40%쯤에서 틀린다.
            L = L.PadLeft(R.Length, '0');

            int cntof8 = 0;

            for (int i = 0; i < L.Length; i++) 
            {
                if (L[i] == R[i])
                {
                    if (L[i] == '8')
                        cntof8++;
                }
                else
                    break;
            }

            Console.WriteLine(cntof8);

        }

    }
}
