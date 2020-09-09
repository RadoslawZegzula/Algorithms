
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
        /// <param name="array">non empty number array</param>
        /// <returns>Odd occurent number</returns>
        public static int FindOddOccurrenceInArray(int[] array)
        {
            int x = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                x = array[i];
                int c = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (x == array[j])
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
