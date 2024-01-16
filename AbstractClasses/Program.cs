using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseEx[] databaseExes = new DatabaseEx[2]
            {
                new OracleServer(),
                new SqlServer()
            };

            foreach (var databaseEx in databaseExes)
            {
                databaseEx.Add();
                databaseEx.Delete();
            }

            DatabaseEx database1 = new OracleServer();
            DatabaseEx database2 = new SqlServer();

            database1.Add();
            database2.Add();
            database1.Delete();
            database2.Delete();

            Console.ReadLine();
        }
    }

    abstract class DatabaseEx
    {
        public void Add()
        {
            Console.WriteLine("Added By Default");
        }

        public abstract void Delete();
    }

    class SqlServer:DatabaseEx
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted By SQL");
        }
    }

    class OracleServer:DatabaseEx
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted By Oracle");
        }
    }
}
