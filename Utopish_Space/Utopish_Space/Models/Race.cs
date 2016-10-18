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

        internal List<RaceObject> GetAllRacesFromDB()
        {
            List<RaceObject> theRaceObjects = new List<RaceObject>();
            string query = $@"SELECT * FROM Races";
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //  theRaceObjects.Add(reader["RaceName"].ToString());   
                            RaceObject newRace = new RaceObject();                    
                            newRace.raceName = (RaceName)Enum.Parse(typeof(RaceName), reader["RaceName"].ToString());
                            newRace = newRace.GetRace(newRace.raceName);
                            newRace.RaceID = int.Parse(reader["RaceID"].ToString());
                            theRaceObjects.Add(newRace);
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
            return theRaceObjects;
        }  

        internal int GetRaceID(string v)
        {
            throw new NotImplementedException();
        }
    }
}