﻿/**************************************************************************
 *                                                                        *
 *  File:        Utils.cs                                                 *
 *  Description: Merge Sort multi-agent                                   *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;

namespace MASMA
{
    public class Utils
    {
        // Common
        public static int Length = 10000;
        public static int[] Source = new int[Length];
        public static int[] Destination = new int[Length];
        public static Random Rand = new Random();

        // MergeSort
        public static int Threshold = 5;

        // Enumeration
        public static bool SkipNext = false;
        public static int NoAgents = 10;

        // OddEven
        public static bool IsSorted = false;
        public static bool OrderType = true;

        // Tests
        public static void Assert(int[] array)
        {
            for (int i = 0; i < Length - 1; ++i)
            {
                if (array[i] > array[i + 1])
                {
                    Console.WriteLine("FAIL");
                    break;
                }
            }
        }

        public static void Init(Case @case)
        {
            switch (@case)
            {
                case Case.WORST:
                    for (int i = 0; i < Length; i++)
                    {
                        Source[i] = Length - i;
                    }
                    break;
                case Case.AVERAGE:
                    for (int i = 0; i < Length; i++)
                    {
                        Source[i] = Rand.Next(Length);
                    }
                    break;
                case Case.BEST:
                    for (int i = 0; i < Length; i++)
                    {
                        Source[i] = i;
                    }
                    break;
            }
        }

        // Utils
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

    public enum Case
    {
        BEST = 0,
        WORST,
        AVERAGE
    }
}