using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " " + musteri.LastName + " " + "eklendi");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " " + musteri.LastName + " " + "silindi");
        }
    }  
}
