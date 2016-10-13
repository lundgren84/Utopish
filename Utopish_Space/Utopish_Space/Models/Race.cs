using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utopish_Space.DAL;

namespace Utopish_Space.Models
{
   
    public class Race
    {
        DBConnection connection = new DBConnection();
        internal List<string> GetAllRaceNamesFromDB()
        {
            List<string> theRaceNames = new List<string>();
            string query = $@"SELECT RaceName FROM Races";
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            theRaceNames.Add(reader["RaceName"].ToString());   
                        }
                    }
                }
            }
            catch
            {
                
            }
            finally
            {
                connection.Close();
            }          
            return theRaceNames;
        }
        internal List<RaceObject> GetRaceObjectsFromNames(List<string> list)
        {
            List<RaceObject> result = new List<RaceObject>();
            foreach (var item in list)
            {           
                RaceObject race = new RaceObject();
                race.raceName = (RaceName)Enum.Parse(typeof(RaceName), item);
                result.Add(race);
            }
            return result;
        }
    }
}