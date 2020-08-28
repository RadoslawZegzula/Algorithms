
namespace Algorithms.FrogJmp_Codility_Easy
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
    /// </summary>
    public static class FrogJmp_Codility_Easy
    {
        public static int CountMinimalNumberOfJumps(int startingPosition, int endingPosition, int jumpDistance)
            =>
            (endingPosition - startingPosition) / jumpDistance * jumpDistance 
            >=
            (endingPosition - startingPosition)
            ?
            (endingPosition - startingPosition) / jumpDistance
            :
            (endingPosition - startingPosition) / jumpDistance + 1;

    }
}
