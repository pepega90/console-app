using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace LittleProject.BatuGuntingKertas
{
    class BatuGuntingKertas
    {
        public static string choice;
        public static int scorePlayer;
        public static int scoreMusuh;

        static string Check(string cpu, string player)
        {
            string result = string.Empty;
            if (player == "batu")
            {
                if (cpu == "Kertas")
                {
                    result = "Kamu Kalah";
                }
                else if (cpu == "Batu")
                {
                    result = "Seri";
                }
            }

            if (player == "batu")
            {
                if (cpu == "Gunting")
                {
                    result = "Kamu Menang";
                }
                else if (cpu == "Batu")
                {
                    result = "Seri";
                }
            }

            if (player == "gunting")
            {
                if (cpu == "Batu")
                {
                    result = "Kamu Kalah";
                }
                else if (cpu == "Gunting")
                {
                    result = "Seri";
                }
            }

            if (player == "gunting")
            {
                if (cpu == "Kertas")
                {
                    result = "Kamu Menang";
                }
                else if (cpu == "Gunting")
                {
                    result = "Seri";
                }
            }

            if (player == "kertas")
            {
                if (cpu == "Batu")
                {
                    result = "Kamu Menang";
                }
                else if (cpu == "Kertas")
                {
                    result = "Seri";
                }
            }

            if (player == "kertas")
            {
                if (cpu == "Gunting")
                {
                    result = "Kamu Kalah";
                }
                else if (cpu == "Kertas")
                {
                    result = "Seri";
                }
            }

            return result;
        }

        static string Cpu(int num)
        {
            string Enemy = string.Empty;

            switch (num)
            {
                case 0:
                    Enemy = "Batu";
                    break;
                case 1:
                    Enemy = "Gunting";
                    break;
                case 2:
                    Enemy = "Kertas";
                    break;
                default:
                    Enemy = "Tidak ditemukan";
                    break;
            }
            return Enemy;
        }

        static void Main()
        {
            do
            {
                // reset score
                scorePlayer = 0;
                scoreMusuh = 0;
                do
                {
                    string inputanPlayer;
                    do
                    {
                        // Player Controller
                        Console.WriteLine("Permainan Batu Gunting Kertas");
                        Console.Write("Masukkan Inputan = ");
                        inputanPlayer = Console.ReadLine();
                        Console.WriteLine();

                    } while (inputanPlayer != "batu" && inputanPlayer != "gunting" && inputanPlayer != "kertas");

                    // CPU Controller
                    Random rand = new Random();
                    int randCPU = rand.Next(0, 3);
                    string Enemy = Cpu(randCPU);

                    // check inputan player dengan musuh
                    string hasil = Check(Enemy, inputanPlayer);


                    if (hasil == "Kamu Menang")
                    {
                        scorePlayer += 1;
                    }
                    else if (hasil == "Kamu Kalah")
                    {
                        scoreMusuh += 1;
                    }

                    // print hasil dari musuh dan inputan player
                    Console.Write("CPU = {0} \t Player = {1}", Enemy, inputanPlayer);
                    Console.WriteLine();
                    Console.WriteLine();
                    // print score dari musuh dan player
                    Console.Write("Score \t CPU = {0} \t Player = {1}", scoreMusuh, scorePlayer);
                    Console.WriteLine();
                    Console.WriteLine();

                    if (hasil == "Kamu Menang")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (hasil == "Kamu Kalah")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (hasil == "Seri")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    // print hasil
                    Console.WriteLine("Hasil = {0}", hasil);

                    // reset color
                    Console.ResetColor();
                } while (scoreMusuh < 3 && scorePlayer < 3);

                Console.Write("Apakah anda ingin bermain lagi ? (Y/N)");
                choice = Console.ReadLine();
                Console.Clear();
            } while (choice != "n");

        }
    }
}
