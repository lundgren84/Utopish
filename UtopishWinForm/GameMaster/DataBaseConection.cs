using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaster
{
    class DataBaseConection
    {
        private SqlConnection connection = null;

  //"Data Source = (local);Initial Catalog = {DataBaseName}; User ID ={UserName}; password = {password}; integrated Security = true" 
        public void OpenConnection(string connectionString)
        {
            connection = new SqlConnection { ConnectionString = connectionString };
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
            connection.Dispose();
        }

        public void FillsoldierStats()
        {
      
            string sql = @"Insert into  Archers (Quantity , Cost) Values('" + 0 + "','" + 100 + "','" + 100 + "','" + 100 + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
               
            }
        
    }
    }
}
