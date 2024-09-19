using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Emoney
{
    public class Customer : User
    {
        public Customer(string nama, string role, int eMoney) : base(nama, role, eMoney)
        { }


        public void lihatUang()
        {
            Console.WriteLine($"Saldo Anda {this.eMoney}");
        }
    }


}
