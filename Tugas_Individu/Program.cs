using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Individu
{
    //Menambahkan class program yang di dalamnya berisi function dan method
    class Program
    {
        //Mendeklarasikan array yang dimana array ini berfungsi untuk menyimpan data yang berupa integer/angka dengan ukuran maksimal yaitu 20 data
        private int[] a = new int[20];

        //Mendeklarasikan sebuah variabel dengan tipe data integer/angka untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi/method untuk menerima masukan dari user
        public void read()
        {
            //Di sini ada method perulangan while yang berfungsi untuk menerima angka dan untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan Banyaknya Elemen Pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray Dapat Mempunyai Maksimal 20 Elemen.\n");

            }
            //Membuat tampilan yang berisi perintah untuk memasukan elemen array
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukan Elemen Array");
            Console.WriteLine("------------------------");

            // menambahkan method perulangan for agar Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        //menambahkan function display untuk membuat suatu tampilan yang bersifat publik artinya semua method di dalamnya dapat di gunkan pada class/function lain
        public void Display()
        {
            // Membuat tampilan pada project berupa teks elemen array yang telah tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Elemen Array Yang Telah Tersusun ");
            Console.WriteLine("----------------------------------");

            // menambahkan method perulangan for yang berfungsi menampilkan hasil dari elment yang telah dimasukan oleh user
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        public void BubbleSortArray()
        {
            // menambahkan method perulangan for untuk n-1 passes
            for (int i = 1; i < n; i++)
            {
                // pada pass i, bandingkan n-1 elemen pertamana dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1])// jika elemen tidak dalam urutan yang benar
                    {
                        //menambahkan method untuk menukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        //menambahkan function static void main untuk memanggil memangggil semua function/method yang telah di buat agar project bisa dijalankan
        static void Main(string[] args)
        {
            //Membuat objek kelas bubblesort
            Program myList = new Program();

            //memanggil fungsi untuk menerima elemen array
            myList.read();
            //pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            //memanggil fungsi untuk menampilkan array yang tersusun
            myList.Display();
            //membuat tampilan berisi perintah untuk keluar dari project
            Console.WriteLine("\n\n Tekan Tombol Apa Saja Untuk Keluar.");
        }
    }
}
