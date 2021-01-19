using System;

namespace RefOutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // "ref" keyword için örnek
            double pi = 3.14;
            Console.WriteLine(pi);

            DaireCevreHesapla(ref pi, 2);  // method çalıştırılınca bundan sonra pi değer artık 3 olacaktır.
            Console.WriteLine(pi);

            // "out" keyword için örnek
            string deger;

            // dışarıdan yıl bilgisi otomatik olarak gelecek olursa 2020 yılı için deger "usd" olacak
            Console.WriteLine("Maaşınız 3000 " + YeniDeger(2020, out deger));
            Console.WriteLine(deger);
            Console.WriteLine("Maaşınız 3000 " + YeniDeger(2021, out deger));
            Console.WriteLine(deger);

        }


        static double DaireCevreHesapla(ref double pi, int r)
        {
            pi = 3;
            return 2 * pi * r;
        }

        static string YeniDeger(int year, out string symbol)
        {
            if (year == 2020)
            {
                symbol = "USD";
            }
            else
            {
                symbol = "EU";
            }


            return symbol;
        }


    }
}

