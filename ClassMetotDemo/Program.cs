using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.FirstName = "Akira";
            musteri.LastName = "Kurosawa";
            musteri.Mail = "sevensamurai_akirakurosawa@gmail.com";
            musteri.Account = 0;
            musteri.Branch = "Yenimahalle";


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri);
            musteriManager.MusteriBilgileri(musteri);
            musteriManager.Sil(musteri);
            

            
        }
    }
}
