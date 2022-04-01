using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1568
    {
        // 시간복잡도 O(N^2) 등차수열. 그만큼의 값을 빼주는 방식이므로 사실상 대략적으로 O(루트n)의 시간복잡도를 가지게 됨
        static void Main_()
        {
            int N = int.Parse(Console.ReadLine());
            int numBird = 0;
            int totalsec = 0;

            while (N > 0) { 
                numBird++;
                totalsec++;

                if (N < numBird)
                    numBird = 1;

                N = N - numBird;
            }

            Console.WriteLine(totalsec);
        }
    }
}
