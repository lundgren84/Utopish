using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSpaceDatabase
{
    public class Terrain
    {
        [Required]
        public int PlayerID { get; set; }
        [Required]
        public string TerrainType { get; set; }
    }
}