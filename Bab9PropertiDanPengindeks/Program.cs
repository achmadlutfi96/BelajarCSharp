using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab9PropertiDanPengindeks
{
    class Segiempat
    {
        private double panjang;
        private double lebar;

        public Segiempat(double p, double l)
        {
            this.panjang = p;
            this.lebar = l;
        }

        // Properti Panjang
        public double Panjang
        {
            get
            {
                return panjang;
            }
            set
            {
                panjang = value;
            }
        }
        // Properti Lebar
        public double Lebar
        {
            get
            {
                return lebar;
            }
            set
            {
                lebar = value;
            }
        }

        public double HitungLuas()
        {
            return panjang * lebar;
        }

        public void CetakData()
        {
            Console.WriteLine("panjang = " + this.panjang);
            Console.WriteLine("lebar \t= "+this.lebar);
        }

        public void CetakLuas()
        {
            Console.WriteLine("Luas \t= " + this.HitungLuas());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Segiempat se = new Segiempat(8,6);
            //se.Panjang = 4;
            //se.Lebar = 5;

            Console.WriteLine("Keadaan awal:");
            se.CetakData();
            se.CetakLuas();

            // mengubah data melalui properti
            se.Panjang = 10;
            se.Lebar = 5;
            Console.WriteLine("\nKeadaan akhir:");
            se.CetakData();
            se.CetakLuas();
        }
    }
}
