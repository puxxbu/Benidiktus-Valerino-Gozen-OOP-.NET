using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeertoPeerLanding
{
     public class User
    {
        public string nama { get; set; }
        protected double saldo;

        public User(string nama )
        {
            saldo = 0;
        }
        public double GetSaldo()
        {
            return saldo;
        }

        public double SetSaldo(double saldo)
        {
            return this.saldo = saldo;
        }
    }
}
