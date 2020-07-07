using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("\n1. Tambah Penjualan");
            Console.WriteLine("\n2. Hapus Penjualan");
            Console.WriteLine("\n3. Tampilkan Penjualan");
            Console.WriteLine("\n4, Keluar");
            Console.WriteLine();


        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();

            Console.WriteLine("\n Tambah Data Penjualan");
            Console.WriteLine("\nNota : ");
            penjualan.Nota = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTanggal : ");
            penjualan.Tanggal = Console.ReadLine();
            Console.WriteLine("\nCustomer : ");
            penjualan.Customer = Console.ReadLine();
            Console.WriteLine("\nJenis [T/K] :");
            string Jenis = Console.ReadLine();
            penjualan.Jenis = (Jenis == "T") ? "Tunai" : "Kredit";
            Console.WriteLine("\nTotal Nota : ");
            penjualan.TotalNota =double.Parse(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            int nomor = -1, hapus = -1, nota;

            Console.WriteLine("\nHapus Data Penjualan ");
            Console.WriteLine();

            Console.WriteLine("\nNota : ");
            nota = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                nomor++;
                    if (penjualan.Nota == nota)
                {
                    hapus = nomor;
                }
            }
            if (hapus != -1)
            {
                daftarPenjualan.RemoveAt(hapus);
                Console.WriteLine("\nData Penjualan Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("\nNota Tidak Ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int urutan = 0;


            Console.WriteLine("\nData Penjualan");
            foreach(Penjualan penjualan in daftarPenjualan)
            {
                urutan++;
              

                Console.WriteLine("{0}. {1}, {2},{3}, {4}, {5}", urutan, penjualan.Nota, penjualan.Tanggal, penjualan.Customer, penjualan.Jenis, penjualan.TotalNota);
            }
            if (urutan < 1)
            {
                Console.WriteLine("\n Data Penjualan Kosong\n");
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
