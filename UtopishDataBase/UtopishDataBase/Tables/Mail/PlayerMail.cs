using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class PlayerMail
    {
        [Key, Column(Order = 0)]
        public int PlayerID { get; set; }


        [Key, Column(Order = 1)]
        public int MailID { get; set; }


        public virtual Player Player { get; set; }
        public virtual Mail Mail { get; set; }
        [Required]
        public bool IsRead { get; set; }
        public string From { get; set; }
        public string Too { get; set; }

    }
}