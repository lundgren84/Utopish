using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSpaceDatabase
{
    public class Troops
    {
        [Required]
        public int TroopsID { get; set; }
        [Required]
        public string TroopName { get; set; }
      

      
    }
}