using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAsosiasi
{
    class Program
    {
        static void Main(string[] args)
        {
			// membuat objek kartu
			Kartu kartu = new Kartu();

			// membuat objek Karyawan
			Karyawan karyawan = new Karyawan();
			karyawan.Nama = "Dina";
			karyawan.Status = true; // aktif

			// hubungan Association
			if (karyawan.Login(kartu))
			{
				Console.WriteLine("Data karyawan valid");
			}
			else
			{
				Console.WriteLine("Data karyawan tiddak valid");
			}
			Console.ReadKey();
        }
    }
}
