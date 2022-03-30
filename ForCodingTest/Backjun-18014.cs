using System;
using System.Collections.Generic;

namespace ForCodingTest
{
    internal class Backjun_18014
    {
        public void main()
        {

            // 백준 - 18014 나이순 정렬
            var varN = Console.ReadLine();
            int intN = varN == null ? 0 : int.Parse(varN);
            // Dictionary<int, string> mapUsers = new Dictionary<int, string>(); 문제풀이에서는 여기에서 키중복이 있을 수 있으니까, Tuple로 접근한다.
            List<Tuple<int, string>> tList = new List<Tuple<int, string>>();

            for (int i = 0; i < intN; i++)
            {
                var vartmp = Console.ReadLine();
                string strTmp = vartmp == null ? "" : vartmp;
                string[] arrstrTmp = strTmp.Split(' ');

                var thisUser = Tuple.Create<int, string>(int.Parse(arrstrTmp[0]), arrstrTmp[1]);
                tList.Add(thisUser);
            }

            //tList.Sort();
            tList = tList.OrderBy(t => t.Item1).ToList(); // 단순 sort가 아닌, orderBy or orderByDescending method를 사용하면 동일 value를 가질때의 순서를 정의할 수 있음(asc, desc)

            foreach (var t in tList)
            {
                Console.WriteLine("{0} {1}", t.Item1, t.Item2);
            }


        }

    }
}
