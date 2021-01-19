using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım gelişticiri yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //for (int i = 1; i <= 10; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            // Array - diziler - pythonda liste deniyor

            string[] kurslar = new string[] { "Yazılım gelişticiri yetiştirme kampı", "Programlamaya başlangıç için temel kurs" , "Java","Python","c++"};
            //string[] kurslar = kurslariGetir(); // bu bir array veri kaynağından geliyor

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");




        }
    }

    
}
