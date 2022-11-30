﻿/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson53
{
    class Exercises1
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var elements = Console.ReadLine().Split(' ');
                int[] arr = new int[n];
                for (int index = 0; index < elements.Length; index++)
                {
                    arr[index] = int.Parse(elements[index]);
                }
                QuickSort(arr, 0, n - 1);
                Console.WriteLine($"Test {i}: ");
                ShowArray(arr);
            }
        }

        // thuật toán quicksort
        static void QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int p = Partition(arr, leftIndex, rightIndex);
                QuickSort(arr, leftIndex, p - 1);
                QuickSort(arr, p + 1, rightIndex);
            }
        }

        // phương thức sắp xếp và phân mảnh mảng
        static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            int pivot = arr[rightIndex];
            int i = leftIndex;
            for (int j = leftIndex; j <= rightIndex; j++)
            {
                if (arr[j] < pivot)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[rightIndex]);
            return i;
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        // Phương thức hiển thị các phần tử trong mảng
        static void ShowArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
