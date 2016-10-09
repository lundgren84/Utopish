using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace ProjectSpaceDatabase
{
    public class Terrain
    {
        [Required]
        public int TerrainID { get; set; }
        [Required]
        public string TerrainType { get; set; }
    }
}