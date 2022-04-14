using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_9205
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++) {
                
                int n = int.Parse(Console.ReadLine());
                List<Tuple<short, short>> coords = new List<Tuple<short, short>>();

                string[] arrFirstInputStr = Console.ReadLine().Split(' ');

                coords.Add(Tuple.Create(short.Parse(arrFirstInputStr[0]), short.Parse(arrFirstInputStr[1])));

                bool isSuccessToGetFestival = true;

                for (var j = 0; j < n + 1; j++)
                {
                    string[] arrInputStr = Console.ReadLine().Split(' ');
                    coords.Add(Tuple.Create(short.Parse(arrInputStr[0]), short.Parse(arrInputStr[1])));

                    var item1_dist = Math.Abs(coords[j + 1].Item1 - coords[j].Item1);
                    var item2_dist = Math.Abs(coords[j + 1].Item2 - coords[j].Item2);

                    (int cntofbottles, int leftMeters) = Math.DivRem(item1_dist + item2_dist, 50);

                    if (cntofbottles > 20)
                        isSuccessToGetFestival = false;
                    else if (cntofbottles == 20) 
                        if (leftMeters > 0)
                            isSuccessToGetFestival = false;
                }

                Console.WriteLine( isSuccessToGetFestival == true ? "happy" : "sad" );

            }
        }
    }
}
