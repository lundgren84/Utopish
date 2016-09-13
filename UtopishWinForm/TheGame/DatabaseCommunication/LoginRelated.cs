using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TheGame
{
    class LoginRelated
    {
        SqlConnection connection;

        public bool UniqueUsername(string name)
        {
            EstablishConnection();
            OpenConnection();
            string sql = "Select Name from UserID";
            var command = new SqlCommand(sql, connection);

            using (var datareader = command.ExecuteReader())
            {
                while (datareader.Read())
                {
                    string tempname = $"{datareader["Name"]}";

                    if (tempname.ToLower() == name.ToLower())
                        return false;
                }
            }
                return true;
        }
        public bool UniqueKingdomName(string kingdomName)
        {
            EstablishConnection();
            OpenConnection();
            string sql = "Select KingdomName from UserID";
            var command = new SqlCommand(sql, connection);

            using (var datareader = command.ExecuteReader())
            {
                while (datareader.Read())
                {
                    string tempname = $"{datareader["KingdomName"]}";

                    if (tempname.ToLower() == kingdomName.ToLower())
                        return false;
                }
            }
            return true;
        }
        public bool IsLocationOccupied(Location location)
        {
            EstablishConnection();
            OpenConnection();
            string sql = "Select * from UserLocation";
            var command = new SqlCommand(sql, connection);

            using (var datareader = command.ExecuteReader())
            {
                while (datareader.Read())
                {
                    if (location.island == Convert.ToInt32(datareader["Island"]) && location.kingdomNumber == Convert.ToInt32(datareader["KingdomNumber"]))
                        return true;
                         
                }
            }
            return false;
        }
        public static List<Location> GetGameWorld()
        {
            return new List<Location>();
        }
        private void EstablishConnection()
        {
            connection.ConnectionString = @"Data source=217.210.151.153,1433; Network Library=DBMSSOCN; Initial Catalog=servername; User ID = username; Password=password;";
        }
        private void OpenConnection()
        {
            connection.Open();
        }
        private void CloseConnection()
        {
            connection.Close();
        }
    }
}
