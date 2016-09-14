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
        public DbSet<Account> Account { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Archer> Archer { get; set; }
        public DbSet<Knight> Knight { get; set; }
        public DbSet<MountedKnight> MountedKnight { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Lab> Lab { get; set; }
        public DbSet<Barrack> Barrack { get; set; }
    }
}