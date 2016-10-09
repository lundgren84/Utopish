using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class PlayerProtectionLevel
    {
        [Key, Column(Order = 0)]
        public int PlayerID { get; set; }


        [Key, Column(Order = 1)]
        public int ProtectionLevelID { get; set; }


        public virtual Player Player { get; set; }
        public virtual ProtectionLevel ProtectionLevel { get; set; }
        [Required]
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
        public string Source { get; set; }
    }
}