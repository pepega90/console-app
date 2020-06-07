using System;
using System.Collections.Generic;
using System.Text;

namespace LittleProject.SelectionSort
{
    class Program
    {
        static void Main()
        {
            // Selection Sort
            int[] arr = { 5, 2, 4, 3, 1 };
            Console.WriteLine("Before sorting");
            PrintArr(arr);
            SelectionSort(arr);
            Console.Write("\nAfter Sorting\n");
            PrintArr(arr);

        }

        public static void SelectionSort(int[] arr)
        {
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength; i++)
            {
                int min = i;
                for (int j = i + 1; j < arrLength; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        public static void PrintArr(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
