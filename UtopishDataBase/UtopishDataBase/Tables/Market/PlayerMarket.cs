using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UtopishDatabase;

namespace UtopishDataBase
{ 
    public class PlayerMarket
    {
    [Key, Column(Order = 0)]
    public int PlayerID { get; set; }


    [Key, Column(Order = 1)]
    public int SellingID { get; set; }

    [Key, Column(Order = 1)]
    public int BuyingID { get; set; }




    public virtual Player Player { get; set; }
    public virtual Buying Deal { get; set; }
    public virtual Selling Price { get; set; }
    [Required]
    public DateTime Made { get; set; }
    public DateTime Expires { get; set; }
    }
}