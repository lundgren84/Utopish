using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class PlayerPlanets
    {
        [Key, Column(Order = 0)]
        public int PlayerID { get; set; }


        [Key, Column(Order = 1)]
        public int PlanetsID { get; set; }


        public virtual Player Player { get; set; }
        public virtual Planets Planet { get; set; }
        [Required]
        public int CurrentSize { get; set; }
        public int MaxSize { get; set; }
    }
}