using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            
            string sentence = "My name is Mert Denizci";
            var Lenght=sentence.Length;
            var Clone = sentence.Clone();
            var EndsWith = sentence.EndsWith("X");
            var StarsWith=sentence.StartsWith("M");
            var IndexOf=sentence.IndexOf("Mert");
            var LastIndexOf = sentence.LastIndexOf("is");
            var Insert = sentence.Insert(0,"Hello, ");
            var SubString=sentence.Substring(11,4);
            var ToUpper=sentence.ToUpper();
            var ToLower=sentence.ToLower();
            var Replace = sentence.Replace(" ","-");
            var Remove=sentence.Remove(10,5);

            Console.WriteLine(Lenght);
            Console.WriteLine(Clone);
            Console.WriteLine(EndsWith);
            Console.WriteLine(StarsWith);
            Console.WriteLine(IndexOf);
            Console.WriteLine(LastIndexOf);
            Console.WriteLine(Insert);
            Console.WriteLine(SubString);
            Console.WriteLine(ToUpper);
            Console.WriteLine(ToLower);
            Console.WriteLine(Replace);
            Console.WriteLine(Remove);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string nameG = "Mert Denizci";
            string nameB = "Şeyma Baş";

            Console.WriteLine(nameG[0] + nameB[0]);

            foreach (var Chars in nameB)
            {
                Console.WriteLine(Chars);
            }

            string Sums = nameG + nameB;
            Console.WriteLine(Sums);

            Console.WriteLine(string.Format("{0} {1}", nameG, nameB));
        }
    }
}
