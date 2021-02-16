using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(2, 5));

            var tip = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,10,20);
            //Console.WriteLine(dortIslem.Topla(5, 6));
            //Console.WriteLine(dortIslem.Topla2());

            //calisma anında olusturuluyor
            var instance = (DortIslem)Activator.CreateInstance(tip, 10, 20);

            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            // aslında instance ile olan bağ kaybediliyor.
            //tekrardan instance yazıp hangi örneğin topla2 sini çalıştıracağımızı söylüyoruz.
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));


            Console.WriteLine("----------------------------------------");
            var methodlar = tip.GetMethods();

            foreach (var info in methodlar)
            {
                Console.WriteLine("Method adı : {0}", info.Name);
                foreach (var parametreInfo in info.GetParameters())
                {
                    Console.WriteLine("--Parametre : {0}", parametreInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("--Attribute Name : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        int _sayi1;
        int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }

        
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}
