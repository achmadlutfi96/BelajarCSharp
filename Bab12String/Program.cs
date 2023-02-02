using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab12String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Pemrograman C#";
            // mengakses properti
            Console.WriteLine(s.Length);

            // memanggil metode
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.Substring(12,2));


            // array dari type karakter
            char[] arrchar = {'.', 'N','E','T'};

            // melewatkan array ke dalam
            // konstruktor string
            string s2 = new string(arrchar);
            Console.WriteLine("Microsoft "+s2);

            // array dari type karakter
            char[] arrchar2 = { 'M', 'i', 'c', 'r', 'o', 's', 'o', 'f', 't' };

            string s3 = new string(arrchar2, 0, 5);
            Console.WriteLine(s3);


            // array dari tipe string
            string[] bulan = { "Januari","Februari", "Maret",
                                "April", "Mei", "Juni",
                                "Juli", "Agustus", "September",
                                "Oktober", "November", "Desember"};
            // mengambil tanggal saat ini
            DateTime tanggal = DateTime.Today;

            // ekstrak bulan dari tanggal
            int mm = tanggal.Month;

            Console.WriteLine("Tanggal sekarang: " + tanggal);
            Console.WriteLine("Tanggal sekarang: {0} {1} {2}", tanggal.Day, bulan[mm - 1], tanggal.Year);


            // Penggunaan Kelas StringBuilder
            StringBuilder sb= new StringBuilder(99);
            sb.Append("Pemrogramman ");
            sb.Append("Visual C#");

            // menampilkan string
            Console.WriteLine(sb);
            int kapasitas = sb.Capacity;
            Console.WriteLine(kapasitas);

            Console.WriteLine("sb \t\t: "+sb);
            Console.WriteLine("sb.Capacity \t: " + sb.Capacity);
            Console.WriteLine("sb.MaxCapacity \t: " + sb.MaxCapacity);
            Console.WriteLine("Int32.MaxValue \t: " + Int32.MaxValue);
            Console.WriteLine("sb.Length \t: " + sb.Length);
        }
    }
}
