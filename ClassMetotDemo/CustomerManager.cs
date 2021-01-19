using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine("Yeni Müşteri eklendi : " + customer.FirstName + " " + customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi: " + customer.FirstName + " " + customer.LastName);
        }

        public void InformationOfCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri bilgileri:");
            Console.WriteLine("---------------------");
            Console.WriteLine("Id: " + customer.Id);
            Console.WriteLine("Ad: " + customer.FirstName);
            Console.WriteLine("Soyad: " + customer.LastName);
            Console.WriteLine("Email: " + customer.Mail);
            Console.WriteLine("Bakiye: " + customer.Account);
            Console.WriteLine("Şube: " + customer.Branch);
        }
    }
}
