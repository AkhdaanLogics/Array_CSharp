using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

public class Mahasiswa
{
    public string Nama { get; set; }
    public int Nim { get; set; }
    public int Nilai { get; set; }

    // Constructor
    public Mahasiswa(int nim, string nama, int nilai)
    {
        Nim = nim;
        Nama = nama;
        Nilai = nilai;
    }

    // Method untuk mencetak informasi mahasiswa
    public void cetakData(int nomor)
    {
        Console.WriteLine(nomor + "\t" + Nim + "\t" + Nama + "\t" + Nilai + "\t");
    }
}

