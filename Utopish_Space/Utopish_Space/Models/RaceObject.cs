using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Utopish_Space.Models
{
    public enum RaceName
    {
        Human,
        Centian,
        Mixxal,
        Raptor,
        Rogan,
        Fenixian,
    }
    public enum Manipulators
    {
        CashManipulator,
        OilManipulator,
        MineralManipulator,
        SuperResourceManipulator,
        TroopStrengthManipulator,
        TroopCostManiplator,
        TroopTrainingTimeManipulator,
        ShipStrengthManipulator,
        ShipCostManipulator,
        ShipTrainingTimeManipulator,
        AttacksSpeedManipulator,
        ResearchEfficiencyManipulator,
        ResearchCostManipulator,
        ResearchTrainingTimeManipulator,
        TradesPerDayManipulator,
        TradeCostManipulator,
        GalaxyHoldManipulator,
        ElectricityRequiredManipulator,
    }
    public class RaceObject
    {
        public RaceName raceName { get; set; }
        public string History { get; set; }
        public Dictionary<Manipulators, int> ManipulatorList = new Dictionary<Manipulators, int>();
        public Image img { get; set; }


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
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator,10);

            return raceObject;
        }

        private RaceObject GetRogan()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Rogan;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator,10);

            return raceObject;
        }

        private RaceObject GetRaptor()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Raptor;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator,10);

            return raceObject;
        }

        private RaceObject GetMixxal()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Mixxal;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator,10);

            return raceObject;
        }

        private RaceObject GetCentian()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Centian;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator,10);

            return raceObject;
        }

        private RaceObject GetHuman()
        {
            RaceObject raceObject = new RaceObject();
            raceObject.History = "";
            raceObject.raceName = RaceName.Human;
            raceObject.img = null;

            //Attributes uniqe to the race
            raceObject.ManipulatorList.Add(Manipulators.AttacksSpeedManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.CashManipulator,10);
            raceObject.ManipulatorList.Add(Manipulators.MineralManipulator,10);

            return raceObject;
        }
    }
 
}