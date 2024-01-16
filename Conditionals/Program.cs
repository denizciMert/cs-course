using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }

            var number2 = 30;
            Console.WriteLine(number2 >= 50 ? "Input is equal or bigger than 50" : "Input is smaller than 50");

            var number3 = 133;
            if (number3 > 31)
            {
                Console.WriteLine("Number is bigger than 31");
            }
            else if (number3 == 31)
            {
                Console.WriteLine("Number is 31");
            }
            else
            {
                Console.WriteLine("Number is samller than 31");
            }

            var number4 = 123;
            switch (number4)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 30:
                    Console.WriteLine("number is 30");
                    break;
                default:
                    Console.WriteLine("number is not 10 or 30");
                    break;
            }

            var number5 = 99.1;
            if (number5>=0&&number5<=100)
            {
                Console.WriteLine("Number is between 0 and 100");
            }
            else if (number5>100 && number5<=200)
            {
                Console.WriteLine("Number is between 101 and 200");
            }
            else if (number5<0 || number5>200)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.ReadLine();
        }
    }
}
