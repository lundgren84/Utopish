﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDataBase;

namespace UtopishDatabase
{
    public class Player
    {
        [Required]
        public int PlayerID { get; set; }
        [Required]
        public int PlayerAccountNumber { get; set; }
        [Required]
        [MaxLength(50)]
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
        public int DailyTradesLeft { get; set; }
        [Required]
        public bool DonatorStatus { get; set; } 
        //-----------ForenKeys------------
        //Location
        public int RaceRefID { get; set; }
        [ForeignKey(name: "RaceRefID")]
        public virtual Race Race { get; set; }

    }

}