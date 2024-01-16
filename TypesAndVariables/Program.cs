using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2147483647;
            Console.WriteLine("Number1 is integer: {0}", number1);

            long number2 = 9223372036854775807;
            Console.WriteLine("Number2 is long: {0}", number2);

            short number3 = 32767;
            Console.WriteLine("Number3 is short: {0}", number3);

            byte number4 = 255;
            Console.WriteLine("Number4 is byte: {0}", number4);

            double number5 = 1.18641354984135198435198436519847351;
            Console.WriteLine("Number5 is double: {0}", number5);

            decimal number6 = 1.18641354984135198435198436519847351m;
            Console.WriteLine("Number6 is decimal: {0}", number6);

            var number7 = 10;
            Console.WriteLine("Number7 is var: {0}", number7);

            string name = "Mert";
            Console.WriteLine("This is string: {0}", name);

            bool condition = true;
            Console.WriteLine("This is bool: {0}", condition);

            char character = 'a';
            Console.WriteLine("This is char: {0}", character);

            Console.ReadLine();
        }
    }
}
