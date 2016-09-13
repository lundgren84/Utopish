using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class BuildingType
    {
        public int BuildingTypeID { get; set; }

        //-------e Name-------
        [Required]
        [Display(Name = "Building Type")]
        public string BuildingTypeName { get; set; }
    }
}