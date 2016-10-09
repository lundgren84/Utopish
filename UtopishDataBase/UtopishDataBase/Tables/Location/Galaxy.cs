using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class Galaxy
    {
        [Required]
        public int GalaxyID { get; set; }
        [Required]
        public int GalaxyNumber { get; set; }
    }
}