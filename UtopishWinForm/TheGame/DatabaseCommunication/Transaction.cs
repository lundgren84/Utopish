using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TheGame
{
    class Transaction
    {
        string type;
        int quantity;
        int pricePerUnit;
        SqlConnection connection;

       public int CalculateTotalCostOfTransaction(List<Transaction> transactions, Player player)
        {
            int total = 0;
            foreach (var item in transactions)
            {


                total += item.pricePerUnit * item.quantity;
            }
            return total;
        }
        public bool CanYouAffordTraining(ArmyUnit unit, int amount, Player player)
        {

            string sql = "Select * from Player";
            var command = new SqlCommand(sql, connection);

            using (var datareader = command.ExecuteReader())
            {
                while (datareader.Read())
                {
                    if (Convert.ToInt32(datareader["UserID"]) == player.playerId)
                    {
                        if (unit.cost * amount < Convert.ToInt32(datareader["Money"]))
                        return true;
                    }

                }
            }
            return false;
        }
        public bool CanYouAffordBuilding(Buildings building, int amount, Player player)
        {

            string sql = "Select * from Player";
            var command = new SqlCommand(sql, connection);

            using (var datareader = command.ExecuteReader())
            {
                while (datareader.Read())
                {
                    if (Convert.ToInt32(datareader["UserID"]) == player.playerId)
                    {
                        if (building is Bank)
                        {
                            if (building.cost * amount < Convert.ToInt32(datareader["Banks"]))
                                return true;
                        }
                        if (building is Barracks)
                        {
                            if (building.cost * amount < Convert.ToInt32(datareader["Barracks"]))
                                return true;
                        }
                        if (building is Lab)
                        {
                            if (building.cost * amount < Convert.ToInt32(datareader["Labs"]))
                                return true;
                        }
                       
                    }

                }
            }
            return false;
        }
        public bool CanYouAffordResearching(Research research, int amount, Player player)
        {

            string sql = "Select * from Player";
            var command = new SqlCommand(sql, connection);

            using (var datareader = command.ExecuteReader())
            {
                while (datareader.Read())
                {
                    if (Convert.ToInt32(datareader["UserID"]) == player.playerId)
                    {
                        if (research.cost* amount > Convert.ToInt32(datareader["Money"]))
                            return true;
                    }

                }
            }
            return false;
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
