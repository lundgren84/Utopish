using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class Building
    {

        public int BuildingID { get; set; }

        //-------F-Key------
        public int? BuildingTypeRefID { get; set; }
        [ForeignKey(name: "BuildingTypeRefID")]
        public virtual BuildingType BuildingType { get; set; }
    }
}