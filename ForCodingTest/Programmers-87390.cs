using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Programmers_87390
    {
        static void Main_()
        {

        }
        public static List<long> solution(int n, long left, long right)
        {
            List<long> answer = new List<long>();

            long quarantine = 0;
            long remainder = 0;

            var qandr = Math.DivRem(left, n);

            quarantine = qandr.Quotient + 1;
            remainder = qandr.Remainder;

            for (long i = left; i < right + 1; i++)
            {
                if (remainder + 1 == n)
                {
                    quarantine++;
                    answer.Add(remainder + 1);
                }
                else if (remainder < quarantine)
                    answer.Add(quarantine);
                else
                {

                }

            }


            return answer;
        }
    }
}
