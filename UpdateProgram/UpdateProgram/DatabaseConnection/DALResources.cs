using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateProgram
{
    class DALResources
    {
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

        }
    }
}
