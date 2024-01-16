using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Customer Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Customer Removed!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Customer Updated!");
        }
    }
}
