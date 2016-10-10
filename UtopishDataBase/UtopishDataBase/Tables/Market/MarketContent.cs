using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase

{
    public class MarketContent
    {

        public int? Oil { get; set; }
        public int? Minerals { get; set; }
        public int? Credits { get; set; }
        public int? SpecialCredits { get; set; }
        public int? SpecialResource { get; set; }



    }
}