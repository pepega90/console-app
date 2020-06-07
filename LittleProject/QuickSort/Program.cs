using System;
using System.Collections.Generic;
using System.Text;

namespace LittleProject.QuickSort
{
    class Program
    {
        public static int Partisi(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            while (true)
            {
                while (arr[low] < pivot)
                {
                    low++;
                }
                while (arr[high] > pivot)
                {
                    high--;
                }
                if (low < high)
                {
                    int temp = arr[low];
                    arr[low] = arr[high];
                    arr[high] = temp;
                }
                else
                {
                    return high;
                }
            }
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partisi(arr, low, high);
                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }
        }

        static void Main()
        {
            int[] arr = { 5, 2, 4, 3, 1 };
            Console.WriteLine("Sebelum di urutkan");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            QuickSort(arr, 0, arr.Length - 1);
            Console.Write("Setelah di urutkan\n");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
