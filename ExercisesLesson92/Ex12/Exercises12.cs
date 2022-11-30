﻿/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.04.14
/// </summary>

using System.IO;

namespace ExercisesLesson92
{
    class Exercises12
    {
        // phương thức sắp xếp các phần tử mảng tăng dần
        static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if(arr[j] < arr[j - 1])
                    {
                        var tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                }
            }
        }

        // phương thức hiển thị các phần tử trong mảng
        static void ShowElements(int[] arr, StreamWriter writer)
        {
            foreach (var item in arr)
            {
                writer.Write(item + " ");
            }
            writer.WriteLine();
        }

        static void Main()
        {
            var inputFileName = "input12.txt";
            var outputFileName = "output12.txt";
            FileInfo fileReader = new FileInfo(inputFileName);
            FileInfo fileWriter = new FileInfo(outputFileName);
            using (var stream = fileWriter.OpenWrite())
            {
                using (var writer = new StreamWriter(stream))
                {
                    using (var reader = fileReader.OpenText())
                    {
                        int t = int.Parse(reader.ReadLine());
                        for (int test = 1; test <= t; test++)
                        {
                            int n = int.Parse(reader.ReadLine());
                            var elements = reader.ReadLine().Split(' ');
                            if (n > 0)
                            {
                                int[] arr = new int[n];
                                for (int i = 0; i < n; i++)
                                {
                                    arr[i] = int.Parse(elements[i]);
                                }
                                Sort(arr); // gọi phương thức sắp xếp
                                writer.WriteLine($"Test {test}:");
                                ShowElements(arr, writer);
                            }
                        }
                    }
                }
            }
        }
    }
}
