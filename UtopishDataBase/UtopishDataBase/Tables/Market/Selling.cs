﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class Selling
    {

        [Key, Column(Order = 0)]
        public int SellingID { get; set; }

        public virtual MarketContent ForSale { get; set; }


    }
}