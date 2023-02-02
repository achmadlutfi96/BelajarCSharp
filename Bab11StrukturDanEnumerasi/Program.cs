using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab11StrukturDanEnumerasi
{
    internal class Program
    {
        // Mendefinisikan struktur dengan nama Titik
        struct Titik
        {
            public int x;
            public int y;
            private int _z;

            // Property Z
            public int Z { 
                get { 
                    return _z; 
                } 
                set { 
                    _z = value; 
                } 
            }
        }

        enum JenisKelamin { Pria, Wanita};
        enum NamaHari { Minggu=1, Senin, Selasa, Rabu, Kamis, Jumat, Sabtu};

        static void Main(string[] args)
        {
            // mendeklarasikan variable bertipe Titik
            Titik A;
            Titik B;
            Titik C = new Titik();

            // Mengisi nilai ke dalam A
            A.x = 0;
            A.y = 0;

            // Mengisi nilai ke dalam B
            B.x = 13;
            B.y = 16;

            // Mengisi nilai ke dalam C
            C.x = 3;
            C.y = 4;
            C.Z = 5;

            // Menampilkan nilai
            Console.WriteLine("A({0},{1})",A.x,A.y);
            Console.WriteLine("B({0},{1})",B.x,B.y);
            Console.WriteLine("C({0},{1},{2})", C.x, C.y, C.Z);


            // ENUMERASI
            string nama = "Lutfi";
            Console.WriteLine("Nama \t: "+nama);
            Console.WriteLine("Jenis Kelamin \t: " + JenisKelamin.Pria);
            Console.WriteLine("Hari Lahir \t: " + NamaHari.Jumat);

        }
    }
}
