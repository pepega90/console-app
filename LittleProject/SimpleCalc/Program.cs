using System;
using System.Collections.Generic;
using System.Text;

namespace LittleProject.SimpleCalc
{
    class Program
    {
        public static int opRator;
        // angka variabel
        public static int num1;
        public static int num2;
        // check field
        public static bool checkNum1 = false;
        public static bool checkNum2 = false;
        public static string choice;

        static void Main()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Simple Calc");
                Console.ResetColor();
                do
                {
                    // pilih operator
                    Console.Write("Pilih Operator = \n 1. + \n 2. - \n 3. * \n 4. / \n = ");
                    opRator = Convert.ToInt32(Console.ReadLine());
                } while (opRator != 1 && opRator != 2 && opRator != 3 && opRator != 4);

                // input angka pertama
                do
                {
                    Console.Write("Masukkan Angka Pertama = ");
                    checkNum1 = int.TryParse(Console.ReadLine(), out num1);
                    if (!checkNum1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tolong Masukkan Angka !");
                        Console.ResetColor();
                    }
                } while (!checkNum1);


                do
                {
                    // input angka kedua
                    Console.Write("Masukkan Angka Kedua = ");
                    checkNum2 = int.TryParse(Console.ReadLine(), out num2);
                    if (!checkNum2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tolong Masukkan Angka !");
                        Console.ResetColor();
                    }
                } while (!checkNum2);


                // hasil
                int hasil = Perhitungan(num1, num2, opRator);
                Console.WriteLine($"Hasil = {hasil}");

                // choice
                Console.WriteLine("Apakah anda ingin melakukan perhitungan lagi ? (Y/N)");
                choice = Console.ReadLine();
                Console.Clear();
            } while (choice.ToUpper() != "N");
        }

        public static int Perhitungan(int num1, int num2, int op)
        {
            int result = 0;
            switch (op)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
            }
            return result;
        }
    }
}
