﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;


namespace UtopishDataBase
{
    public class ProtectionLevel
    {
        [Key]
        public int ProtectionLevelID { get; set; }
        [Required]
        public int ProtectionLevelName { get; set; }
    }
}