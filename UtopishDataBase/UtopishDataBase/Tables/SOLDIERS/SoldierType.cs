using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class SoldierType
    {
        //-------P-Key-------
        public int SoldierTypeID { get; set; }

        //-------e Name-------
        [Required]      
        [Display(Name = "Soldier Type")]
        public string SoldierTypeName { get; set; }
    }
}