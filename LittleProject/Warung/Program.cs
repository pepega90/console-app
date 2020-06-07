using System;
using System.Collections.Generic;
using System.Text;

namespace LittleProject.Warung
{
    class Program
    {
        public static string pilihan;
        public static int TotalHarga = 0;

        static void Main()
        {
            User user = new User();

            List<Makanan> listMakanan = new List<Makanan>
            {
                new Makanan{ ID = 1,Nama = "Nasi Uduk", Harga = 5000},
                new Makanan{ ID = 2,Nama = "Sayur Asem", Harga = 4500},
                new Makanan{ ID = 3,Nama = "Ikan Goreng", Harga = 8000}
            };

            List<Minuman> listMinuman = new List<Minuman>
            {
                new Minuman{ ID = 1,Nama = "Es Teh Manis", Harga = 3000},
                new Minuman{ ID = 2,Nama = "Kopi Hitam", Harga = 2500 },
                new Minuman{ ID = 3,Nama = "Air Putih", Harga = 1000}
            };
            do
            {
                Console.WriteLine("\nSelamat Datang di warung nasi MBCH");
                Console.Write("\n1. Lihat Menu Makanan\n2. Lihat Menu Minuman\n3. Keranjang\n4. Lihat Total Harga\n5. Bayar\n6. Keluar\n= ");
                pilihan = Console.ReadLine();
                switch (Convert.ToInt32(pilihan))
                {
                    case 1:
                        listMakanan.ForEach(item => Console.WriteLine("\t{0}\tNama = {1}\tHarga = Rp{2}", item.ID, item.Nama, item.Harga));
                        beli(listMakanan, user);
                        break;
                    case 2:
                        listMinuman.ForEach(item => Console.WriteLine("\t{0}\tNama = {1}\tHarga = Rp{2}", item.ID, item.Nama, item.Harga));
                        beli(listMinuman, user);
                        break;
                    case 3:
                        Console.Write("\t\tMakanan\t\tHarga\n");
                        Console.Write("\t\t=======\t\t=====\n");
                        user.makanan.ForEach(makan => Console.WriteLine("\t{0}\t{1}\tRp{2}\n", makan.ID, makan.Nama, makan.Harga));
                        Console.Write("\t\tMinuman\t\tHarga\n");
                        Console.Write("\t\t=======\t\t=====\n");
                        user.drink.ForEach(minum => Console.WriteLine("\t{0}\t{1}\tRp{2}\n", minum.ID, minum.Nama, minum.Harga));
                        break;
                    case 4:
                        Console.WriteLine("\nTotal Harga = Rp{0}", user.TotalHarga);
                        break;
                    case 5:
                        user.makanan.Clear();
                        user.drink.Clear();
                        user.TotalHarga = 0;
                        Console.WriteLine("\nTerima kasih Sudah Makan di Warteg Kami\n");
                        break;
                    default:
                        break;
                }
            } while (pilihan != "6");
            Console.WriteLine("\nTerima kasih sudah berkunjung ke warteg kami lain kali datang lagi");

        }

        public static void beli(List<Makanan> item, User user)
        {
            int choice;
            Makanan makan;
            string again;
            do
            {
                Console.Write("\n\t\tPilih Makan = ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        makan = item.Find(e => e.ID == 1);
                        user.makanan.Add(makan);
                        user.TotalHarga += makan.Harga;
                        break;
                    case 2:
                        makan = item.Find(e => e.ID == 2);
                        user.makanan.Add(makan);
                        user.TotalHarga += makan.Harga;
                        break;
                    case 3:
                        makan = item.Find(e => e.ID == 3);
                        user.makanan.Add(makan);
                        user.TotalHarga += makan.Harga;
                        break;
                }
                Console.WriteLine("\nAnda ingin Memesan Makanan lagi? (Y/N)");
                again = Console.ReadLine();
            } while (again.ToUpper() != "N");
        }

        public static void beli(List<Minuman> item, User user)
        {
            int choice;
            Minuman minuman;
            string again;
            do
            {
                Console.Write("\n\t\tPilih Minuman = ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        minuman = item.Find(e => e.ID == 1);
                        user.drink.Add(minuman);
                        user.TotalHarga += minuman.Harga;
                        break;
                    case 2:
                        minuman = item.Find(e => e.ID == 2);
                        user.drink.Add(minuman);
                        user.TotalHarga += minuman.Harga;
                        break;
                    case 3:
                        minuman = item.Find(e => e.ID == 3);
                        user.drink.Add(minuman);
                        user.TotalHarga += minuman.Harga;
                        break;
                }
                Console.WriteLine("Anda ingin Memesan Minuman lagi? (Y/N)");
                again = Console.ReadLine();
            } while (again.ToUpper() != "N");
        }
    }

    public class Makanan
    {
        public int ID;
        public string Nama;
        public int Harga;
    }

    public class Minuman : Makanan { };


    public class User
    {
        public List<Makanan> makanan { get; set; } = new List<Makanan>();
        public List<Minuman> drink { get; set; } = new List<Minuman>();
        public int TotalHarga { get; set; } = 0;

    }


}
