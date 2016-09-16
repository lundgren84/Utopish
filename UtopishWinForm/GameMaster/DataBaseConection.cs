using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheGame
{
    public class DataBaseConection
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
        public void CreateAccount(string username, string password, string email)
        {
            string sql = $@"Insert into  Accounts (AccountName,AccountPassword,AccountEmail,Gold,Power,Bank_Quant,Size,Archer_Quant,Knight_Quant,MountKnight_Quant,Lab_Quant,Barrack_Quant) 
            Values('" + username + "','" + password + "','" + email + "','" + 1000 + "','" + 0 + "','" + 1 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public string CheckRegister(string username, string email)
        {
            string sql = $@"Select * From Accounts";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (username == (string)dataReader["AccountName"])
                    {
                        return "Username";
                    }
                    if (email == (string)dataReader["AccountEmail"])
                    {
                        return "Mail";
                    }
                }
                dataReader.Close();
                return "Clear";
            }
        }
        public void Fillsoldiers()
        {
            string sql;

            RemoveSoldiers("Archers");
            //Archers
            //-----------------------------------------------------------------------------Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Archers (Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 100 + "','" + 100 + "','" + 50 + "','" + 10 + "','" + 1 + "','" + "Archer" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-----------------------------------------------------------------------------Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Archers (Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 200+ "','" + 150 + "','" + 100 + "','" + 20 + "','" + 2 + "','" + "Armored Archers" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-----------------------------------------------------------------------------Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Archers (Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 500 + "','" + 250 + "','" + 200 + "','" + 30 + "','" + 3 + "','" + "Holy Archers" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }

            //Knights
            RemoveSoldiers("Knights");
            //-----------------------------------------------------------------------------Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Knights (Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 200 + "','" + 200 + "','" + 100 + "','" + 25 + "','" + 1 + "','" + "Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-----------------------------------------------------------------------------Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  Knights (Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 400 + "','" + 400 + "','" + 200 + "','" + 50 + "','" + 2 + "','" + "Armored Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //-----------------------------------------------------------------------------Cost          HP         AttackPower    Armor          Tier            Name
            sql = @"Insert into  Knights (Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 800 + "','" + 800 + "','" + 400 + "','" + 1000 + "','" + 3 + "','" + "Holy Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //MountedKnights
            RemoveSoldiers("MountedKnights");
            //------------------------------------------------------------------------------------Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  MountedKnights (Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 200 + "','" + 200 + "','" + 100 + "','" + 25 + "','" + 1 + "','" + "Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //------------------------------------------------------------------------------------Cost          HP         AttackPower    Armor       Tier            Name
            sql = @"Insert into  MountedKnights (Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 400 + "','" + 400 + "','" + 200 + "','" + 50 + "','" + 2 + "','" + "Armored Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //------------------------------------------------------------------------------------Cost          HP         AttackPower    Armor          Tier            Name
            sql = @"Insert into  MountedKnights (Cost,HP,AttackPower,Armor,Tier,Name) Values('" + 800 + "','" + 800 + "','" + 400 + "','" + 1000 + "','" + 3 + "','" + "Holy Knight" + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
       public void AddFluffyAcc()
        {
            RemoveFluffy();
            InsertNewPlayer();
        }

        private void RemoveFluffy()
        {
          
          string sql = $"Delete From Accounts Where AccountName = 'Fluffy'";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                try { command.ExecuteNonQuery(); } catch { }
            }
        }

        public void InsertNewPlayer()
        {
            string sql = @"Insert into  Accounts (AccountName,AccountPassword,AccountEmail,Gold,Power,Size,Archer_Quant,Knight_Quant,MountKnight_Quant,Bank_Quant,Lab_Quant,Barrack_Quant) 
            Values('" + "Fluffy" + "','" + "123" + "','" + "Fluffy@hotmail.fluff" + "','" + 15430 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void RemoveGold(int totalCost, string accName)
        {
            string sql = $@" Update Accounts Set Gold =(Select Gold From Accounts Where AccountName = '{accName}') -'{totalCost}'  Where AccountName = '{accName}'";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void AddToQuant(string Quant, int Amount, string accName)
        {
            string sql = $@"Update Accounts Set {Quant} ='{Amount}'+(Select {Quant} From Accounts Where AccountName = '{accName}') Where AccountName = '{accName}' ";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public int GetPrice(string Table, int Tier)
        {
            string sql = "";
            int result = 0;
            if (Tier > 0)
            {
                 sql = $"Select Cost From {Table} Where Tier ='{Tier}'";
            }
            else
            {
               sql = $"Select Cost From {Table}";
            }
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = (int)dataReader["Cost"];
                }
                dataReader.Close();
            }
            return result;
        }

        public List<string> GetAllEnemys()
        {
            string name = "";
            int power = 0;
            int gold = 0;
            int troops = 0;
            List<string> enemies = new List<string>();
            string sql;
            sql = $@"Select * From Accounts";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                   
                    name = (string)dataReader["AccountName"];
                    power = (int)dataReader["Power"];
                    gold = (int)dataReader["Gold"];
                        //  troops = (int)dataReader["Archer_Quant"+"Knight_Quant"+"MountKnight_Quant"];
                    

                    enemies.Add(name + "." + power.ToString() + "." + gold.ToString() + "." + troops.ToString());
                }
                dataReader.Close();
            }
            return enemies;
        }

        public string GetAccInfo(string Value, string accName)
        {
            string result = "";
            int intResult = 0;
            string sql;
            sql = $@"Select {Value} From Accounts WHERE AccountName = '{accName}'";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    intResult = (int)dataReader[Value];
                }
                dataReader.Close();
            }
            result = intResult.ToString();
            return result;
        }

        public bool CheckLoggin(string UserName, string Password)
        {

            string sql = $"Select * From Accounts";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    try
                    {
                        if ((string)dataReader["AccountName"] == UserName && (string)dataReader["AccountPassword"] == Password)
                            return true;
                    }
                    catch (SqlException)
                    {

                    }
                }
                return false;
            }
        }

        internal void UpdateResourses()
        {
            List<string> NameList = new List<string>();

            string sql;

            sql = $@"Select AccountName From Accounts";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    NameList.Add((string)dataReader["AccountName"]);
                }
                dataReader.Close();
            }

            foreach (var item in NameList)
            {
                sql = $@"Update Accounts Set Gold =((Select Gold From Accounts Where AccountName = '{item}')+(Select Bank_Quant From Accounts Where AccountName = '{item}')) Where AccountName = '{item}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        internal void FillBuildings()
        {
            string sql;
            //Banks
            RemoveBuildings("Banks");
            sql = @"Insert into  Banks (Cost) Values('" + 200 + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //Labs
            RemoveBuildings("Labs");
            sql = @"Insert into  Labs (Cost) Values('" + 200 + "')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            //Barracks
            RemoveBuildings("Barracks");
            sql = @"Insert into  Barracks (Cost) Values('" + 200 + "')";
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
