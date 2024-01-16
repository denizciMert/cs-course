using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Result=Add(12);
            Console.WriteLine("Added! Your Result Is: " + Result);

            int numberx = 10;
            int numbery = 10;
            var resultz = refAdd(ref numberx, ref numbery);

            Console.WriteLine("Added! Your Result Is: " + resultz);
            Console.WriteLine(numberx);

            int numberoutx;
            int numberouty;
            var resultoutz = outAdd(out numberoutx,out numberouty);

            Console.WriteLine("Added! Your Result Is: " + resultoutz);
            Console.WriteLine(numberoutx);

            Console.WriteLine(multiply(1,2,3));

            Console.WriteLine(paramsAdd(1,2,3,4,5,6,7,8,9,0,11,1,2,13,131,313));

            Console.ReadLine();
        }

        static int Add(int Number1 = 0, int Number2 = 0)
        {
            var Result= Number1 + Number2;
            return Result;
        }

        static int refAdd(ref int numberx, ref int numbery)
        {
            numberx = 11;
            return numberx + numbery;
        }

        static int outAdd(out int numberoutx, out int numberouty)
        {
            numberoutx = 121;
            numberouty = 211;
            return numberoutx + numberouty;
        }

        static int multiply(int Number1, int Number2)
        {
            return Number1 * Number2;
        }

        static int multiply(int Number1, int Number2, int Number3)
        {
            return Number1 * Number2 * Number3;
        }

        static int paramsAdd(params int[] Numbers)
        {
            return Numbers.Sum();

        }
    }
}
