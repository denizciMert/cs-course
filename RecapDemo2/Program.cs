using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.LogManager = new LogTypes.DatabaseLogM();
            
            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.LogManager = new LogTypes.FileLogM();
            
            CustomerManager customerManager3= new CustomerManager();
            customerManager3.LogManager = new LogTypes.SmsLogM();
            
            customerManager1.Add();
            customerManager2.Update();
            customerManager3.Remove();

            Console.ReadLine();
        }
    }
}
