using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    enum poliomino
    {
        AAAA,
        BB
    }

    internal class Backjun_1343
    {
        static void Main_()
        {
            string[] inputLines = Console.ReadLine().Split('.');
            string result = string.Empty;

            for (int i = 0; i < inputLines.Length; i++)
            {
                string thisInputLine = string.Empty;
                thisInputLine = replaceXtoPoliomino(inputLines[i], "XXXX", poliomino.AAAA);
                thisInputLine = replaceXtoPoliomino(thisInputLine, "XX", poliomino.BB);

                if (thisInputLine.Contains('X'))
                {
                    result = "-1";
                    break;
                }
                else
                    inputLines[i] = thisInputLine;

            }

            if (result != "-1")
                result = string.Join(".", inputLines);
            
            Console.WriteLine(result);

        }

        public static string replaceXtoPoliomino(string thisString, string Xstring, poliomino thisPoliomino) // enum이 class내에 선언되어있으면 Main에서는 access 가능한데, 타 function에서는 access가 안됨. Namespace내에서 선언하니 access 가능.
        {
            string thisOriginString = string.Empty;

            while (thisString.Contains('X'))
            {
                thisOriginString = thisString;
                thisString = thisString.Replace(Xstring, thisPoliomino.ToString());
                if (thisString == thisOriginString)
                    break;
            }

            return thisString;
        }

    }
}
