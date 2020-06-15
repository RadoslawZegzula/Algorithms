using System;
using System.Linq;

namespace Algorithms.DwarfsRafting_Codility_Hard
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/91-tasks_from_indeed_prime_2016_challenge/dwarfs_rafting/
    /// </summary>
    public static class DwarfsRafting_Codility_Hard
    {

        /// <param name="n"> Size of the raft</param>
        /// <param name="s"> Occupied seats by barrels</param>
        /// <param name="t"> Occupied seats by dwarfs</param>
        /// <returns> The number of dwarfs that can fit on the raft></returns>
        public static int ReturnNumberOfDwarfesThatCanFitOnTheRaft(int n, string s, string t)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            InitalizeVariables(s, t, out string[] positionsOfBarrels, out string[] occupiedSeatsByDwarfs, out int numberOfOccupiedSeatsByBarrels, out int numberOfOccupiedSeatsByDwarfs);

            if (IsRaftDontHaveAnyFreeSeats(n, numberOfOccupiedSeatsByBarrels, numberOfOccupiedSeatsByDwarfs))
            {
                return 0;
            }

            var halfSize = n / 2;
            var spaceInPart = n * n / 4;

            var frontLeft = spaceInPart;
            var frontRight = spaceInPart;
            var backLeft = spaceInPart;
            var backRight = spaceInPart;

            CheckHowManyFreeSeatsAreAvalibleOnTheRaft(positionsOfBarrels, numberOfOccupiedSeatsByBarrels, halfSize, ref frontLeft, ref frontRight, ref backLeft, ref backRight);

            var frontLeftSituatedDwarfs = 0;
            var frontRightSituatedDwarfs = 0;
            var backLeftSituatedDwarfs = 0;
            var backRightSituatedDwarfs = 0;

            CountNumberOfDwarfesInTheEachPartOfTheRaft(occupiedSeatsByDwarfs, numberOfOccupiedSeatsByDwarfs, halfSize, ref frontLeftSituatedDwarfs, ref frontRightSituatedDwarfs, ref backLeftSituatedDwarfs, ref backRightSituatedDwarfs);

            if (IsRaftNotPossibleToBalance(frontLeft, frontRight, backRight, backLeft, frontLeftSituatedDwarfs, frontRightSituatedDwarfs, backLeftSituatedDwarfs, backRightSituatedDwarfs))
            {
                return -1;
            }

            int seatsForDwarfsOnTheHalfOfTheRaft = CheckHowManyDwarfsFitsOnTheHalfOfTheRaft(frontLeft, frontRight, backLeft, backRight);

            return seatsForDwarfsOnTheHalfOfTheRaft * 2 - numberOfOccupiedSeatsByDwarfs;
        }

        private static void InitalizeVariables(string s, string t, out string[] barrelsPos, out string[] occSeats, out int barrelsCount, out int numberOfOccupiedSeatsByDwarfs)
        {
            barrelsPos = null;
            occSeats = null;
            barrelsCount = 0;
            numberOfOccupiedSeatsByDwarfs = 0;
            if (!string.IsNullOrEmpty(s))
            {
                barrelsPos = s.Split(' ');
                barrelsCount = barrelsPos.Count();
            }
            if (!string.IsNullOrEmpty(t))
            {
                occSeats = t.Split(' ');
                numberOfOccupiedSeatsByDwarfs = occSeats.Count();
            }
        }

        private static bool IsRaftDontHaveAnyFreeSeats(int n, int numberOfOccupiedSeatsByBarrels, int numberOfOccupiedSeatsByDwarfs)
        {
            return numberOfOccupiedSeatsByBarrels == n * n || numberOfOccupiedSeatsByDwarfs == n * n;
        }

        private static void CheckHowManyFreeSeatsAreAvalibleOnTheRaft(string[] barrelsPos, int barrelsCount, int halfSize, ref int frontLeft, ref int frontRight, ref int backLeft, ref int backRight)
        {
            for (int i = 0; i < barrelsCount; i++)
            {
                int x = 0;
                int y = 0;
                if (barrelsPos[i].Length == 2)
                {
                    x = (int)char.GetNumericValue(barrelsPos[i][0]);
                    y = LetterToNumber(barrelsPos[i][1]);
                }
                if (barrelsPos[i].Length == 3)
                {
                    x = int.Parse("" + barrelsPos[i][0] + "" + barrelsPos[i][1]);
                    y = LetterToNumber(barrelsPos[i][2]);
                }


                if (x <= halfSize && y <= halfSize)
                {
                    frontLeft -= 1;
                }

                if (x > halfSize && y <= halfSize)
                { backLeft -= 1; }

                if (x <= halfSize && y > halfSize)
                { frontRight -= 1; }

                if (x > halfSize && y > halfSize)
                { backRight -= 1; }

            }
        }

        private static int CheckHowManyDwarfsFitsOnTheHalfOfTheRaft(int frontLeft, int frontRight, int backLeft, int backRight)
        {
            int frontLeft_frontRight = frontLeft + frontRight;
            int backLeft_backRight = backLeft + backRight;
            int frontLeft_backLeft = frontLeft + backLeft;
            int frontRight_backRight = frontRight + backRight;

            int[] arr = new int[]{
            frontLeft_frontRight,
            backLeft_backRight,
            frontLeft_backLeft,
            frontRight_backRight
        };
            int sumOfTwoPartsWithLessNumberOfFreeSpaces = arr.Min();
            return sumOfTwoPartsWithLessNumberOfFreeSpaces;
        }

        private static void CountNumberOfDwarfesInTheEachPartOfTheRaft(string[] occSeats, int occSeatsCount, int halfSize, ref int dfl, ref int dfr, ref int dbl, ref int dbr)
        {
            for (int i = 0; i < occSeatsCount; i++)
            {
                int x = 0;
                int y = 0;
                if (occSeats[i].Length == 2)
                {
                    x = (int)char.GetNumericValue(occSeats[i][0]);
                    y = LetterToNumber(occSeats[i][1]);
                }
                if (occSeats[i].Length == 3)
                {
                    x = int.Parse("" + occSeats[i][0] + "" + occSeats[i][1]);
                    y = LetterToNumber(occSeats[i][2]);
                }

                if (x <= halfSize && y <= halfSize)
                {
                    dfl += 1;
                }

                if (x > halfSize && y <= halfSize)
                { dbl += 1; }

                if (x <= halfSize && y > halfSize)
                { dfr += 1; }

                if (x > halfSize && y > halfSize)
                { dbr += 1; }

            }
        }

        private static bool IsRaftNotPossibleToBalance(int frontLeft, int frontRight, int backRight, int backLeft, int dfl, int dfr, int dbl, int dbr)
        {
            var min = Math.Min(frontLeft, frontRight);
            min = Math.Min(min, backRight);
            min = Math.Min(min, frontLeft);
            min = Math.Min(min, backLeft);

            if
            (
                dfl > min ||
                dfr > min ||
                dbl > min ||
                dbr > min
            )
            {
                return true;
            }
            return false;
        }

        private static int LetterToNumber(char l)
        {
            if ('A' == l) return 1;
            if ('B' == l) return 2;
            if ('C' == l) return 3;
            if ('D' == l) return 4;
            if ('E' == l) return 5;
            if ('F' == l) return 6;
            if ('G' == l) return 7;
            if ('H' == l) return 8;
            if ('I' == l) return 9;
            if ('J' == l) return 10;
            if ('K' == l) return 11;
            if ('L' == l) return 12;
            if ('M' == l) return 13;
            if ('N' == l) return 14;
            if ('O' == l) return 15;
            if ('P' == l) return 16;
            if ('Q' == l) return 17;
            if ('R' == l) return 18;
            if ('S' == l) return 19;
            if ('T' == l) return 20;
            if ('U' == l) return 21;
            if ('V' == l) return 22;
            if ('W' == l) return 23;
            if ('X' == l) return 24;
            if ('Y' == l) return 25;
            if ('Z' == l) return 26;

            return -1;
        }

    }
}
