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
                            Race race = new Race();                  
                            newRace.raceName = (RaceName)Enum.Parse(typeof(RaceName), reader["RaceName"].ToString());
                            newRace = race.GetRace(newRace.raceName);
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
        public RaceObject GetRace(RaceName raceName)
        {
            RaceObject rightRace = new RaceObject();
            switch (raceName)
            {
                case RaceName.Human:
                    rightRace = GetHuman();
                    break;
                case RaceName.Centian:
                    rightRace = GetCentian();
                    break;
                case RaceName.Mixxal:
                    rightRace = GetMixxal();
                    break;
                case RaceName.Raptor:
                    rightRace = GetRaptor();
                    break;
                case RaceName.Rogan:
                    rightRace = GetRogan();
                    break;
                case RaceName.Fenixian:
                    rightRace = GetFenixian();
                    break;
                default:
                    break;
            }
            return rightRace;
        }

        private RaceObject GetFenixian()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Fenixian;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator, 10);

            return raceObject;
        }

        private RaceObject GetRogan()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Rogan;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator, 10);

            return raceObject;
        }

        private RaceObject GetRaptor()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Raptor;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator, 10);

            return raceObject;
        }

        private RaceObject GetMixxal()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Mixxal;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator, 10);

            return raceObject;
        }

        private RaceObject GetCentian()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Centian;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator, 10);

            return raceObject;
        }

        private RaceObject GetHuman()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Human;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator, 10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator, 10);

            return raceObject;
        }
    }
}