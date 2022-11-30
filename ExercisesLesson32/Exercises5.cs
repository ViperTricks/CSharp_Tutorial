﻿using System;

namespace ExercisesLesson32
{
    class Exercises5
    {
        static void Main()
        {
            // nhập dữ liệu vào từ bàn phím và tách các số tại vị trí có dấu cách
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]); // chuyển string sang int
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);

            // hiển thị kết quả
            if (a == b && b == c) // nếu ba số bằng nhau không có giá trị min
            {
                Console.WriteLine("NO RESULT");
            }
            else
            {
                int min = a;
                if (min > b)
                {
                    min = b;
                }
                if (min > c)
                {
                    min = c;
                }
                Console.WriteLine(min);
            }

        }
    }
}
