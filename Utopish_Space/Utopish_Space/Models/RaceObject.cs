using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utopish_Space.Models
{
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
        public string RaceName { get; set; }
        public string History { get; set; }
        public List<Manipulators> ManipulatorList { get; set; }
    }
}