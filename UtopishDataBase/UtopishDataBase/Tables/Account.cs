using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class Account
    {

        public int AccountID { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]       
        public string AccountPassword { get; set; }
        [Required]
        public string AccountEmail { get; set; }
        public int Power { get; set; }
        public int Size { get; set; }
        public int Gold { get; set; }

        //-----------ForenKeys------------
        //Location
        public int? LocationRefID { get; set; }
        [ForeignKey(name: "LocationRefID")]
        public virtual Location Location { get; set; }
        //Soldiers
        public int? ArcherRefID { get; set; }
        [ForeignKey(name: "ArcherRefID")]
        public virtual Archer Archer { get; set; }
        public int? KnightRefID { get; set; }
        [ForeignKey(name: "KnightRefID")]
        public virtual Knight Knight { get; set; }
        public int? MountedKnightRefID { get; set; }
        [ForeignKey(name: "MountedKnightRefID")]
        public virtual MountedKnight MountedKnight { get; set; }
        //Buildings
        public int? LabRefID { get; set; }
        [ForeignKey(name: "LabRefID")]
        public virtual Lab Lab { get; set; }
        public int? BankRefID { get; set; }
        [ForeignKey(name: "BankRefID")]
        public virtual Bank Bank { get; set; }
        public int? BarrackRefID { get; set; }
        [ForeignKey(name: "BarrackRefID")]
        public virtual Barrack Barrack { get; set; }
    }
}