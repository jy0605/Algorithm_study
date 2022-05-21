using System;
using System.Text.RegularExpressions;

namespace ForCodingTest
{
    internal class Backjun_1541
    {

        static void Main_()
        {
            string exp = Console.ReadLine();
            string[] arrExpbyminus = exp.Split('-');


            for (int i = 0; i < arrExpbyminus.Length; i++)
            {
                int thisNumber = 0;
                var thisexp = arrExpbyminus[i].Split('+');
                if (thisexp.Length > 1)
                    for (int j = 0; j < thisexp.Length; j++)
                        thisNumber += int.Parse(thisexp[j]);
                else
                    thisNumber = int.Parse(arrExpbyminus[i]);

                arrExpbyminus[i] = thisNumber.ToString();
            }

            int result = int.Parse(arrExpbyminus[0]);
            for (int i = 1; i < arrExpbyminus.Length; i++)
                result -= int.Parse(arrExpbyminus[i]);

            Console.WriteLine(result);
        }
    }
}
