using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class Items
    {
        [Key]
        public int ItemID { get; set; }
        [Required]
        [MaxLength(100)]
        public string ItemName { get; set; }
        public int? IncomeBonus { get; set; }
        public int? AttackBonus { get; set; }
        public int? DefenseBonus { get; set; }
        [MaxLength(100)]
        public string ItemSpeciality { get; set; }
        [MaxLength(100)]
        public string Slot { get; set; }

        public DateTime ItemCoolDown { get; set; }

    }
}