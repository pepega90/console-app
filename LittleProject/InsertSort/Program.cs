using System;
using System.Collections.Generic;
using System.Text;

namespace LittleProject.InsertSort
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 5, 3, 4, 1, 2 };
            Console.WriteLine("Before sorting");
            PrintArr(arr);
            Insert(arr);
            Console.WriteLine("\nAfter sorting");
            PrintArr(arr);
        }

        public static void Insert(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int ElementSetelahnya = arr[i];
                int IndeAwalElement = i - 1;
                while (IndeAwalElement >= 0 && arr[IndeAwalElement] > ElementSetelahnya)
                {
                    arr[IndeAwalElement + 1] = arr[IndeAwalElement];
                    IndeAwalElement = IndeAwalElement - 1;
                }

                arr[IndeAwalElement + 1] = ElementSetelahnya;
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
