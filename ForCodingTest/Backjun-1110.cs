using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_for_pratice
{
    class Backjun_1110
    {
        static void Main()
        {
            // 더하기 사이클

            int originNum = int.Parse(Console.ReadLine());
            int newNum = -1;
            int res = 0;
            
            while (true)
            {
                if(originNum == newNum)
                    break;
                else
                {
                    if (newNum == -1)
                        newNum = originNum;
                    int firstNum = newNum / 10;
                    int secNum = newNum % 10;

                    int preNewNum = firstNum + secNum;

                    newNum = int.Parse(secNum + "" + preNewNum % 10);

                    res++;
                }

            }

            Console.Write(res);
            Console.ReadKey();
        }
    }
}
