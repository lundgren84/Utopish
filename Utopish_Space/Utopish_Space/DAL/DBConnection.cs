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
        private string connectionString = "Data Source = (local); Network Library = DBMSSOCN; Initial Catalog = ProjectSpace; User ID = {User name} ; password = {Password}; integrated Security = true";
        private string connectionStringLogin = "Data Source = (local); Network Library = DBMSSOCN; Initial Catalog = ProjectSpaceUserDataBase; User ID = {User name} ; password = {Password}; integrated Security = true";

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