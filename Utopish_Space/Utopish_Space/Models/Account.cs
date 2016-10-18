using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utopish_Space.DAL;

namespace Utopish_Space.Models
{
    public class Account
    {
        DBConnection connection = new DBConnection();
        internal AccountStatus CheckAccountStatus(int accountID)
        {
            AccountStatus status = new AccountStatus();
            string query = $@"SELECT Status.AccountStatus as TheStatus From Accounts
                              INNER JOIN Status ON Status.StatusID = Accounts.StatusRefID
                              WHERE Accounts.AccountID = {accountID}";
            try
            {
                connection.OpenLogin();


                using(SqlCommand command = new SqlCommand(query, connection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        status = (AccountStatus)Enum.Parse(typeof(AccountStatus), reader["TheStatus"].ToString());
                    }
                }
            }
            catch { }
            finally { connection.Close(); }


            return status;
        }
    }
}