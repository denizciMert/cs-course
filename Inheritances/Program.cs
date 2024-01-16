using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person() { Id = 1, Name = "Mert" },
                new Customer() { Id = 2, Name = "Şeyma", City = "Zonguldak" },
                new Student() { Id = 3, Name = "Azra", Number = 123 }
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Customer:Person
        {
            public string City { get; set; }
        }

        class Student:Person
        {
            public int Number { get; set; }
        }
    }
}
