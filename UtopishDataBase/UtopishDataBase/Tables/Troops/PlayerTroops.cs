using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDataBase;

namespace UtopishDatabase
{
    public class PlayerTroops
    {

        [Key, Column(Order = 0)]
        public int PlayerID { get; set; }


        [Key, Column(Order = 1)]
        public int TroopsID { get; set; }
        [Key, Column(Order = 2)]
        public int TroopDeploymentID { get; set; }
        [Key, Column(Order = 3)]
        public int PlayerToAttackID { get; set; }


        public virtual Player Player { get; set; }
        public virtual Troops Troops { get; set; }
        public virtual TroopDeployment TroopDeployment { get; set; }
        public virtual Player PlayerToAttack { get; set; }
        [Required]
        public int Quantity { get; set; }

    }
}