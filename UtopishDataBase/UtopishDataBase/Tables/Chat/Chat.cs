using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class Chat
    {
        [Key]
        public int ChatID { get; set; }
        [MaxLength(500)]
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }

        // F-Key
        public int PlayerRefID { get; set; }
        [ForeignKey(name: "PlayerRefID")]
        public virtual Player Player { get; set; }
    }
}