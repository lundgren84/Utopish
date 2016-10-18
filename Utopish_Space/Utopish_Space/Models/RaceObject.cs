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
        public int RaceID { get; set; }
        public RaceName raceName { get; set; }
        public string History { get; set; }
        public Dictionary<Manipulators, int> ManipulatorList = new Dictionary<Manipulators, int>();
        public Image img { get; set; }


       
    }
 
}