using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab2VariabelDanTipeData
{
    class Manusia
    {
        string name;

        public Manusia(string name)
        {
            this.name = name;
        }

        public void calledName()
        {
            Console.WriteLine("Hallo, " +this.name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama:");
            string name = Console.ReadLine();
            Manusia m = new Manusia(name);
            m.calledName();
        }
    }
}
