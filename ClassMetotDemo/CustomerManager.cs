using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("Müşteri Eklendi : {0} {1}",customer.Name,customer.SurName);
        
        }

        public void List(Customer[] customers) 
        {
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("Ad: {0}, Soyad: {1}, Email: {2}, Şehir: {3}",customers[i].Name, customers[i].SurName, customers[i].Email, customers[i].City);                  
            }
        
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : {0} {1}", customer.Name, customer.SurName);
        }

    }
}
