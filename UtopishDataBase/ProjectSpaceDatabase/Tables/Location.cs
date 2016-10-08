using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSpaceDatabase
{
    public class Location
    {
        public int LocationID { get; set; }
        [Required]
        public int GalaxyNumber { get; set; }
        [Required]
        public int LocalClusterNumber { get; set; }
        [Required]
        public int SolarSystemNumber { get; set; }
        [Required]
    }
}