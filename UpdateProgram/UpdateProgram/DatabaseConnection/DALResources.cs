using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UpdateProgram
{
    class DALResources
    {
        SqlConnection connection = new SqlConnection();
        public void CalculateAndUpdatePlayerResources()
        {
            string sql =
                "SELECT " +
                "prod.ProductID, " +
                "prod.ProductName, " +
                "category.Category, " +
                "size.Size, " +
                "color.Color, " +
                "brand.Brand, " +
                "prod.Description, " +
                "prod.PricePerUnit, " +
                "prod.UnitsInStock, " +
                "prod.PictureID " +
                "from Player AS p ";

            sql += "INNER JOIN tblCategory AS category ON prod.CategoryID = category.CategoryID " +
                "INNER JOIN tblColor AS color ON color.ColorID = prod.ColorID " +
                "INNER JOIN tblSize AS size ON size.SizeID = prod.SizeID " +
                "INNER JOIN tblBrand AS brand ON brand.BrandID = prod.BrandID WHERE ";

        }
        public void DefineTheHourlyUpdate(int PlayerID)
        {
            string sql = $@"Select 
                         PlayerPlanet.Size, 
                         from Player
                         INNER JOIN Player ON PlayerPlanet.PlayerID = Player.PlayerID
                         WHERE PlayerID = {PlayerID}";

            connection.ConnectionString = @"Data source=217.210.151.153,1433; Network Library=DBMSSOCN; Initial Catalog=Webbshop; User ID = guest; Password=temppass22;";
            using (connection)
            {
                SqlCommand cmd = new SqlCommand(sql, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                }
            }
            sql =        $@"Select 
                         BuildingName, 
                         Quantity
                         FROM PlayerBuildings
                         INNER JOIN Player ON PlayerBuildings.PlayerID = Player.PlayerID
                         WHERE PlayerID = {PlayerID}
                         AND WHERE BuildingName = Banks";

        }


    }
    }
}
