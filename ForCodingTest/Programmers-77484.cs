using System;

namespace ForCodingTest
{
    internal class Programmers_77484
    {
        public static void Main()
        {
            int[] lottos = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            int[] win_nums = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

            int[] res = solution(lottos, win_nums);

            Console.WriteLine("[{0},{1}]",res[0], res[1]);

        }
        public static int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[] { 0, 0 };

            List<int> winNumsList = new List<int>();
            winNumsList = win_nums.ToList();
            int[] lottosWithNoZero = lottos.Where(num => num != 0).ToArray();

            for (int i = 0; i < lottosWithNoZero.Length; i++)
            {
                if (winNumsList.Contains(lottosWithNoZero[i]))
                    winNumsList.Remove(lottosWithNoZero[i]);
            }

            int maxCount = win_nums.Length - winNumsList.Count + (lottos.Length - lottosWithNoZero.Length);
            int minCount = win_nums.Length - winNumsList.Count;

            answer[0] = ( 7 - maxCount ) > 6 ? 6 : (7 - maxCount);
            answer[1] = (7 - minCount) > 6 ? 6 : (7 - minCount);

            return answer;
        }
    }
}
