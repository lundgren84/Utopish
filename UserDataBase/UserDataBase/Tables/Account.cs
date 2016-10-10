using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDataBase.Tables
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public string Salt { get; set; }
        [Required]
        public string Hash { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }

        //FK
        public int? StatusRefID { get; set; }
        [ForeignKey(name: "StatusRefID")]
        public virtual Status Status { get; set; }


    }
}