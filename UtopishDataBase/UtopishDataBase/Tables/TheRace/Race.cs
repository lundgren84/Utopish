using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UtopishDataBase
{
    public class Race
    {
        [Key]
        public int RaceID { get; set; }
        [Required]
        [MaxLength(50)]
        public string RaceName { get; set; }
    }
}