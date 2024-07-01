using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        Mahasiswa[] mahasiswaArr = new Mahasiswa[3];

        mahasiswaArr[0] = new Mahasiswa(1234, "Erik", 75);
        mahasiswaArr[1] = new Mahasiswa(1235, "Wely", 80);
        mahasiswaArr[2] = new Mahasiswa(1236, "Sony", 95);

        Console.WriteLine("No.\tNim\tNama\tNilai");
        Console.WriteLine("==============================");

        int nomor = 1;
        foreach (var mahasiswa in mahasiswaArr)
        {
            mahasiswa.cetakData(nomor);
            nomor++;
        }
    }
}


