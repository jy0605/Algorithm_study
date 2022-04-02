using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class 실전코테
    {
        // 페르마의 소정리 but 시간초과..
        const int M = 1000000007;

        static void Main()
        {
            char[] stdChar = { 'W', 'H', 'E' };
            Dictionary<char, List<int>> dicCharIndex = new Dictionary<char, List<int>>();

            dicCharIndex.Add('W', new List<int>());
            dicCharIndex.Add('H', new List<int>());
            dicCharIndex.Add('E', new List<int>());

            int intInputLength = int.Parse(Console.ReadLine());
            string strInput = Console.ReadLine();

            char[] inputChar = new char[intInputLength];
            
            for (int i = 0; i < inputChar.Length; i++)
            {
                inputChar[i] = strInput[i];
                if(dicCharIndex.Keys.Contains(strInput[i]))
                    dicCharIndex[strInput[i]].Add(i);

            }

            long totalCount = 0;

            long[] facto = new long[dicCharIndex['E'].Count + 1];
            facto[0] = 1;
            for (int i = 1; i < dicCharIndex['E'].Count + 1; i++)
                facto[i] = (facto[i - 1] * i) % M;

            dicCharIndex['W'].ForEach(idx => {
                List<int> HindexListbiggerThanidx = dicCharIndex['H'].Where(x => idx < x).ToList();
                HindexListbiggerThanidx.ForEach(Hidx => {
                    List<int> EindexListbiggerThanHidx = dicCharIndex['E'].Where(x => Hidx < x).ToList();
                    for (int i = 0; i < EindexListbiggerThanHidx.Count - 1; i++)
                    {
                        long top = facto[EindexListbiggerThanHidx.Count] % M;
                        long bottom = ((facto[EindexListbiggerThanHidx.Count - (i + 2)] % M) * (facto[i + 2] % M)) % M;

                        long moveToTop = powCalc(bottom, M - 2);
                        totalCount += (top * moveToTop) % M;
                        // totalCount += combination(EindexListbiggerThanHidx.Count, i + 2);

                    }
                });
            });

            Console.WriteLine(totalCount);
            //Console.WriteLine(Math.DivRem(Math.DivRem(totalCount, 1000000007).Remainder);

        }

        public static int combination(int n, int r)
        {
            if (n == r || r == 0)
                return 1;
            else
                return combination(n - 1, r - 1) + combination(n - 1, r);
        }

        public static long powCalc(long num, int p)
        {
            if (p == 0) return 1;

            long half = powCalc(num, p / 2);

            if (p % 2 == 0)
                return ((half % M) * (half % M)) % M;
            else
                return (((half * num) % M) * (half % M)) % M;
        }
    }
}
