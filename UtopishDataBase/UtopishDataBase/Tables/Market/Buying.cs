using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class Buying
    {

        [Key, Column(Order = 1)]
        public int MarketContentID { get; set; }

        public virtual MarketContent AskingPrice { get; set; }

    }
}