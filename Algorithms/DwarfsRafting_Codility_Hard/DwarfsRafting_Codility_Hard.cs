﻿using System;
using System.Linq;

namespace Algorithms.DwarfsRafting_Codility_Hard
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/91-tasks_from_indeed_prime_2016_challenge/dwarfs_rafting/
    /// </summary>
    public static class DwarfsRafting_Codility_Hard
    {
        public static int ReturnNumberOfDwarfesThatCanFitOnTheRaft(int raftLength, string seatsForBarrels, string seatsOccupiedByDwarfs)
        {
            InitalizeVariables(seatsForBarrels, seatsOccupiedByDwarfs, out string[] positionsOfBarrels, out string[] occupiedSeatsByDwarfs, out int numberOfOccupiedSeatsByBarrels, out int numberOfOccupiedSeatsByDwarfs);

            if (IsRaftDontHaveAnyFreeSeats(raftLength, numberOfOccupiedSeatsByBarrels, numberOfOccupiedSeatsByDwarfs))
            {
                return 0;
            }

            var halfSize = raftLength / 2;
            var spaceInPart = raftLength * raftLength / 4;

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

        private static bool IsRaftDontHaveAnyFreeSeats(int raftLength, int numberOfOccupiedSeatsByBarrels, int numberOfOccupiedSeatsByDwarfs)
        {
            int maxFreeSeats = raftLength * raftLength;
            return numberOfOccupiedSeatsByBarrels == maxFreeSeats || numberOfOccupiedSeatsByDwarfs == maxFreeSeats;
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

        private static int LetterToNumber(char letter)
        {
            if ('A' == letter) return 1;
            if ('B' == letter) return 2;
            if ('C' == letter) return 3;
            if ('D' == letter) return 4;
            if ('E' == letter) return 5;
            if ('F' == letter) return 6;
            if ('G' == letter) return 7;
            if ('H' == letter) return 8;
            if ('I' == letter) return 9;
            if ('J' == letter) return 10;
            if ('K' == letter) return 11;
            if ('L' == letter) return 12;
            if ('M' == letter) return 13;
            if ('N' == letter) return 14;
            if ('O' == letter) return 15;
            if ('P' == letter) return 16;
            if ('Q' == letter) return 17;
            if ('R' == letter) return 18;
            if ('S' == letter) return 19;
            if ('T' == letter) return 20;
            if ('U' == letter) return 21;
            if ('V' == letter) return 22;
            if ('W' == letter) return 23;
            if ('X' == letter) return 24;
            if ('Y' == letter) return 25;
            if ('Z' == letter) return 26;

            return -1;
        }

    }
}
