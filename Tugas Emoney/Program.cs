using System;

namespace Tugas_Emoney
{





   
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