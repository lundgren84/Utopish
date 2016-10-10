using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class PlayerEquipped
    {
        [Key, Column(Order = 0)]
        public int PlayerID { get; set; }


        [Key, Column(Order = 1)]
        public int ItemID { get; set; }






        public virtual Player Player { get; set; }
        public virtual Items Item { get; set; }
    }
}