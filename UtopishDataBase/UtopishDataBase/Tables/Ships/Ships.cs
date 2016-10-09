using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDatabase
{
    public class Ships
    {
        [Key]
        public int ShipsID { get; set; }
        [Required]
        public string ShipName { get; set; }

    }
}