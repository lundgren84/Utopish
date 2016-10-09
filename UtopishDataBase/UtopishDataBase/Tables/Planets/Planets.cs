using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class Planets
    {
        [Key]
        public int PlanetID { get; set; }
        [Required]
        public string PlanetName { get; set; }
    }
}