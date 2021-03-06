﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TheGame
{
   public class TrainingTroops
    {
        public SqlConnection connection;
        public void CommitAllTransactions(List<Transaction> transactions, Player player)
        {
            OpenConnection();
            string sql = "Select * from Player";
            foreach (var item in transactions)
            {
                var command = new SqlCommand(sql, connection);

                using (var datareader = command.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        if (Convert.ToInt32(datareader["UserID"]) == player.playerId)
                        {
                            int updateValue = Convert.ToInt32(datareader[$"{item.type}"]) + item.quantity;
                            string sql2 = $"UPDATE Player SET {item.type} = '{updateValue}' WHERE UserID = '{player.playerId}';";
                            var command2 = new SqlCommand(sql2, connection);
                        }
                    }
                }
            }
            CloseConnection();
        }
        public void TrainTroops(ArmyUnit unittype, int amount, Player player)
        {
            EstablishConnection();
            OpenConnection();
            if (unittype is Archer)
            {
                string sql = "Select * from Player";
                var command = new SqlCommand(sql, connection);

                using (var datareader = command.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        if (Convert.ToInt32(datareader["UserID"]) == player.playerId)
                        {
                            int updateValue = Convert.ToInt32(datareader["Archer"]) + amount;
                            string sql2 = $"UPDATE Player SET Archer = '{updateValue}' WHERE UserID = '{player.playerId}';";
                            var command2 = new SqlCommand(sql2, connection);
                        }
                    }
                }
            }
            else if (unittype is Knight)
            {
                string sql = "Select * from Player";
                var command = new SqlCommand(sql, connection);

                using (var datareader = command.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        if (Convert.ToInt32(datareader["UserID"]) == player.playerId)
                        {
                            int updateValue = Convert.ToInt32(datareader["Knight"]) + amount;
                            string sql2 = $"UPDATE Player SET Knight = '{updateValue}' WHERE UserID = '{player.playerId}';";
                            var command2 = new SqlCommand(sql2, connection);
                        }

                    }
                }
            }
            else if (unittype is MountedKnight)
            {
                string sql = "Select * from Player";
                var command = new SqlCommand(sql, connection);

                using (var datareader = command.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        if (Convert.ToInt32(datareader["UserID"]) == player.playerId)
                        {
                            int updateValue = Convert.ToInt32(datareader["MountedKnight"]) + amount;
                            string sql2 = $"UPDATE Player SET MountedKnight = '{updateValue}' WHERE UserID = '{player.playerId}';";
                            var command2 = new SqlCommand(sql2, connection);
                        }

                    }
                }
            }
            CloseConnection();
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
