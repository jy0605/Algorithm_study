using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodingTest
{
    internal class Backjun_9934
    {
        static void Main_()
        {
            // 완전이진트리

            int K = int.Parse(Console.ReadLine());
            int[] thisBinaryTree = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] result = solution(thisBinaryTree);

            Console.WriteLine();
        }

        public static int[] solution(int[] array)
        {
            int[] result = new int[1];
            if (array.Length == 1)
                return array;
            else
            {
                int middleIndex = Math.DivRem(array.Length, 2).Quotient;
                int[] thisArray_left = new int[middleIndex];
                int[] thisArray_right = new int[middleIndex];

                thisArray_left = array.Take(middleIndex).ToArray();
                thisArray_right = array.Skip(middleIndex+1).ToArray();

                result.Append(array[middleIndex]);
                result.Concat(solution(thisArray_left));
                result.Concat(solution(thisArray_right));

                return result;
            }
        }
    }
}
