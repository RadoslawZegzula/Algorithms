using System;
using System.Linq;

namespace Algorithms.TapeEquilibrium_Codility_Easy
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
    /// </summary>
    class TapeEquilibrium_Codility_Easy
    {
        public int ReturnMinimalDiffrencBetweenNumbers(int[] a)
        {
            int min = Int32.MaxValue;
            int c = 0;
            int tape = 0;
            int sum = a.Sum();
            for (int i = 0; i < a.Length - 1; i++)
            {
                c += a[i];
                if (a[i] >= 0 && sum >= 0)
                {
                    tape = Math.Abs(c - Math.Abs(c - sum));
                }
                if (a[i] >= 0 && sum <= 0)
                {
                    tape = Math.Abs(c) + (sum - c);

                }
                if (a[i] < 0)
                {
                    tape = Math.Abs(c) + (sum - c);
                }

                if (Math.Abs(tape) <= min)
                {
                    min = Math.Abs(tape);
                }
            }
            return min;
        }
    }
}
