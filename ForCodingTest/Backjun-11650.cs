using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_11650 // 시간초과 뜸.
    {
        static void Main_()
        {
            var N = Console.ReadLine();
            int intN = N == null ? 0 : int.Parse(N);

            List<Tuple<int, int>> tList = new List<Tuple<int, int>>();
            
            for (int i = 0; i < intN; i++)
            {
                var varInput = Console.ReadLine();
                string strInput = varInput == null ? "" : varInput;
                int[] ArrIntInput = Array.ConvertAll(strInput.Split(' '), int.Parse);

                tList.Add(Tuple.Create(ArrIntInput[0], ArrIntInput[1]));
            }

            tList.Sort();

            foreach (var t in tList)
                Console.WriteLine("{0} {1}", t.Item1, t.Item2);
        }
    }
}
