using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Utopish_Space.DAL
{
    public class DBConnection
    {
        public SqlConnection connection = new SqlConnection();
        private string connectionString = "@Data source = 217.210.151.153,1433; Network Library = DBMSSOCN; Initial Catalog = ProjectSpace; User ID = guest; Password=temppass22";
        private string connectionStringLogin = "@Data source = 217.210.151.153,1433; Network Library = DBMSSOCN; Initial Catalog = ProjectSpaceUserDataBase; User ID = guest; Password=temppass22";

        public void Open()
        {
            connection.ConnectionString = connectionString;
            connection.Open();
        }
        public void OpenLogin()
        {
            connection.ConnectionString = connectionStringLogin;
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
    }
}