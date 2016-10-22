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
            string query = $@"INSERT INTO Players(PlayerAccountNumber,EmpireName, TradeBalance, Strength,[Level],Experience,DailyTradesLeft,DonatorStatus,RaceRefID)
            VALUES({playerObject.AccountID}, '{playerObject.EmpireName}', {playerObject.TradeBalance},{playerObject.Strength},{playerObject.Level},{playerObject.Experience},{playerObject.DailyTradesLeft},'{playerObject.DonatorStatus}',{playerObject.RaceObject.RaceID})";

           
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection.connection))
                {
                command.ExecuteNonQuery();
                }
            
       
          connection.Close(); 

        }

        internal PlayerObject GetPlayerObject(AccountObject account)
        {
            PlayerObject playerObject = new PlayerObject();
            playerObject.AccountID = account._accountID;
            string query = $@"SELECT * FROM Players
                           WHERE Players.PlayerAccountNumber = {account._accountID}";
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) { 
                    playerObject.PlayerID = int.Parse(reader["PlayerID"].ToString());
                    playerObject.EmpireName = reader["EmpireName"].ToString();
                    playerObject.TradeBalance = int.Parse(reader["TradeBalance"].ToString());
                    playerObject.Strength = int.Parse(reader["Strength"].ToString());
                    playerObject.Level = int.Parse(reader["Level"].ToString());
                    playerObject.Experience = int.Parse(reader["Experience"].ToString());
                    playerObject.DailyTradesLeft = int.Parse(reader["DailyTradesLeft"].ToString());
                    playerObject.DonatorStatus = bool.Parse(reader["DonatorStatus"].ToString());
                    playerObject.RaceID = int.Parse(reader["RaceRefID"].ToString());
                    }
                }
            }


                connection.Close();

            return playerObject;
        }
    }
}