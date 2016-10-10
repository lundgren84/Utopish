using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDataBase;

namespace UtopishDatabase
{
    public class PlayerShips
    {
        [Key, Column(Order = 0)]
        public int PlayerID { get; set; }


        [Key, Column(Order = 1)]
        public int ShipsID { get; set; }
        [Key, Column(Order = 1)]
        public int ShipDeploymentID { get; set; }


        public virtual Player Player { get; set; }
        public virtual Ships Ships { get; set; }
        public virtual ShipDeployment ShipDeployment { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}