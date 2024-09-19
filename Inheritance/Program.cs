using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    //Parent class
    public class Lingkaran
    {
        double luas;
        // Method untuk menghitung luas

        public int LuasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return  (int)luas;
        }

    }

    public class Tabung : Lingkaran
    {
        double volume;
        public Tabung(int tinggi, double r)
        {
            volume = tinggi * this.LuasLingkaran(r);
        }

        public double getVolume()
        {
            return volume;
        }

        static void Main(string[] args)
        {
            Tabung tabung1 = new Tabung(10, 7);
            Console.WriteLine($"Volume tabung: {tabung1.getVolume()}");

        }
    }


    
}