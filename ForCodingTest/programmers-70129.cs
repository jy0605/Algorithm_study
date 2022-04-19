using System;

namespace ForCodingTest
{
    internal class programmers_70129
    {
        // 이진변환 반복하기
        static void Main_()
        {
            string thisInput = Console.ReadLine();
            int[] thisOutput = solution(thisInput);
            Console.WriteLine("[{0},{1}]", thisOutput[0], thisOutput[1]);
        }

        public static int[] solution(string s)
        {
            int[] answer = new int[] { 0, 0 };
            string thisS = "";


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                    answer[1]++;
                else
                    thisS += s[i];
            };

            if (thisS == "1")
            {
                answer[0]++;
                return answer;
            }
            else
            {
                answer[0]++;
                string convertingthisS_reversed = "";
                int thisInt = thisS.Length;

                while (true)
                {
                    int thisRemainder = 0;
                    thisInt = Math.DivRem(thisInt, 2, out thisRemainder);
                    convertingthisS_reversed += thisRemainder.ToString();

                    if (thisInt == 0)
                        break;
                }

                var convertingthisS = convertingthisS_reversed.ToCharArray();
                Array.Reverse(convertingthisS);
                thisS = new String(convertingthisS);

                int[] thisAnswer = solution(thisS);
                answer[0] += thisAnswer[0];
                answer[1] += thisAnswer[1];
            }

            return answer;
        }

        public int[] solution_of_The_Other(string s)
        {
            int[] answer = new int[] { 0, 0 };

            while (!s.Equals("1"))
            {
                answer[0]++;
                var OneCharCount = s.Where(x => x.Equals('1')).Count();
                answer[1] += s.Length - OneCharCount;

                s = Convert.ToString(OneCharCount, 2);
            }

            return answer;
        }

    }
}
