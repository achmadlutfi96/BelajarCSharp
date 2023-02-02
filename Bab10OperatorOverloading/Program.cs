using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab10OperatorOverloading
{
    class MyString
    {
        private string text;

        //konstruktor
        public MyString(string s) { text = s; }

        // properti Text
        public string Text { 
            get { return text; } 
            set { text = value; } 
        }

        // overload operator plus (+)
        public static MyString operator + (MyString s1, MyString s2)
        {
            MyString temp = new MyString(s1.Text + s2.Text);
            return temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyString namadepan = new MyString("Achmad");
            MyString spasi = new MyString(" ");
            MyString namabelakang = new MyString("Lutfi");

            // operator plus (+) diterapkan untuk tipe MyString
            MyString namalengkap = namadepan + spasi + namabelakang;

            Console.WriteLine("Nama Depan\t: "+ namadepan.Text);
            Console.WriteLine("Nama Belakang\t: " + namabelakang.Text);
            Console.WriteLine("Nama Lengkap\t: " + namalengkap.Text);
        }
    }
}
