
namespace Algorithms.FrogJmp_Codility_Easy
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
    /// </summary>
    public static class FrogJmp_Codility_Easy
    {
        public static int CountMinimalNumberOfJumpsFromXToY(int x, int y, int d)
            =>
            (y - x) / d * d 
            >=
            (y - x)
            ?
            (y - x) / d
            :
            (y - x) / d + 1;

    }
}
