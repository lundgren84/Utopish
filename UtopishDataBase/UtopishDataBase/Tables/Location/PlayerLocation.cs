using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopishDataBase
{
    public class PlayerLocation
    {
        [Key, Column(Order = 0)]
        public int PlayerID { get; set; }

        [Key, Column(Order = 1)]
        public int GalaxyID { get; set; }
        [Key, Column(Order = 2)]

        public int LocalClusterID { get; set; }
        [Key, Column(Order = 3)]
        public int SolarSystemID { get; set; }

        public virtual Player Player { get; set; }
        public virtual LocalCluster LocalCluster { get; set; }
        public virtual Galaxy Galaxy { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }


    }
}