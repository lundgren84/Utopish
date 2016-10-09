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
            bool tool = true;
            do
            {
                Console.WriteLine("tbl");
                string tbl = Console.ReadLine();
                Console.WriteLine("column");
                string column = Console.ReadLine();
                do
                {

                    Console.WriteLine("value");
                    string value = Console.ReadLine();
                    if (tbl == "quit" || column == "quit" || value == "quit")
                        tool = false;
                    else
                        db.CreateTableEntry(tbl, column, value);
                } while (tool);

            } while (tool);

        }
    }
}
