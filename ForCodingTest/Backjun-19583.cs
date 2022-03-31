using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_19583
    {
        static void Main_()
        {
            // 입장, 퇴장 list를 만든다
            // 입장과 퇴장 list의 공통 개수만 출력한다.

            string inputTime = Console.ReadLine();
            string[] arrinputTime = inputTime.Split(' ');

            int[] timeS = Array.ConvertAll(arrinputTime[0].Split(':'), int.Parse);
            int[] timeE = Array.ConvertAll(arrinputTime[1].Split(':'), int.Parse);
            int[] timeQ = Array.ConvertAll(arrinputTime[2].Split(':'), int.Parse);

            List<string> listEnteredmembers = new List<string>();
            List<string> listOutMemebers = new List<string>();
            string thismember = Console.ReadLine();

            while(thismember != null)
            {
                string[] arrThisMemberInfo = thismember.Split(' ');
                string thisMemberName = arrThisMemberInfo[1];
                int[] chatTimeofThisMember = Array.ConvertAll(arrThisMemberInfo[0].Split(':'), int.Parse);

                if (chatTimeofThisMember[0] <= timeS[0])
                {

                }
            }
            
        }
    }
}
