using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UtopishDatabase
{
    public class UtopishDataBaseContext : DbContext
    {
        public UtopishDataBaseContext() : base("name =UtopishDataBaseContextConectionString")
        {
        }
    }
}