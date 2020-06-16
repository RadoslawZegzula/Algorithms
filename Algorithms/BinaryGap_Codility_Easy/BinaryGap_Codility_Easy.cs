using System;

namespace Algorithms.BinaryGap_Codility_Easy
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
    /// </summary>
    class BinaryGap_Codility_Easy
    {
        public int FindLongestSequenceOfBinaryZeros(int n)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var binary = Convert.ToString(n, 2);
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
