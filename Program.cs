using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan2
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class mahasiswa
            mahasiswa saya = new mahasiswa();
            mahasiswa kamu = new mahasiswa();

            //mengeset nilai properties objek saya dan kamu
            saya.Nim = "18.11.0000";
            saya.Nama = "jomblo";
            saya.Ipk = 3.76f;

            kamu.Nim = "18.11.1111";
            kamu.Nama = "bucin";
            kamu.Ipk = 3.98f;

            //memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
