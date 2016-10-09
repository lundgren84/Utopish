using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemporaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Databaseconnection db = new Databaseconnection();

            Console.WriteLine("tbl");
            string tbl = Console.ReadLine();
            Console.WriteLine("column");
            string column = Console.ReadLine();
            Console.WriteLine("value");
            string value = Console.ReadLine();

            db.CreateTableEntry(tbl, column, value);

        }
    }
}
