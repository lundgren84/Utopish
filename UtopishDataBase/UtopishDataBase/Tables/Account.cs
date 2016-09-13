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

        public int? KingdomRefID { get; set; }
        [ForeignKey(name: "KingdomRefID")]
        public virtual Kingdom Kingdom { get; set; }
    }
}