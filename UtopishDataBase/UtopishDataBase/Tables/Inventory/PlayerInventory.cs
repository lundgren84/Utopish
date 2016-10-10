using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class PlayerInventory
    {
        [Key, Column(Order = 0)]
        public int PlayerID { get; set; }


        [Key, Column(Order = 1)]
        public int Slot1ID { get; set; }

        [Key, Column(Order = 2)]
        public int Slot2ID { get; set; }

        [Key, Column(Order = 3)]
        public int Slot3ID { get; set; }

        [Key, Column(Order = 4)]
        public int Slot4ID { get; set; }

        public virtual Player Player { get; set; }
        public virtual Items Slot1Item { get; set; }
        public virtual Items Slot2Item { get; set; }
        public virtual Items Slot3Item { get; set; }
        public virtual Items Slot4Item { get; set; }

    }
}