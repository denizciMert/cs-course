using System;

namespace InterfacesDemo
{
    public class Workers
    {
        public class Manager : IWorker, IPerson
        {
            public void Eat()
            {
                Console.WriteLine("Managers Do Eat.");
            }

            public void GetSalary()
            {
                Console.WriteLine("Managers Get Salary.");
            }

            public void Work()
            {
                Console.WriteLine("Managers Do Work.");
            }
        }

        public class Worker : IWorker, IPerson
        {
            public void Eat()
            {
                Console.WriteLine("Workers Do Eat.");
            }

            public void GetSalary()
            {
                Console.WriteLine("Workers Get Salary.");
            }

            public void Work()
            {
                Console.WriteLine("Workers Do Work.");
            }
        }

        public class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robots Do Work.");
            }
        }
    }
}