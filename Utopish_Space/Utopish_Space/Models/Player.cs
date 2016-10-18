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
            string query = $@"INSERT INTO Players(PlayerAccountNumber,EmpireName, TradeBalance, Strength,Level,Experience,DonatorStatus,RaceRefID)
            VALUES({playerObject.AccountID}, {playerObject.EmpireName}, {playerObject.TradeBalance},{playerObject.Strength},{playerObject.Level},{playerObject.Experience},{playerObject.DonatorStatus},{playerObject.RaceObject.RaceID})";

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