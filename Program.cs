using System;

namespace ResponsiPemrograman2687
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan = new Karyawan(19112687, "Erwin Syahrul    :", 1500000);
            Karyawan karyawan2 = new Karyawan(19112687, "Muhammad Erwin   :", 1200000);

            Console.WriteLine("| NIK | \t  | Nama |\t        | Gaji | ");
            Console.WriteLine("---------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n------ Gaji Naik 10% ------");
            Console.WriteLine();


            Console.WriteLine("| NIK | \t  | Nama |\t        | Gaji | ");
            Console.WriteLine("---------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gaji { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gaji = 0;
            }
            else
            {
                this.gaji = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gaji);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * gaji;
            gaji += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gaji);
        }
    }
}