﻿using System;
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
            string sql = "Select count(*) From Accounts Where Email = '" + email + "'";
            SqlCommand command = new SqlCommand(sql, connection.connection);
            int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();

            return temp;
        }

        internal void CreateNewAccount(AccountObject accountObject)
        {
            Security security = new Security();
            accountObject._statusRefID = CreateNewAccountStatus();
            connection.OpenLogin();
            string query = "Insert into Accounts (Email,Hash,Salt,StatusRefID) values (@email,@hash,@salt,@statusRefID)";
            SqlCommand command = new SqlCommand(query, connection.connection);
            command.Parameters.AddWithValue("@email", accountObject._email);
            command.Parameters.AddWithValue("@hash", accountObject._hash);
            command.Parameters.AddWithValue("@salt", accountObject._salt);
            command.Parameters.AddWithValue("@statusRefID", accountObject._statusRefID);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private int CreateNewAccountStatus()
        {
            Security security = new Security();
            var ActivationCode = security.CreateSalt(5);
            var AccountStatus = "Locked";
            var result = 0;
            string query = string.Empty;
            connection.OpenLogin();

            query = "Insert into Status (AccountStatus,ActivationCode) values (@AccountStatus,@ActivationCode)";
            using (SqlCommand command = new SqlCommand(query, connection.connection))
            {
                command.Parameters.AddWithValue("@AccountStatus", AccountStatus);
                command.Parameters.AddWithValue("@ActivationCode", ActivationCode);
                command.ExecuteNonQuery();
            }
            query = $@"SELECT StatusID FROM Status WHERE ActivationCode = '{ActivationCode}'";
            using (SqlCommand command = new SqlCommand(query, connection.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = int.Parse(reader["StatusID"].ToString());
                    }
                }
            }

            connection.Close();
            return result;
        }

        internal AccountObject AccountLogin(string email, string password)
        {
            Security security = new Security();
            AccountObject result = new AccountObject();
            int count = 0;
            var salt = GetSalt(email);
            var hash = security.GenerateSHA256Hash(password, salt); // Generate Hash

            try
            {
                connection.OpenLogin();
                string sql = "Select count(*) From Accounts Where Email = '" + email + "' AND Hash = '" + hash + "'";
                SqlCommand command = new SqlCommand(sql, connection.connection);
                count = Convert.ToInt32(command.ExecuteScalar().ToString());          
            }
            catch
            {
                
            }
            finally
            {
                connection.Close();
            }
            if (count == 1)
            {
                result = GetAccount(email, hash);
            }
            else
            {
                result = null;
            }

            return result;
        }

        private AccountObject GetAccount(string email, string hash)
        {
            AccountObject result = new AccountObject();

            try
            {
                connection.OpenLogin();
                string query = "Select * From Accounts Where Email = '" + email + "' AND Hash = '" + hash + "'";
                using(SqlCommand command = new SqlCommand(query, connection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result._accountID = int.Parse(reader["AccountID"].ToString());
                            result._email = reader["Email"].ToString();
                            result._registrationDate = DateTime.Parse(reader["RegistrationDate"].ToString());
                            result._statusRefID = int.Parse(reader["StatusRefID"].ToString());
                        }
                    }
                }
            }
            catch { }
            finally { connection.Close(); }

            return result;
        }

        private string GetSalt(string email)
        {
            string salt = string.Empty;
            connection.OpenLogin();
            string query = $@"SELECT * FROM Accounts WHERE Email ='{email}'";
            using (SqlCommand command = new SqlCommand(query, connection.connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    salt = reader["Salt"].ToString();
                }
            }
            connection.Close();
            return salt;
        }
    }
}