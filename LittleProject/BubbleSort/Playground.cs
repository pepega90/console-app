using System;
using System.Collections.Generic;
using System.Text;

namespace LittleProject
{
    class Playground
    {
        static void Main()
        {
            // Bubble sort
            int[] arr = { 5, 3, 4, 2, 1 };
            int i, j, k;
            Console.WriteLine("Data sebelum di urutkan");
            for(i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            

            for(i = 0; i < arr.Length; i++)
            {
                for(j = i + 1; j < arr.Length; j++)
                {
                   if(arr[i] > arr[j])
                    {
                        k = arr[i];
                        arr[i] = arr[j];
                        arr[j] = k;
                    }
                }
            }

            Console.WriteLine("\nData setelah di urutkan");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
