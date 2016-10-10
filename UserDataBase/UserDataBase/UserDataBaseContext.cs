using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserDataBase.Tables;

namespace UserDataBase
{
    public class UserDataBaseContext : DbContext
    {
            public UserDataBaseContext() : base("name =UserDataBaseContextConectionString")
            {

            }
        public DbSet<Status> Status { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}