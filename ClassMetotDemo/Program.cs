using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Begüm";
            musteri1.LastName = "Ünal";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Begüm";
            musteri2.LastName = "Muşdal";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            int i = 1;
            foreach (var Musteri in musteriler)
            {
                
                Console.WriteLine(i+". müşteri: "+Musteri.FirstName+" "+Musteri.LastName);
                i += 1;
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);


        }
    }
}
