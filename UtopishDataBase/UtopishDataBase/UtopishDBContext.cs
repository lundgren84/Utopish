using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using UtopishDatabase;

namespace UtopishDataBase
{
    public class UtopishDBContext : DbContext
    {
        public UtopishDBContext() : base("name =UtopishDataBaseDBContextConectionString")
        {


    }   
        public DbSet<Player> Player { get; set; }
        public DbSet<PlayerTroops> PlayerTroops { get; set; }
        public DbSet<PlayerShips> PlayerShips { get; set; }
        public DbSet<PlayerPlanets> PlayerPlanets { get; set; }
        public DbSet<PlayerLocation> PlayerLocation { get; set; }
        public DbSet<PlayerResearch> PlayerResearch { get; set; }
        public DbSet<PlayerBuildings> PlayerBuildings { get; set; }
        public DbSet<PlayerMail> PlayerMail { get; set; }
        public DbSet<PlayerResources> PlayerResources { get; set; }

        public DbSet<Troops> Troops { get; set; }
        public DbSet<Ships> Ships { get; set; }
        public DbSet<Planets> Planets { get; set; }
        public DbSet<Galaxy> Galaxy { get; set; }
        public DbSet<LocalCluster> LocalCluster { get; set; }
        public DbSet<SolarSystem> SolarSystem { get; set; }
        public DbSet<Buildings> Buildings { get; set; }
        public DbSet<Mail> Mail { get; set; }
        public DbSet<Research> Research { get; set; }

    }
}