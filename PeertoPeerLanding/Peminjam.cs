using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeertoPeerLanding
{

    public class Peminjam : User
    {
        public Peminjam(string nama) : base(nama)
        {
            this.nama = nama;
        }

        public void pinjamUang(double uang, Pemodal pemodal )
        {
            var saldo = pemodal.GetSaldo();
             saldo -= uang;
            Console.WriteLine($"Saldo {pemodal.nama} Berkurang {Rupiah.ToRupiah(uang)}");
            Console.WriteLine($"Saldo {pemodal.nama} :  {Rupiah.ToRupiah(saldo)}");
            Console.WriteLine($"{pemodal.nama} meminjamkan anda pada {DateTime.Now.ToString("h:mm:ss dd/mm/yyyy")}  {Rupiah.ToRupiah(uang)}");
            ShowBunga(uang);

        }

        public void ShowBunga(double uang)
        {
            double cicilan = 0.025 * uang / (1 - Math.Pow((1 + 0.025), (-12)));
            //double cicilan = uang * 0.025 / 0.2585;
            double totalPembayaran = cicilan * 12;


            Console.WriteLine("");
            Console.WriteLine("Cicilan selama 12 bulan dengan bunga 2.5% per bulan:");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Pembayaran {i} : {Rupiah.ToRupiah(cicilan)}");
            }
            Console.WriteLine($"Total Pembayaran : {Rupiah.ToRupiah(totalPembayaran)}");
        }

    }
}
