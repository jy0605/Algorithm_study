using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_10989
    {
        static void Main()
        {
            // 22.5.21 메모리초과, 시간초과... 흠
            int N = int.Parse(Console.ReadLine());
            int maxNumber = 0;
            string[] strArrofNumbers = new string[10001];

            for (int i = 0; i < N; i++)
            {
                int intThisInput = int.Parse(Console.ReadLine());
                maxNumber = Math.Max(intThisInput, maxNumber);
                strArrofNumbers[intThisInput] += intThisInput.ToString() + "\n";
            }

            for (int i = 0; i < strArrofNumbers.Length; i++)
            {
                if (i > maxNumber)
                    break;
                if (strArrofNumbers[i] == null)
                    continue;
                if (i == maxNumber)
                    strArrofNumbers[i] = strArrofNumbers[i].Remove(strArrofNumbers[i].Length-1);
                Console.Write(strArrofNumbers[i]);
            }
        }
    }
}
