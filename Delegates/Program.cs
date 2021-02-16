using System;
using System.Threading;

namespace Delegates
{
    class Program
    {
        // void olan ve parametre almayanlar için
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int number1, int number2);
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            //myDelegate();
            myDelegate += customerManager.ShowAlert;
            //myDelegate();

            myDelegate -= customerManager.SendMessage;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            //return type olduğu için en son değer döndürülür
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);
            Console.ReadLine();

            Action action;
            Func<int, int, int> add = matematik.Topla;

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber());

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber());

        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Carefull");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
