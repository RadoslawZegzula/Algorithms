
namespace Algorithms.FrogJmp_Codility_Easy
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
    /// </summary>
    class FrogJmp_Codility_Easy
    {
        public int CountMinimalNumberOfJumpsFromXToY(int x, int y, int d)
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
