using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSpaceDatabase
{
    public class Buildings
    {
        public int BuildingID { get; set; }
        [Required]
        public string BuildingName { get; set; }
        [Required]
       
    }
}