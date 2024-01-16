using System;

namespace RecapDemo2
{
    public class CustomerManager
    {
        public ILogManager LogManager { get; set; }

        public void Add()
        {
            LogManager.Log();
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            LogManager.Log();
            Console.WriteLine("Customer Updated!");
        }

        public void Remove()
        {
            LogManager.Log();
            Console.WriteLine("Customer Removed!");
        }
    }
}