using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSpaceDatabase
{
    public class PlayerResources
    {
        [Key, Column(Order = 0)]
        public int PlayerID { get; set; }


        [Key, Column(Order = 1)]
        public int ResourcesID { get; set; }


        public virtual Player Player { get; set; }
        public virtual Resources Resources { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int? Max { get; set; }
    }
}