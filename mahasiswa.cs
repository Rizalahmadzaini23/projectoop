﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan2
{
    public class mahasiswa
    {
        //propeties
        public string Nim { get; set; }
        public string Nama { get; set;  }
        public float Ipk { get; set;  }

        //method
        public void Registrasi()
        {
            Console.WriteLine("Nama: {0}", Nama);
            Console.WriteLine("NIM: {0}", Nim);
            Console.WriteLine("IPK: {0}", Ipk);
            Console.WriteLine("Telah melakukan registrasi");
        }
        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses krs\n", Nama);
        }
    }
}
