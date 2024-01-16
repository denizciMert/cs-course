using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer=new SqlServer();
            MySqlServer mySqlServer = new MySqlServer();
            OracleServer oracleServer = new OracleServer();
            DatabaseE databaseE = new DatabaseE();

            sqlServer.Add();
            mySqlServer.Update();
            oracleServer.Delete();
            databaseE.Add();

            Console.ReadLine();
        }
    }

    class DatabaseE
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default!");
        }

        public virtual void Update()
        {
            Console.WriteLine("Updated by Default!");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default!");
        }
    }

    class SqlServer : DatabaseE
    {
        public override void Add()
        {
            Console.WriteLine("Added by SQL Code!");
            //base.Add();
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted by SQL Code!");
            //base.Delete();
        }

        public override void Update()
        {
            Console.WriteLine("Updated by SQL Code!");
            //base.Update();
        }
    }

    class MySqlServer : DatabaseE
    {
        public override void Add()
        {
            Console.WriteLine("Added by MySQL Code!");
            //base.Add();
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted by MySQL Code!");
            //base.Delete();
        }

        public override void Update()
        {
            Console.WriteLine("Updated by MySQL Code!");
            //base.Update();
        }
    }

    class OracleServer : DatabaseE
    {
        public override void Add()
        {
            Console.WriteLine("Added by Oracle Code!");
            //base.Add();
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle Code!");
            //base.Delete();
        }

        public override void Update()
        {
            Console.WriteLine("Updated by Oracle Code!");
            //base.Update();
        }


    }

}
