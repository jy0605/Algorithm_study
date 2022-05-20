using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1546
    {
        static void Main_()
        {
            int N = int.Parse(Console.ReadLine());
            string[] scores = Console.ReadLine().Split(' ');

            double maxscore = 0;
            double[] arrScores = new double[N];
            for (int i = 0; i < N; i++)
            {
                arrScores[i] = double.Parse(scores[i]);
                maxscore = Math.Max(maxscore, arrScores[i]);
            }


            double sumoffixedscores = 0;
            for(int i = 0; i < N; i++)
            {
                double fixedRateofScore = arrScores[i] / maxscore;
                sumoffixedscores += (fixedRateofScore * 100);
            }
            double fixedMeanVal = sumoffixedscores / N;
            Console.WriteLine(fixedMeanVal);
        }
    }
}
