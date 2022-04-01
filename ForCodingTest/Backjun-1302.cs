using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_1302
    {
        static void _Main()
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> dicSoldBookandCount = new Dictionary<string, int>();

            for (int i = 0; i < N; i++) { 
                string thisSoldBook = Console.ReadLine();
                
                if (!dicSoldBookandCount.ContainsKey(thisSoldBook))
                    dicSoldBookandCount.Add(thisSoldBook, 1);
                else
                    dicSoldBookandCount[thisSoldBook] += 1;
            }

            List<string> maxBooks = new List<string>();

            foreach (string thisSoldBook in dicSoldBookandCount.Keys)
            {
                if (dicSoldBookandCount[thisSoldBook] == dicSoldBookandCount.Values.Max())
                    maxBooks.Add(thisSoldBook);
            }
            maxBooks.Sort();
            Console.WriteLine(maxBooks[0]);
            
        }
    }
}
