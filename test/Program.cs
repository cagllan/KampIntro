using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Deneme deneme = new Deneme();
            new Urun();
        }
    }

    class Urun
    {
        public Urun()
        {
            Console.WriteLine("asd");
            Console.WriteLine("urun oluştu");
        }
    }

    class Deneme
    {
        public void Add(Urun urun)
        {
            
        }
    }
}
