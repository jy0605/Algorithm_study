using System;

namespace ForCodingTest
{
    internal class Backjun_1434
    {
        static void Main()
        {

            string[] input1 = Console.ReadLine().Split(' ');

            int[] arrBoxes = new int[int.Parse(input1[0])];
            int[] arrBooks = new int[int.Parse(input1[1])];

            string[] input2 = Console.ReadLine().Split(' ');
            arrBoxes = Array.ConvertAll(input2, int.Parse);
            List<int> listBoxes = arrBoxes.ToList();

            string[] input3 = Console.ReadLine().Split(' ');
            arrBooks = Array.ConvertAll(input3, int.Parse);

            int wastedCapacity = 0;

            for (int i = 0; i < arrBooks.Length; i++)
            {
                if (arrBooks[i] <= listBoxes[0])
                {
                    listBoxes[0] -= arrBooks[i];
                }
                else
                {
                    wastedCapacity += listBoxes[0];
                    listBoxes.RemoveAt(0);
                    i--;
                }
            }

            for (int j = 0; j < listBoxes.Count; j++)
                wastedCapacity += listBoxes[j];

            Console.WriteLine(wastedCapacity);


        }
    }
}
