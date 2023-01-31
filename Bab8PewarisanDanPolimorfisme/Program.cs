using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KelasDasar
{
    protected int bilangan;

    public KelasDasar(int i)
    {
        bilangan = i;
    }

    // mendefinisikan metode virtual
    public virtual void Test()
    {
        Console.WriteLine("Implementasi KelasDasar.Test()");
    }
}

class KelasTurunan: KelasDasar
{
    // akan menimpa data KelasDasar.bilangan
    new private int bilangan;

    public KelasTurunan(int i1, int i2) : base(i1)
    {
        // akan mengisi nilai ke KelasTurunan.bilangan
        bilangan = i2;
    }

    public void CetakData()
    {
        Console.WriteLine("KelasDasar.bilangan \t: " + base.bilangan);
        Console.WriteLine("KelasTurunan.bilangan \t: " + bilangan); // bisa ditulis this.bilangan
    }

    // Melakukan override terhadap metode KelasDasar.Test()
    public override void Test()
    {
        base.Test();
        Console.WriteLine("Implementasi baru di dalam KelasTurunan.Test()");
    }
}


// POLIMORFISME
class Manusia
{
    private string name;

    public Manusia(string name)
    {
        this.name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine("Nama \t\t: "+this.name);
    }
}

class Tentara : Manusia
{
    private string jabatan;

    public Tentara(string name, string jabatan) : base(name)
    {
        this.jabatan = jabatan;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Jabatan Tentara : " + this.jabatan);
    }
}

class Polisi : Manusia
{
    private string jabatan;

    public Polisi(string name, string jabatan) : base(name)
    {
        this.jabatan = jabatan;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Jabatan Polisi \t: " + this.jabatan);
    }

    public void Gaji()
    {
        Console.WriteLine("Banyak");
    }
}

namespace Bab8PewarisanDanPolimorfisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KelasTurunan kt = new KelasTurunan(100,200);
            kt.CetakData();
            kt.Test();

            // POLIMORFISME
            Manusia t = new Tentara("Mahmud", "Pangdam");
            t.Display();
            Manusia p = new Polisi("Budi", "Kapolda");
            p.Display();
            // tidak bisa karena manusia tidak punya punya method gaji
            // p.Gaji();
            // bisa untuk arraylist
            Manusia[] kumpulanPenjabat = new Manusia[4];
            kumpulanPenjabat[0] = t;
            kumpulanPenjabat[1] = p;
        }
    }
}
