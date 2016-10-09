using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSpaceDatabase
{
    public class Player
    {
        [Required]
        public int PlayerID { get; set; }
        [Required]
        public int PlayerAccountNumber { get; set; }
        [Required]
        public string EmpireName { get; set; }
        [Required]
        public int TradeBalance { get; set; }
        [Required]
        public int Strength { get; set; }
        [Required]
        public int Level { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        //-----------ForenKeys------------
        //Location
        public int RaceRefID { get; set; }
        [ForeignKey(name: "RaceID")]

        [Required]
        public int LocationRefID { get; set; }
        [ForeignKey(name: "LocationID")]

     
        public ICollection<Planet> Planet;
        public Player()
        {
            this.Planet = new HashSet<Planet>();
        }

    }
}