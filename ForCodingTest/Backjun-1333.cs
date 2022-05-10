using System;

namespace ForCodingTest
{
    internal class Backjun_1333
    {
        static void Main_()
        {
            // 노래 N곡, 노래 길이 L초, 노래사이 5초 fade
            // 첫곡의 순간이 0초, 0초부터 전화벨 ring, 전화벨은 D 초에 1번씩 1초동안 ring.
            // 전화벨이 노래가 시작되는 순간 같이 시작되거나 노래가 끝날때 벨이 같이 끝난다면 들을 수 없음
            // 모든 노래를 다 들으면 전화벨 들을 수 있음
            // 전화벨 들을 수 있는 가장 빠른 시간?

            string[] NLD = Console.ReadLine().Split(' ');

            int N = int.Parse(NLD[0]);
            int L = int.Parse(NLD[1]);
            int D = int.Parse(NLD[2]);

            int[] fadeRange = { L, L + 5 };

            int secOfLastRing = D;

            for (int i = 0; i < N; i++)
            {
                while (fadeRange[0] > secOfLastRing)
                    secOfLastRing += D;

                if (secOfLastRing < fadeRange[0] || secOfLastRing >= fadeRange[1])
                {
                    fadeRange[0] = fadeRange[1] + L;
                    fadeRange[1] = fadeRange[0] + 5;
                }
                else
                    break;
            }

            Console.WriteLine(secOfLastRing);
        }
    }
}
