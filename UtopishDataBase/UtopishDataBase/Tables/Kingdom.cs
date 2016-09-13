using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class Kingdom
    {
       
        public int KingdomID { get; set; }
        //Properties
        public string KingdomName { get; set; }
        public int gold { get; set; }
        public int stone { get; set; }
        public int wood { get; set; }
        //Collections
        public ICollection<Building> Buildings { get; set; }
        public ICollection<Soldier> Soldiers { get; set; }

        public Kingdom()
        {
            this.Buildings = new HashSet<Building>();
            this.Soldiers = new HashSet<Soldier>();
        }
        //public int? AccountRedID { get; set; }
        //[ForeignKey(name: "AccountRedID")]
        //public virtual Account Account { get; set; }
    }
}