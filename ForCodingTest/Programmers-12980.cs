using System;

namespace ForCodingTest
{
    internal class Programmers_12980
    {

        static public void Main_()
        {
            int thisN = int.Parse(Console.ReadLine());
            Console.WriteLine(solution(thisN));
        }
        static public int solution(int n)
        {
            int batterySpent = 0;
            int lastQuotient = n;

            while (lastQuotient != 1)
            {
                //(int thisquotient, int thisremainder) = Math.DivRem(lastQuotient, 2);

                int thisquotient = lastQuotient / 2;
                int thisremainder = lastQuotient % 2;

                lastQuotient = thisquotient;
                batterySpent += thisremainder;
            }

            batterySpent++;

            return batterySpent;
        }
    }
}
