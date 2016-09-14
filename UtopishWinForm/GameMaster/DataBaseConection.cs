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
            //Archers
            //-------------------------------------------------------------------------------------Quantity        Cost          HP         AttackPower    Armor       Tier            Name
             sql = @"Insert into  Archers (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 100 + "','" + 100 + "','" + 50 + "','" + 10 + "','" + 1 + "','" + "Archer" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-------------------------------------------------------------------------------------Quantity       Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Archers (Quantity , Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 0 + "','" + 300 + "','" + 150 + "','" +100 + "','" + 20 + "','" + 2 + "','" + "Armored Archers" + "')";
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
        }
    }
}
