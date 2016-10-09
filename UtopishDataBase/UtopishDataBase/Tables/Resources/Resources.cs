using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDatabase
{
    public class Resources
    {
        [Key]
        public int ResourcesID { get; set; }
        [Required]
        [MaxLength(50)]
        public string ResourceName { get; set; }
    }
}