using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDatabase
{
    public class Troops
    {
        [Key]
        public int TroopsID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TroopName { get; set; }
      

      
    }
}