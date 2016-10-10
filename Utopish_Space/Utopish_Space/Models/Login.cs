using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utopish_Space.DAL;

namespace Utopish_Space.Models
{
    public class Login
    {
        DBConnection connection = new DBConnection();

        internal int CheckEMail(string email)
        {
            connection.OpenLogin();
            string sql = "Select count(*) From Accounts Where FirstName = '" + email + "'";
            SqlCommand command = new SqlCommand(sql, connection.connection);
            int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();

            return temp;
        }

        internal void CreateNewAccount(AccountObject accountObject)
        {
            connection.OpenLogin();
            string query = "Insert into Accounts (Email,Hash,Salt,) values (@email,@hash,@salt)";
            SqlCommand command = new SqlCommand(query, connection.connection);
            command.Parameters.AddWithValue("@email", accountObject._email);
            command.Parameters.AddWithValue("@hash", accountObject._hash);
            command.Parameters.AddWithValue("@salt", accountObject._salt);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}