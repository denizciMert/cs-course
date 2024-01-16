using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPrimeNumber(9973);
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int numberForPrimeCheck=1)
        {
            bool resultOfPrimeCheck= true;
            if (numberForPrimeCheck > 1)
            {
                for (int i= 2 ;i <numberForPrimeCheck;i++)
                {
                    if (numberForPrimeCheck%i==0)
                    {
                        resultOfPrimeCheck = false;
                        break;
                    }
                }

                if (resultOfPrimeCheck==true)
                {
                    Console.WriteLine("Given Input: " + numberForPrimeCheck + " Is a Prime Number!");
                }
                else
                {
                    Console.WriteLine("Given Input: " + numberForPrimeCheck + " Is Not a Prime Number!");
                }

            }else{
                Console.WriteLine("Invalid Input! Input Must Be Greater Than 1.");
            }
            return resultOfPrimeCheck;
            
        }
    }
}
