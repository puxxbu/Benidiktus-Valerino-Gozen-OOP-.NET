using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Emoney
{
    public class User
    {
        public string nama;
        public string role;
        public int eMoney;


        public User(string nama, string role, int eMoney)
        {
            this.nama = nama;
            this.role = role;
            this.eMoney = eMoney;
        }

    }



}
