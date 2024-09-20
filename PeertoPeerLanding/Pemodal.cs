using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeertoPeerLanding
{

    public class Pemodal : User
    {
        public Pemodal(string nama) : base(nama)
        {
            this.nama = nama;
        }

        public void tambahSaldo(double saldo)
        {
            this.saldo += saldo;
            Console.WriteLine($"Saldo {nama} : {this.saldo}");
        }


        public double getSaldo()
        {
            return saldo;
        }

        //public void pinjamUang(double uang, )
        //{
        //    saldo -= uang;
        //    Console.WriteLine($"Saldo Berkurang Rp.{Rupiah.ToRupiah(saldo)}");
        //    Console.WriteLine($"Saldo {nama} :  Rp.{Rupiah.ToRupiah(saldo)}");
        //}

        //public void bayarUang(double uang)
        //{
        //    saldo -= uang;
        //    Console.WriteLine($"Saldo {nama} : {saldo}");
        //}

    }
}
