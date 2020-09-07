using System;
using System.Collections.Generic;


namespace Algorithms.CyclicRotation_Codility_Easy
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
    /// </summary>
    class CyclicRotation_Codility_Easy
    {
        public int[] MoveNumbersRight(int[] array, int numberOfSteps)
        {
            if (array.Length == 0 || numberOfSteps == 0)
            {
                return array;
            }

            if (numberOfSteps > array.Length)
            {
                numberOfSteps %= array.Length;
            }

            if (numberOfSteps == array.Length)
            {
                return array;
            }

            int[] arr = new int[array.Length];
            int odj = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (numberOfSteps > i)
                {
                    arr[i] = array[array.Length - numberOfSteps + i];
                }
                if (numberOfSteps <= i)
                {
                    arr[array.Length - odj] = array[array.Length - 1 - i];
                    odj++;
                }
            }
            return arr;
        }
    }
}


