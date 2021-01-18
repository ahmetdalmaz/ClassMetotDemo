using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, Name = "Ahmet", SurName = "Dalmaz", City = "İstanbul", Email = "asdfg@hotmail.com" };
            Customer customer2 = new Customer { Id = 2, Name = "Can", SurName = "Akan", City = "Ankara", Email = "kmtkltk@hotmail.com" };
            Customer customer3 = new Customer { Id = 3, Name = "Ramiz", SurName = "Civelek", City = "İstanbul", Email = "ltkmtkmk@hotmail.com" };

            Customer[] customers = new Customer[] {customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("**************************MÜŞTERİ LİSTESİ*******************************");
            customerManager.List(customers);
            Console.WriteLine("*********************************************************");
            customerManager.Delete(customer2);


        }
    }
}
