
namespace Encapsulation
{
    //Class Lingkaran dengan enaksulapsi

    public class Lingkaran
    {
        //private field untuk menyimpan nilai radius
        private double radius;

        //public property untuk mengakses radius
        public double Radius
        {
            get { return radius; }

            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih besar dari 0");
                }
            }
        }

        public double Luas()
        {
            return 3.14 * radius * radius;
        }

        public class Tabung
        {
            private Lingkaran lingkaran;
            private double tinggi;
            private double volume;

            public Tabung(double radius, double tinggi)
            {
                lingkaran = new Lingkaran();
                lingkaran.Radius = radius; // Menggunakan properi untuk mengatur radius lingkaran
                this.tinggi = tinggi;
                volume = lingkaran.Luas() * tinggi;
            }

            public void hitungVolume()
            {
                //double volume = lingkaran.Luas() * tinggi;  
                Console.WriteLine($"Volume tabung: {volume}");   
            }
        }

        static void Main(string[] args)
        {
            Tabung tabung1 = new Tabung(10, 7);

            tabung1.hitungVolume();
            try
            {
                Tabung tabung2 = new Tabung(-10, 7);

              
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

}