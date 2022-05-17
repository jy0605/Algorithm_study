using System;

namespace ForCodingTest
{
    internal class Backjun_1459
    {
        static void main()
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int costofline = int.Parse(inputs[2]);
            int costofslash = int.Parse(inputs[3]);

            long result = 0;

            if (costofslash < costofline)
                result = (X + Y) * costofline;
            else
            {

            }
        }
    }
}
