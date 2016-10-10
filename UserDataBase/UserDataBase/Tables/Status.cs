using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDataBase.Tables
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string AccountStatus { get; set; }
    }
}