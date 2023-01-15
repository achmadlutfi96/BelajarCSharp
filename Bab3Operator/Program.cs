using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab3Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan nilai=");
            Int16 number = Convert.ToInt16(Console.ReadLine());
            string kondisi = (number > 50) ? "lulus" : "tidak lulus";
            Console.WriteLine(kondisi);
        }
    }
}
