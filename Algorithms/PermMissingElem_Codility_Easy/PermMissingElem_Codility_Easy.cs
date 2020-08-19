using System;

namespace Algorithms.PermMissingElem_Codility_Easy
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
    /// </summary>
    public static class PermMissingElem_Codility_Easy
    {
        public static int ReturnMissingElement(int[] a)
        {
            if (a.Length == 0)
            {
                return 1;
            }

            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != i + 1)
                {
                    return i + 1;
                }

            }

            return a.Length + 1;
        }
    }
}
