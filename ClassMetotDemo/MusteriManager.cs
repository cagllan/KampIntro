using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri eklendi : " + musteri.FirstName + " " + musteri.LastName);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.FirstName + " " + musteri.LastName);
        }

        public void MusteriBilgileri(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri:");
            Console.WriteLine("---------------------");
            Console.WriteLine("Id: " + musteri.Id);
            Console.WriteLine("Ad: " + musteri.FirstName);
            Console.WriteLine("Soyad: " + musteri.LastName);
            Console.WriteLine("Email: " + musteri.Mail);
            Console.WriteLine("Bakiye: " + musteri.Account);
            Console.WriteLine("Şube: " + musteri.Branch);
            Console.WriteLine("---------------------");
        }
    }
}
