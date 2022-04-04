using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1668
    {
        static void Main_()
        {
            int N = int.Parse(Console.ReadLine());
            List<int> listTropy = new List<int>();

            for (int i = 0; i < N; i++)
                listTropy.Add(int.Parse(Console.ReadLine()));

            int maxofleftside = 0;
            int maxofrightside = 0;

            int leftcnt = 0;
            int rightcnt = 0;

            for (int i = 0; i < listTropy.Count; i++)
                if (maxofleftside < listTropy[i])
                {
                    maxofleftside = listTropy[i];
                    leftcnt++;
                }

            listTropy.Reverse();
            for (int i = 0; i < listTropy.Count; i++)
                if (maxofrightside < listTropy[i])
                {
                    maxofrightside = listTropy[i];
                    rightcnt++;
                }

            Console.WriteLine(leftcnt);
            Console.WriteLine(rightcnt);


        }
    }
}
