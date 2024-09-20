namespace PeertoPeerLanding
{
    class main 
    {
        static void Main(string[] args)
        {
            int menu = 1;
            int index = -1;
            string nama = null;
            double saldo = 0;
            int jumlahPemodal = 0;

            Peminjam peminjam = new Peminjam("Beban");
            List<Pemodal> pemodal = new List<Pemodal>();

            while (menu != 0)
            {
                Console.Clear();
                //Console.WriteLine(")
                System.Console.WriteLine("Selamat Datang di Peer-to-peer Lending");
                Console.WriteLine("=====[ Menu ]=====");
                Console.WriteLine("1. Pinjam Uang");
                Console.WriteLine("2. Beri MOdal");
                Console.WriteLine("0. Keluar");
                Console.WriteLine("Pilih Menu 1, 2 atau 0");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                   

                    case 1:
                        while(saldo <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Anda memilih menjadi peminjam");
                            Console.WriteLine("Masukkan jumlah uang yang ingin dipinjam");
                            Console.Write("> ");
                            saldo = Convert.ToDouble(Console.ReadLine());

                            if (saldo <= 0)
                            {
                                Console.WriteLine("Uang Tidak boleh kurang dari 0");
                                Console.ReadLine();
                            }

                            while (index < 0)
                            {
                                Console.Clear();
                                for(int i = 0; i < pemodal.Count(); i++)
                                {
                                    if (pemodal[i].getSaldo() >= saldo)
                                    {
                                        Console.WriteLine(i + 1 + " - " + pemodal[i].nama + " - " + Rupiah.ToRupiah(pemodal[i].GetSaldo()));
                                        jumlahPemodal++;
                                    }
                                }

                                if(jumlahPemodal == 0)
                                {
                                    Console.WriteLine("Tidak ada pemodal!!1");
                                    Console.ReadLine();
                                    index = pemodal.Count();
                                }

                                if(index != pemodal.Count())
                                {
                                    Console.WriteLine("Pilih peminjam");
                                    Console.Write("> ");
                                    index = Convert.ToInt32(Console.ReadLine());
                                }

                                if (index <= 0 || index > pemodal.Count())
                                {
                                    Console.WriteLine("Peminjam Tidak ADa");
                                    Console.ReadLine();
                                }
                            }

                            while (saldo <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Masukkan jumlah uang yang ingin dipinjam");
                                Console.Write("> ");
                                saldo = Convert.ToDouble(Console.ReadLine());

                                if (saldo <= 0)
                                {
                                    Console.WriteLine("Uang Tidak boleh kurang dari 0");
                                    Console.ReadLine();
                                }
                            }

                            if(jumlahPemodal != 0)
                            {
                                Console.WriteLine("Anda telah meminjam uang sebesar " + Rupiah.ToRupiah(saldo) + " dari " + pemodal[index - 1].nama);

                                peminjam.pinjamUang(saldo, pemodal[index - 1]);

                                Console.ReadLine();
                            }
                            index = -1;
                            jumlahPemodal = 0;
                            
                        }
                            saldo = 0;

                    break;
                    case 2:
                        while (nama == null)
                        {
                            Console.Clear();
                            Console.WriteLine("Anda memilih menjadi pemodal");
                            Console.WriteLine("Masukkan nama anda");
                            Console.Write("> ");
                            nama = Console.ReadLine();

                            if (nama == null)
                            {
                                Console.WriteLine("Nama tidak boleh kosong");
                                Console.ReadLine();
                            }
                        }
                        while (saldo <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Masukkan jumlah uang yang ingin dipinjamkan");
                            Console.Write("> ");
                            saldo = Convert.ToDouble(Console.ReadLine());

                            if (saldo <= 0)
                            {
                                Console.WriteLine("Uang Tidak boleh kurang dari 0");
                                Console.ReadLine();
                            }
                        }
                        pemodal.Add(new Pemodal(nama));
                        pemodal[pemodal.Count - 1].tambahSaldo(saldo);
                        Console.WriteLine("Berhasil menambah saldo sebanyak " + Rupiah.ToRupiah(saldo));
                        Console.WriteLine("Total saldo " + pemodal[pemodal.Count - 1].nama + " : " + Rupiah.ToRupiah(pemodal[pemodal.Count - 1].getSaldo()) );
                        saldo = 0;
                        nama = null;
                        Console.ReadLine();

                        break;

                    case 0:
                        menu = 0;
                        break;

                    default:
                        Console.WriteLine("Menu Tidak Ada !!");
                        break; 
                }

            }
            
        }

    }
}