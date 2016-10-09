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
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public int PlayerRefID { get; set; }
        [ForeignKey(name: "PlayerID")]

    }
}