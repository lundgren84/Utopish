﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class Buildings
    {
        [Key]
        public int BuildingID { get; set; }
        [Required]
        [MaxLength(50)]
        public string BuildingName { get; set; }

       
    }
}