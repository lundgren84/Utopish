using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSpaceDatabase
{
    public class PlayerTroops
    {
        [Required]
        public int Quantity { get; set; }
        //-----------ForenKeys------------
        //Location
        public int PlayerRefID { get; set; }
        [ForeignKey(name: "PlayerID")]

        [Required]
        public int TroopsRefID { get; set; }
        [ForeignKey(name: "TroopsID")]

    }
}