using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_16953
    {
        static void Main_()
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            int A = int.Parse(inputStr[0]);
            int B = int.Parse(inputStr[1]);

            int res = -1;

            while (true)
            {
                res++;

                if (B < A) { res = -1; break; }
                else if (B % 10 == 1)
                    B = Math.DivRem(B, 10).Quotient;
                else if (B % 2 == 0)
                    B = Math.DivRem(B, 2).Quotient;
                else { res = -1;  break; }
                    
                if (A == B)
                    break;
            }

            Console.WriteLine(res == -1 ? -1 : (res + 2));
        }
    }
}
