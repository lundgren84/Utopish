using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSpaceDatabase
{
    public class Resources
    {
        [Required]
        public int ResourcesID { get; set; }
        [Required]
        public string ResourceName { get; set; }
    }
}