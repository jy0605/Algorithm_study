using System;

namespace ForCodingTest
{
    internal class Backjun_1735
    {
        static void Main()
        {
            // 약수 2,3,5,7
            // 2022.6.1 아직 관련 보는중
            // 유클리드호제법
            string[] strFirstFraction = Console.ReadLine().Split(' ');
            string[] srtSecondFraction = Console.ReadLine().Split(' ');

            int[] firstFraction = Array.ConvertAll(strFirstFraction, int.Parse);
            int[] secondFraction = Array.ConvertAll(srtSecondFraction, int.Parse);

            int commonDenom = 0;

            if (firstFraction[1] != secondFraction[1])
                commonDenom = firstFraction[1] * secondFraction[1];
            else
                commonDenom = secondFraction[1];

            int[] resultFraction = new int[2];

            if (commonDenom == secondFraction[1])
            {
                resultFraction[0] = firstFraction[0] + secondFraction[0];
                resultFraction[1] = commonDenom;
            }
            else { 
                resultFraction[0] = firstFraction[0]*secondFraction[1] + secondFraction[0]*firstFraction[1];
                resultFraction[1] = commonDenom;
            }

            int gdc = resultFraction[0];
            int remainder = Math.DivRem(resultFraction[1], resultFraction[0]).Remainder;
            while (remainder != 0)
            {
                int thisremainder = Math.DivRem(gdc, remainder).Remainder;
                gdc = remainder;
                remainder = thisremainder;
            }

            Console.WriteLine(resultFraction[0]/gdc + " " + resultFraction[1]/gdc);
                
        }
    }
}
