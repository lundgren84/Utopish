using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{ 
    public class Mail
    {
        [Key]
        public int MailID { get; set; }
        [Required]
        [MaxLength(500)]
        public string MailContentMessage { get; set; }
    }
}