using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UtopishDataBase
{
    public class Race
    {
        [Required]
        public int RaceID { get; set; }
        [Required]
        public string RaceName { get; set; }
    }
}