using System;
using System.Collections.Generic;
using System.Text;

namespace LittleProject.TriagleMaker
{
    class Program
    {
        private int _pilihan;
        private int _target;
        public static bool checkTarget = false;
        public static string pesan;
        public static string choice;

        public int Pilih
        {
            set
            {
                _pilihan = value;
            }
        }

        static void Main()
        {
            Program player = new Program();
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Triagle Maker");
                Console.ResetColor();

                do
                {
                    Console.WriteLine("Pilih Segitiga");
                    Console.Write(" 1. Ascending \n 2. Descending \n 3. Pyramid \n = ");

                    player.Pilih = int.Parse(Console.ReadLine());

                } while (player._pilihan != 1 && player._pilihan != 2 && player._pilihan != 3);
                do
                {

                    Console.Write("Masukkan Target = ");
                    checkTarget = int.TryParse(Console.ReadLine(), out player._target);

                    pesan = player.CheckingTarget();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(pesan);
                    Console.ResetColor();

                } while (!checkTarget);

                player.PilihSegitigaDanPrintSegitiga();

                Console.WriteLine("\nIngin membuat segitiga lagi ? (Y/N)");
                choice = Console.ReadLine();
                Console.Clear();
            } while (choice.ToUpper() != "N");
        }

        private string CheckingTarget()
        {
            string message = string.Empty;
            if (!checkTarget)
            {
                message = "Tolong Masukkan Target !";
            }
            return message;
        }

        private void PilihSegitigaDanPrintSegitiga()
        {
            switch (_pilihan)
            {
                case 1:
                    for (int i = 1; i <= _target; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" *");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for (int i = _target; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" *");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 1; i <= _target; i++)
                    {
                        for (int j = _target; j >= i; j--)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 1; k <= (2 * i - 1); k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
