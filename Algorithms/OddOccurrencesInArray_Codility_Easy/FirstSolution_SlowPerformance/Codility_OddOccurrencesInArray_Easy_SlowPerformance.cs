
namespace Algorithms.OddOccurrencesInArray_Codility_Easy.FirstSolution_SlowPerformance
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
    /// </summary>
    public static class Codility_OddOccurrencesInArray_Easy_SlowPerformance
    {
        /// <summary>
        /// n*n time complexity
        /// </summary>
        /// <param name="a">non empty number array</param>
        /// <returns>Odd occurent number</returns>
        public static int FindOddOccurrenceInArray(int[] a)
        {
            int x = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                x = a[i];
                int c = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (x == a[j])
                    {
                        c++;
                    }
                }
                if (c % 2 == 1)
                {
                    return x;
                }
            }

            return x;
        }
    }
}
