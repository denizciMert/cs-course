using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class SqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Customer Added!");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Customer Removed!");
        }

        public void Update()
        {
            Console.WriteLine("SQL Customer Updated!");
        }
    }
}
