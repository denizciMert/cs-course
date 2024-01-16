using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoop(10);

            WhileLoop(10);

            DoWhileLoop(10);

            ForEachLoop(new []{"Mert", "Şeyma"});

            Console.ReadLine();
        }

        private static void ForEachLoop(string[] arrayForForeach)
        {
            foreach (var person in arrayForForeach)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("End of foreach loop!");
        }

        private static void DoWhileLoop(int numberForDoWhile=0)
        {
            do
            {
                Console.WriteLine(numberForDoWhile);
                numberForDoWhile--;
            } while (numberForDoWhile >= 0);

            Console.WriteLine("End of doWhile loop!");
        }

        private static void WhileLoop(int numberForWhile=0)
        {
            
            while (numberForWhile >= 0)
            {
                Console.WriteLine(numberForWhile);
                numberForWhile--;
            }
            Console.WriteLine("End of while loop!");

        }


        private static void ForLoop(int numberForFor = 0)
        {
            for (int i=numberForFor;numberForFor >=0; numberForFor--)
            {
                Console.WriteLine(numberForFor);
            }
            Console.WriteLine("End of for loop!");
        }
    }
}
