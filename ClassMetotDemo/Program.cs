using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Akira";
            customer.LastName = "Kurosawa";
            customer.Mail = "sevensamurai_akirakurosawa@gmail.com";
            customer.Account = 0;
            customer.Branch = "Yenimahalle";


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer);
            customerManager.InformationOfCustomer(customer);
            customerManager.Delete(customer);
            

            
        }
    }
}
