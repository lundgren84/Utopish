using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaster
{
    class DataBaseConection
    {
        private SqlConnection connection = null;

        //"Data Source = (local);Initial Catalog = {DataBaseName}; User ID ={UserName}; password = {password}; integrated Security = true" 
        public void OpenConnection(string connectionString)
        {
            connection = new SqlConnection { ConnectionString = connectionString };
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
            connection.Dispose();
        }

        public void Fillsoldiers()
        {
            string sql;
          
            RemoveSoldiers("Archers");
            //Archers
            //-------------------------------------------------------------------------------------Quantity        Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Archers (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 100 + "','" + 100 + "','" + 50 + "','" + 10 + "','" + 1 + "','" + "Archer" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-------------------------------------------------------------------------------------Quantity       Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Archers (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 300 + "','" + 150 + "','" + 100 + "','" + 20 + "','" + 2 + "','" + "Armored Archers" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-------------------------------------------------------------------------------------Quantity       Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Archers (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 500 + "','" + 250 + "','" + 200 + "','" + 30 + "','" + 3 + "','" + "Holy Archers" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }

            //Knights
            RemoveSoldiers("Knights");
            //-------------------------------------------------------------------------------------Quantity       Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Knights (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 200 + "','" + 200 + "','" + 100 + "','" + 25 + "','" + 1 + "','" + "Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-------------------------------------------------------------------------------------Quantity       Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Knights (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 400 + "','" + 400 + "','" + 200 + "','" + 50 + "','" + 2 + "','" + "Armored Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-------------------------------------------------------------------------------------Quantity       Cost          HP         AttackPower    Armor          Tier            Name
            sql = @"Insert into  Knights (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 800 + "','" + 800 + "','" + 400 + "','" + 1000 + "','" + 3 + "','" + "Holy Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //MountedKnights
            RemoveSoldiers("MountedKnights");
            //-------------------------------------------------------------------------------------------Quantity       Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  MountedKnights (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 200 + "','" + 200 + "','" + 100 + "','" + 25 + "','" + 1 + "','" + "Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-------------------------------------------------------------------------------------------Quantity       Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  MountedKnights (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 400 + "','" + 400 + "','" + 200 + "','" + 50 + "','" + 2 + "','" + "Armored Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-------------------------------------------------------------------------------------------Quantity       Cost          HP         AttackPower    Armor          Tier            Name
            sql = @"Insert into  MountedKnights (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 800 + "','" + 800 + "','" + 400 + "','" + 1000 + "','" + 3 + "','" + "Holy Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal void UpdateResourses()
        {
            string sql;
            sql = @"Select Gold From Accounts (Gold) Values('" + 0 + "','" + 200 + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal void FillBuildings()
        {
            string sql;
            //Banks
            RemoveBuildings("Banks");
            sql = @"Insert into  Banks (Quantity ,Cost) Values('" + 0 + "','" + 200 + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //Labs
            RemoveBuildings("Labs");
            sql = @"Insert into  Labs (Quantity ,Cost) Values('" + 0 + "','" + 200 + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //Barracks
            RemoveBuildings("Barracks");
            sql = @"Insert into  Barracks (Quantity ,Cost) Values('" + 0 + "','" + 200 + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void RemoveSoldiers(string SoldierTable)
        {
            string sql;
            //Archers
            int tier = 1;
            while (tier <= 3)
            {
                sql = $"Delete From {SoldierTable} Where Tier = '{tier}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    try { command.ExecuteNonQuery(); } catch { }
                }
                tier++;
            }

        }
        private void RemoveBuildings(string BuildingTable)
        {
            string sql;
            sql = $"Delete From {BuildingTable}";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                try { command.ExecuteNonQuery(); } catch { }
            }
        }
    }
}
