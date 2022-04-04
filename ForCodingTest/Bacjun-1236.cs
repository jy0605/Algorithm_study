using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Bacjun_1236 // 22.4.4 여기푸는중
    {
        static void Main()
        {
            string[] strInputNM = Console.ReadLine().Split(' ');

            int N = 0;
            int M = 0;

            N = strInputNM[0] == null ? 0 : int.Parse(strInputNM[0]);
            M = strInputNM[1] == null ? 0 : int.Parse(strInputNM[1]);

            int[] arrindexOfSecurity = new int[M];

            for (int i = 0; i < N; i++)
            {
                string strInputSecurity = Console.ReadLine();
                strInputSecurity.ToList().FindAll(chr => chr.Equals('X')).ForEach(thisChr => arrindexOfSecurity[strInputSecurity.IndexOf(thisChr)] = 1);
            }

            int cntofminimumsecurity = arrindexOfSecurity.Where(index => index != 1).Count();

            Console.WriteLine(cntofminimumsecurity);

        }

    }
}
