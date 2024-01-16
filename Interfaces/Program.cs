using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //InterfacesExample();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Update();
                customerDal.Delete();
            }

            Console.ReadLine();
        }

        private static void InterfacesExample()
        {
            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("Customer Manager Oracle Test...");

            customerManager.Add(new OracleCustomerDal());
            customerManager.Update(new OracleCustomerDal());
            customerManager.Delete(new OracleCustomerDal());

            Console.WriteLine("Customer Manager SQL Test...");

            customerManager.Add(new SqlCustomerDal());
            customerManager.Delete(new SqlCustomerDal());
            customerManager.Update(new SqlCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();

            Customer customer0 = new Customer
            {
                Id = 00,
                Name = "CustomerTest",
                Address = "AddressTest"
            };

            Student student0 = new Student
            {
                Id = 00,
                Name = "StudentTest",
                Number = 001
            };

            Worker worker0 = new Worker
            {
                Id = 00,
                Name = "WorkerTest",
                Department = "Department Test"
            };

            Console.WriteLine("Test Begins...");
            personManager.Add(customer0);
            personManager.Add(student0);
            personManager.Add(worker0);
        }
    }


    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }

    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Number { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name+" Added!");
        }
    }
}
