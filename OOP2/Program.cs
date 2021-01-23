using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Engin
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345679";

            // Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "4356";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "53454366545";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
        }
    }
}
