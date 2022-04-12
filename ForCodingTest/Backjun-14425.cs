using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_14425
    {
        static void Main(string[] args)
        {
            // 시도1) 역시나, contains등 쓰면 시간초과 발생하게끔 문제를 만들었다. 역시나 트라이를 써야한다.
            // 아래는 timeout code
            /*
            string[] strInput = Console.ReadLine().Split(' ');

            int N = int.Parse(strInput[0]);
            int M = int.Parse(strInput[1]);

            List<string> stdStringGroupList = new List<string>();
            int countIncludedString = 0;
            
            for (int i=0; i < N; i++)
            {
                string thisword = Console.ReadLine();
                stdStringGroupList.Add(thisword);
            }

            for (int i=0; i < M; i++)
            {
                string thisword = Console.ReadLine();
                if (stdStringGroupList.Contains(thisword))
                    countIncludedString++;
            }

            Console.WriteLine(countIncludedString);
            
            */

            // 2022.4.12 -> 시도2) Trie로 시도하려는중.
            string[] strInput = Console.ReadLine().Split(' ');

            int N = int.Parse(strInput[0]);
            int M = int.Parse(strInput[1]);




        }

        public int charToIndex(char c)
        {
            return c - 'a';
        }

    }
}
