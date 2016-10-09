using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSpaceDatabase
{ 
    public class SolarSystem
    {
        public int SolarSystemID { get; set; }
        [Required]
        public int SolarSystemNumber { get; set; }
        [Required]
    }
}