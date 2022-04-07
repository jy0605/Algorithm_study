using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_2748
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            // N은 90이하의 자연수이다. int형으로 받으면 범위초과로 제대로 된 답을 얻을 수 없다.
            List<long> fibo2 = new List<long>();
            fibo2.Add(0);
            fibo2.Add(1);

            for (int i = 2; i < N + 1; i++)
                if (fibo2.Count > 1)
                    fibo2.Add(fibo2[i-1] + fibo2[i-2]);

            Console.WriteLine(fibo2[N]);
                
        }
    }
}
