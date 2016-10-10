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
        private string connectionString = "";
        private string connectionStringLogin = "";

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
    }
}