using System;

namespace ForCodingTest
{
    internal class Backjun_1735
    {
        static void Main()
        {
            // 약수 2,3,5,7
            // 2022.6.1 아직 관련 보는중
            string[] strFirstFraction = Console.ReadLine().Split(' ');
            string[] srtSecondFraction = Console.ReadLine().Split(' ');

            int[] firstFraction = Array.ConvertAll(strFirstFraction, int.Parse);
            int[] secondFraction = Array.ConvertAll(srtSecondFraction, int.Parse);

            int commonDenom = 0;

            if (firstFraction[1] != secondFraction[1])
                commonDenom = firstFraction[1] * secondFraction[1];
            else
                commonDenom = secondFraction[1];


        }
    }
}
