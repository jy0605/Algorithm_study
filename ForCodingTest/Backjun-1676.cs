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
            // 5의 배수의 개수는 10의 개수와 동일
            // 25는 5가 두개이므로 10이 두 개인것과 동일
            // 125는 5가 세개이므로 10이 세 개인것과 동일
            Console.WriteLine(Math.DivRem(N,5).Quotient + Math.DivRem(N,25).Quotient + Math.DivRem(N, 125).Quotient);

        }
    }
}
