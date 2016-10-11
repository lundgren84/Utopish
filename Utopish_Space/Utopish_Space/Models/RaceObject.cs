using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utopish_Space.Models
{
    public class RaceObject
    {
        public string RaceName { get; set; }
        public string History { get; set; }
        public List<string> BonusList { get; set; }
    }
}