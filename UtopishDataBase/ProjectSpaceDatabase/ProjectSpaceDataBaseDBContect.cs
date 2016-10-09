using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProjectSpaceDatabase
{
    public class ProjectSpaceDataBaseDBContect: DbContext
    {

            public ProjectSpaceDataBaseDBContect() : base("name =ProjectSpaceDataBaseDBContectConectionString")
            {


            }
           // public DbSet<KlassNamn> KlassNamn { get; set; }
       
        }

    
}