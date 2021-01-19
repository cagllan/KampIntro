using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety - tip güvenliği
            //Do not repeat yourself - kendini tekrarlama
            // değer tutucu - alias

            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            // bool sistemeGirisYapmisMi = sistemeGirisYapmisMiBiBak();

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            

            Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
           
        }
    }
}
