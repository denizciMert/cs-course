using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPerson[] persons = new IPerson[2]
            {
                new Workers.Worker(),
                new Workers.Manager()
            };

            foreach (var person in persons)
            {
                person.Eat();
                person.GetSalary();
            }

            IWorker[] workers = new IWorker[3]
            {
                new Workers.Worker(),
                new Workers.Manager(),
                new Workers.Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            Console.ReadLine();
        }
    }
}
