using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utopish_Space.DAL;

namespace Utopish_Space.Models
{
    public class Player
    {
        DBConnection connection = new DBConnection();
        internal void CreateNewPlayer(PlayerObject playerObject)
        {
            string query = $@"";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection.connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch { }
            finally { connection.Close(); }

        }
    }
}