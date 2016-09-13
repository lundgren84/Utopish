using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UtopishDataBase
{
    public class UtopishDBContext : DbContext
    {
        public UtopishDBContext() : base("name =UtopishDataBaseDBContextConectionString")
        {


    }
        public DbSet<Kingdom> Kingdom { get; set; }
        public DbSet<Soldier> Soldier { get; set; }
        public DbSet<SoldierType> SoldierType { get; set; }
        public DbSet<BuildingType> BuildingType { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}