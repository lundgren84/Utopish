using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace UtopishDataBase
{
    public class Terrain
    {
        [Key]
        public int TerrainID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TerrainType { get; set; }
    }
}