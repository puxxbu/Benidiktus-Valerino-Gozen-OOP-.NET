using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Emoney
{
    public class Admin : User
    {
        public Admin(string nama, string role, int eMoney) : base(nama, role, eMoney) { }


        public void tambahUang(int uang, Customer customer)
        {
            customer.eMoney += uang;

            Console.WriteLine("Uang berhasil ditambahkan");
            Console.WriteLine($"{customer.nama} memiliki saldo {customer.eMoney}");
        }
    }
}
