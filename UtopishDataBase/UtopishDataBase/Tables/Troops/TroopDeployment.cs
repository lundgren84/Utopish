using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class TroopDeployment
    {
        [Key]
        public int TroopDeploymentID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TroopDeploymentName { get; set; }
    }
}