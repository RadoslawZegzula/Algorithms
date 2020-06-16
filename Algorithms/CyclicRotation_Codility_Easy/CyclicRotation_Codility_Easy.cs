using System;
using System.Collections.Generic;


namespace Algorithms.CyclicRotation_Codility_Easy
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
    /// </summary>
    class CyclicRotation_Codility_Easy
    {
        public int[] MoveNumbersRight(int[] a, int k)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (a.Length == 0 || k == 0)
            {
                return a;
            }

            if (k > a.Length)
            {
                k = k % a.Length;
            }

            if (k == a.Length)
            {
                return a;
            }

            int[] arr = new int[a.Length];
            int odj = 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (k > i)
                {
                    arr[i] = a[a.Length - k + i];
                }
                if (k <= i)
                {
                    arr[a.Length - odj] = a[a.Length - 1 - i];
                    odj++;
                }
            }
            return arr;
        }
    }
}


