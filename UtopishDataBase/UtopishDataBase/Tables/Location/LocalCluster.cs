using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class LocalCluster
    {
        [Required]
        public int LocalClusterID { get; set; }
        [Required]
        public int LocalClusterNumber { get; set; }

    }
}