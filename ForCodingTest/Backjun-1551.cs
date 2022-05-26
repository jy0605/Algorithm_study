using System;

namespace ForCodingTest
{
    internal class Backjun_1551
    {
        static void Main_()
        {
            string[] strInput = Console.ReadLine().Split(' ');
            int N = int.Parse(strInput[0]);
            int K = int.Parse(strInput[1]);

            int resultArrayLength = N - K;

            string[] strinputArr = Console.ReadLine().Split(',');
            int[] intInputArray = Array.ConvertAll(strinputArr, int.Parse);

            while (intInputArray.Length > resultArrayLength)
            {
                int[] thisInputArray = new int[intInputArray.Length-1];
                for (int i = (intInputArray.Length - 1); i > 0; i--)
                {
                    thisInputArray[i - 1] = intInputArray[i] - intInputArray[i - 1];
                }

                intInputArray = thisInputArray;
            }

            Console.WriteLine(string.Join(",", intInputArray));
            
        }
    }
}
