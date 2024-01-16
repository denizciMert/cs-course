using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            customerManager.Remove();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            productManager.Remove();

            Customer customer1 = new Customer();
            customer1.Name = "Mert Denizci";
            customer1.Address = "Bakırköy";
            customer1.City = "İstanbul";
            customer1.Country = "Türkiye";
            customer1.Phone = "123123123";
            customer1.Region = "EU";
            customer1.Id = 1;

            Customer customer2 = new Customer
            {
                Address = "Yeni Mahalle", City = "Zonguldak", Country = "Türkiye", Id = 2 , Region ="EU", Name = "Şeyma Baş", Phone = "123123123"
            };

            Console.WriteLine(customer1.Name);
            Console.WriteLine(customer2.Name);

            Console.ReadLine();
        }
    }
}
