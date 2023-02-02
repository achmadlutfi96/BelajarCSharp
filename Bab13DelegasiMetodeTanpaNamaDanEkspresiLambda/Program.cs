using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bab13DelegasiMetodeTanpaNamaDanEkspresiLambda
{
    // mendeklarasikan tipe delegasi
    delegate double OperasiBilangan(double a, double b);
    public delegate void BalikDanCetak();
    internal class Program
    {
        static double Tambah(double bil1, double bil2)
        {
            return bil1 + bil2;
        }
        static double Kurang(double bil1, double bil2)
        {
            return bil1 - bil2;
        }
        static double Kali(double bil1, double bil2)
        {
            return bil1 * bil2;
        }
        static double Bagi(double bil1, double bil2)
        {
            return bil1 / bil2;
        }
        static void Main(string[] args)
        {
            // mendeklarasikan variabel lokal
            int a = 10, b = 3;

            // mendeklarasikan referensi ke tipe delegasi
            OperasiBilangan objDel;

            // membuat objek delegasi
            // untuk menunjuk ke metode Tambah()
            objDel = new OperasiBilangan(Tambah);
            
            // memanggil metode yang ditunjuk
            // oleh objek delegasi melalui objDel
            Console.WriteLine("{0} + {1} = {2}", a, b, objDel(a,b));

            // membuat objek delegasi
            // untuk menunjuk ke metode Kurang()
            objDel = new OperasiBilangan(Kurang);
            Console.WriteLine("{0} - {1} = {2}", a, b,objDel(a,b));

            // membuat objek delegasi
            // untuk menunjuk ke metode Kali()
            objDel = new OperasiBilangan(Kali);
            Console.WriteLine("{0} * {1} = {2}", a, b, objDel(a, b));

            // membuat objek delegasi
            // untuk menunjuk ke metode Bagi()
            objDel = new OperasiBilangan(Bagi);
            Console.WriteLine("{0} / {1} = {2}", a, b, objDel(a, b));


            // Metode Tanpa Nama
            StringBuilder sb = new StringBuilder("TFOSORCIM");
            BalikDanCetak objDelegasi = delegate
            {
                char[] temp = new char[sb.Length];
                int j = 0;
                for (int i = sb.Length - 1; i >= 0; i--, j++)
                {
                    temp[j] = sb[i];
                }
                sb.Clear();
                sb.Append(new String(temp));
                Console.WriteLine(sb.ToString());
            };

            Console.WriteLine("Mengeksekusi objDel:");
            objDelegasi();
        }
    }
}
