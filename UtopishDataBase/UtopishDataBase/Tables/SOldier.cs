using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UtopishDataBase
{
    public class Soldier
    {
        public int SoldierID { get; set; }
   
        //-------F-Key------
        public int? SoldierTypeRefID { get; set; }
        [ForeignKey(name: "SoldierTypeRefID")]
        public virtual SoldierType CauseType { get; set; }
    }
}