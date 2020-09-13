using System;

namespace Algorithms.BinaryGap_Codility_Easy
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
    /// </summary>
    public static class BinaryGap_Codility_Easy
    {
        public static int FindLongestSequenceOfBinaryZeros(int number)
        {
            var binary = Convert.ToString(number, 2);
            var m = 0;
            var max = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1' && m > max)
                {
                    max = m;
                }

                if (binary[i] == '1')
                {
                    m = 0;
                }
                if (binary[i] == '0')
                {
                    m++;
                }
            }
            return max;
        }
    }
}
