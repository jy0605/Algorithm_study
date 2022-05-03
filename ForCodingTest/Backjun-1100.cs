using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1100
    {
        public static void Main()
        {
            int countofmal = 0;

            // 0부터 시작. 짝수일때 0번째부터 흰색. 홀수일때 1번째부터 흰색
            for (int i = 0; i < 8; i++)
            {
                string thisLine = Console.ReadLine();

                for(int j = 0; j < thisLine.Length; j++)
                {
                    if (thisLine[j] == 'F')
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                            countofmal++;
                        else if (i % 2 == 1 && j % 2 == 1)
                            countofmal++;
                    }
                }
            }

            Console.WriteLine(countofmal);
        }
    }
}
