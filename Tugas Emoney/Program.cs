using System;

namespace TugasEmoney
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


    public class Customer : User
    {
        public Customer(string nama, string role, int eMoney) : base(nama, role, eMoney)
        {}


        public void lihatUang()
        {
            Console.WriteLine($"Saldo Anda {this.eMoney}");
        }
    }


    public class main
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Mulyono", "Admin", 100000);
            Customer pablo = new Customer("Pablo", "Customer", 100000);
            Customer santoso = new Customer("Santoso", "Customer", 200000);

            do
            {
                Console.WriteLine("Masukan Role Anda (Admin/Customer):");
                string role = Console.ReadLine();
                

                switch (role)
                {
                    case "Admin":
                        Console.WriteLine("Pilih Customer (Pablo/Santoso)");
                        string nama = Console.ReadLine();

                        if(nama == "Santoso")
                        {
                            Console.WriteLine("Masukan jumlah uang yang ingin ditambahkan:");
                            int uang = Convert.ToInt32(Console.ReadLine());
                            admin.tambahUang(uang, santoso);
                            break;
                           
                        }
                        else if (nama == "Pablo")
                        {
                            Console.WriteLine("Masukan jumlah uang yang ingin ditambahkan:");
                            int uang = Convert.ToInt32(Console.ReadLine());
                            admin.tambahUang(uang, pablo);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Customer tidak ditemukan");
                            break;
                        }

                        
                    case "Customer":

                        Console.WriteLine("Masukan nama customer :");
                        string customer = Console.ReadLine();
                        if (customer == "Santoso")
                        {
                            santoso.lihatUang();
                            break;

                        }
                        else if (customer == "Pablo")
                        {
                            pablo.lihatUang();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Customer tidak ditemukan");
                            break;
                        }

                    default:
                        Console.WriteLine("Role tidak ditemukan");
                        break;
                }
            }
            while (true);
        }
    }

}