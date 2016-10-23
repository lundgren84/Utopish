using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utopish_Space.DAL;

namespace Utopish_Space.Models
{
    public class Troop : IDisposable
    {
        DBConnection connection = new DBConnection();
        public void Dispose()
        {
            this.connection.Close();
            this.connection = null;
        }

        internal List<TroopObject> GetAllTroops()
        {
            List<TroopObject> resultList = new List<TroopObject>();
            string query = $@"SELECT * FROM Troops";

            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TroopObject newTroop = new TroopObject();
                        newTroop.TroopID = int.Parse(reader["TroopsID"].ToString());
                        newTroop.TroopName = reader["TroopName"].ToString();
                        resultList.Add(newTroop);
                    }
                }

            }         

            return resultList;
        }
    }
}