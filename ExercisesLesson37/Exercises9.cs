﻿using System;

namespace ExercisesLesson37
{
    class Exercises9
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j < 2 * h; j++)
                {
                    if (h - i + 1 == j || j == h + i - 1 || i == h)
                    {
                        Console.Write(" 1 ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
