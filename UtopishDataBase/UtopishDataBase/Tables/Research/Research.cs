using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDatabase
{
    public class Research
    {
        [Key]
        public int ResearchID { get; set; }
        [Required]
        public string ResearchName { get; set; }
    }
}