using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Mert";
            //string student2 = "Şeyma";
            //string student3 = "Azra";

            string[] students = new string[3];
            students[0] = "Mert";
            students[1] = "Şeyma";
            students[2] = "Azra";

            foreach (var student in students) 
            {
                Console.WriteLine(student);
            }

            string[] students2 = { "Mert", "Şeyma", "Azra" };
            
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Balıkesir"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("***********");
            }
            Console.ReadLine();
        }
    }
}
