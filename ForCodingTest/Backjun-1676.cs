using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1676
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            //string[] arrNfac = new string[N];
            //float Nfac = 1;

            //for (int i = 1; i < N + 1; i++)
            //{
            //    Nfac = Nfac * i;
            //    arrNfac[i - 1] = Nfac.ToString();
            //}

            //string strNfac = Nfac.ToString();
            //int zeroCount = 0;

            //for(int i = strNfac.Length - 1; i > -1; i--)
            //{
            //    if (strNfac[i] != '0')
            //        break;
            //    else
            //        zeroCount++;
            //}

            //Console.WriteLine(String.Join(',', arrNfac));
            Console.WriteLine(/*zeroCount*/Math.DivRem(N,5).Quotient);

        }
    }
}
