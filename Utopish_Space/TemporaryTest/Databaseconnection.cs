using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TemporaryTest
{
    class Databaseconnection
    {
        public SqlConnection connection = new SqlConnection();
        public void CreateTableEntry(string table, string column, string value)
        {
            string sql = $@"INSERT INTO {table} ({column}) VALUES ('{value}')";
        connection.ConnectionString = @"Data source=217.210.151.153,1433; Network Library=DBMSSOCN; Initial Catalog=KHProjectSpace; User ID = guest; Password=temppass22;";

            using (connection)
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

        }
    }
}
