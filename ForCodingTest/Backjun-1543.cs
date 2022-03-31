using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1543
    {
        static void Main()
        {

            // 문서 길이는 최대 2,500, 단어길이는 최대 50
            // 단순히 모든 경우의 수를 계산하여 풀 수 있음
            // 시간복잡도는 O(NM)


            string document = Console.ReadLine();
            string splitword = Console.ReadLine();

            int idx = 0;
            int result = 0;

            while (document.Length - idx > splitword.Length)
            {
                if (string.Join("", document.Skip(idx).Take(splitword.Length)) == splitword) // skip은 배열 ~에서 시작하도록. take는 배열에서 몇개요소 취할건지.
                {
                    result++;
                    idx += splitword.Length;
                }
                else
                    idx++;
            }

            Console.WriteLine(result);
        }
    }
}
