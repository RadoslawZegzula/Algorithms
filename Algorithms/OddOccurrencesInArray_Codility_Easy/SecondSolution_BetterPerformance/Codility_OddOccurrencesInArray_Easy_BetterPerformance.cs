using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.OddOccurrencesInArray_Codility_Easy.SecondSolution_BetterPerformance
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
    /// </summary>
    public static class Codility_OddOccurrencesInArray_Easy_BetterPerformance
    {
        /// <summary>
        /// O(N) or O(N*log(N)) time complexity
        /// </summary>
        /// <param name="array">non empty number array</param>
        /// <returns>The odd occurent number</returns>
        public static int FindOddOccurrenceInArray(int[] array)
        {
            Array.Sort(array);
            int c = 0;
            int temp = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != temp && c % 2 == 1)
                {
                    break;
                }

                temp = array[i];
                c++;

                if (array[i] != temp)
                {
                    return temp;
                }
            }

            return temp;
        }
    }
}
