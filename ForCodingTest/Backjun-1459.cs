using System;

namespace ForCodingTest
{
    internal class Backjun_1459
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split(' ');

            long X = long.Parse(inputs[0]);
            long Y = long.Parse(inputs[1]);
            int costofline = int.Parse(inputs[2]);
            int costofslash = int.Parse(inputs[3]);

            long result = 0;
            long result2 = 0;

            if (costofslash > ( costofline * 2 ))
                result = (X + Y) * costofline;
            else
            {
                // 대각선으로 최대한 이동
                result = (X > Y ? Y : X) * costofslash;
                
                // 홀수의 경우 1을 빼준만큼 더 대각선으로 이동 후 수평이동
                if (Math.Abs(X - Y) % 2 != 0)
                {
                    result += (Math.Abs(X - Y) - 1) * costofslash;
                    result += costofline;
                }
                // 짝수의 경우 남은 칸만큼 더 대각선이동
                else
                    result += Math.Abs(X - Y) * costofslash;

                // 그런데 상기만으로는 최소값이 아닐 경우도 있다.
                // 예제입력 6번의 경우, 아래의 식이 최소시간이 된다.
                // 이 경우가 대각선으로 최대한 이동 후 수평이동의 경우이다.
                // 예제입력 6번 : 10000000 50000000 800 901 => 41010000000
                result2 = (Math.Min(X, Y) * costofslash) + (Math.Abs(X - Y) * costofline);

            }

            Console.WriteLine(Math.Min(result, result2));
        }
    }
}


//result = (X > Y ? Y : X) * costofslash;
//(long thisq, long thisr) = Math.DivRem(Math.Abs(X - Y), 2);

//while (thisq > 0)
//{
//    result += thisq * costofslash;
//    thisq = Math.DivRem(thisr, 2).Quotient;
//    thisr = Math.DivRem(thisq, 2).Remainder;
//}

//if (thisr != 0)
//    result += costofline;